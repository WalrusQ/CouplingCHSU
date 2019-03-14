using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Alturos.Yolo;
using CouplingAlturos.Abstractions;
using CouplingAlturos.Core.Converters;
using CouplingAlturos.Core.Models;

namespace CouplingAlturos.Core
{
	public partial class Detector : IDetector
	{
		public event EventHandler VideoClosed;

		private readonly YoloWrapper _yolo;

		private Thread _thread;

		private CancellationTokenSource _cancellationTokenSource;

		public YoloMetaInfo YoloMetaInfo { get; }

		public Detector()
		{
			var stopwatch = new Stopwatch();

			stopwatch.Start();
			_yolo = new YoloWrapper(GetConfiguration(), Constants.GpuEnabled);
			stopwatch.Stop();

			YoloMetaInfo = new YoloMetaInfo()
			{
				DetectionSystem = _yolo.DetectionSystem.ToString(),
				GraphicDeviceName = _yolo.EnvironmentReport.GraphicDeviceName,
				ElapsedTime = stopwatch.Elapsed,
			};
		}

		private YoloConfiguration GetConfiguration()
		{
			var configurationDetector = new ConfigurationDetector();
			var config = configurationDetector.Detect(Constants.ResourceFolder);
			return config;
		}

		public void Stop()
		{
			if (_thread != null)
			{
				_cancellationTokenSource.Cancel();
			}
		}

		private void OnVideoClosed()
		{
			VideoClosed?.Invoke(this, EventArgs.Empty);
		}
	}
}