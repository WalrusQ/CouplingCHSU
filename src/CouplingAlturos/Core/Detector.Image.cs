using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using CouplingAlturos.Core.Converters;
using CouplingAlturos.Core.Models;

namespace CouplingAlturos.Core
{
	partial class Detector
	{
		public IRecognitionResult ProcessImage(Image image)
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			var bytes = image.ToByteArray();
			var items = _yolo.Detect(bytes);
			stopwatch.Stop();

			return new ImageRecognitionResult
			{
				ElapsedTime = stopwatch.Elapsed,
				Items = items,
				ImageBytes = bytes,
				ImageName = image.Tag?.ToString()
			};
		}

		/// <summary>
		/// Обрабатывает изображения. Только для тестов. 
		/// </summary>
		public void ProcessImages(IEnumerable<Image> images, IProgress<ImageRecognitionResult> progress)
		{

			if(_thread != null)
			{
				try
				{
					if(_thread.IsAlive)
					{
						_thread.Join(100);
						if(_thread.IsAlive) _thread.Abort();
					}
				}
				finally
				{
					_thread = null;
				}
			}

		    _cancellationTokenSource?.Dispose();
			_cancellationTokenSource = new CancellationTokenSource();

			_thread = new Thread(x =>
			{
				foreach(var image in images)
				{
					var result = ProcessImage(image);
					progress.Report(result as ImageRecognitionResult);
					if(_cancellationTokenSource.IsCancellationRequested) break;
				}
			});

			_thread.Start();
		}
	}
}