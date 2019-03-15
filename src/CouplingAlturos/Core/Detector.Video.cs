using System;
using System.Threading;
using Accord.Video.FFMPEG;
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

			    while (reader.FrameCount - 2 > indexFrame && !_cancellationTokenSource.IsCancellationRequested)
			    {

				    var frame = reader.ReadVideoFrame();
                    if (frame == null) break; 
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