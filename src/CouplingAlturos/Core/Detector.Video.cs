using System;
using System.Drawing;
using System.Linq;
using Accord.Video;
using CouplingAlturos.Core.Models;

namespace CouplingAlturos.Core
{
	partial class Detector
	{
		private int _indexFrame;

		private IVideoSource _fileVideoSource;

		public enum VideoDecoderType
		{
			DirectShow,
			// ReSharper disable once InconsistentNaming
			FFMpeg,
		}

		public void ProcessVideo(string filename, IProgress<VideoRecognitionResult> progress, VideoDecoderType decoderType)
		{
			if(decoderType == VideoDecoderType.DirectShow)
			{
				_fileVideoSource = new Accord.Video.DirectShow.FileVideoSource(filename);

			}
			else if(decoderType == VideoDecoderType.FFMpeg)
			{
				_fileVideoSource = new Accord.Video.FFMPEG.VideoFileSource(filename);
			}
			else return;

			var framesCount = GetFramesCount(filename);
			_indexFrame = 0;

			_fileVideoSource.NewFrame += (sender, args) => progress.Report(PrepareReport(args.Frame, _indexFrame++, Convert.ToInt32(framesCount)));
			_fileVideoSource.PlayingFinished += (s, a) => OnVideoClosed();
			_fileVideoSource.Start();
		}

		private VideoRecognitionResult PrepareReport(Image image, int frameIndex, int framesCount)
		{
			if(image == null) return null;
			var result = ProcessImage(image);

			var report = new VideoRecognitionResult()
			{
				ElapsedTime = result.ElapsedTime,
				ImageBytes = result.ImageBytes,
				IndexFrame = frameIndex,
				Items = result.Items,
				TotalFrames = framesCount
			};

			return report;
		}

		private double GetFramesCount(string filename)
		{
			var ffProbe = new NReco.VideoInfo.FFProbe();
			var vInfo = ffProbe.GetMediaInfo(filename);
			var streamInfo = vInfo.Streams.FirstOrDefault(x => x.CodecType.ToLower() == "video");
			var framesCount = 0d;
			if (streamInfo != null)
			{
				framesCount = streamInfo.FrameRate * vInfo.Duration.TotalSeconds;
			}

			return framesCount;
		}
	}
}