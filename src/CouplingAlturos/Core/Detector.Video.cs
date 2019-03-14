using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using Accord.Video.FFMPEG;
using Alturos.Yolo;
using CouplingAlturos.Abstractions;
using CouplingAlturos.Core.Converters;
using CouplingAlturos.Core.Models;

namespace CouplingAlturos.Core
{
    partial class Detector
    {
	    private void ProcThread(string filename, IProgress<VideoRecognitionResult> progress)
	    {
		    using (var reader = new VideoFileReader())
		    {
			    reader.Open(filename);
			    var indexFrame = 0;

			    while (reader.FrameCount - 1 > indexFrame && !_cancellationTokenSource.IsCancellationRequested)
			    {
				    var frame = reader.ReadVideoFrame();
				    var result = ProcessImage(frame);

				    var report = new VideoRecognitionResult()
				    {
					    ElapsedTime = result.ElapsedTime,
					    FrameRate = reader.FrameRate.Numerator,
					    ImageBytes = result.ImageBytes,
					    IndexFrame = ++indexFrame,
					    Items = result.Items,
                        TotalFrames = reader.FrameCount
                        
				    };

				    progress.Report(report); //todo: Вместо progress сделать event

				    frame.Dispose();
				    if (_cancellationTokenSource.IsCancellationRequested) break;
			    }

			    reader.Close();
			    OnVideoClosed();
		    }
		}

		public void ProcessVideo(string filename, IProgress<VideoRecognitionResult> progress)
	    {
		    if (_thread != null)
		    {
			    try
			    {
				    if (_thread.IsAlive)
				    {
					    _thread.Join(100);
					    if (_thread.IsAlive) _thread.Abort();
				    }
			    }
			    finally
			    {
				    _thread = null;
			    }
		    }

		    _cancellationTokenSource?.Dispose();
			_cancellationTokenSource = new CancellationTokenSource();
			_thread = new Thread(x => ProcThread(filename, progress));
			_thread.Start();
		}
    }
}