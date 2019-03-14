using System;
using System.Collections.Generic;
using System.Drawing;
using Alturos.Yolo.Model;

namespace CouplingAlturos.Core.Models
{
	public class VideoRecognitionResult : ImageRecognitionResult
	{
        public long TotalFrames { get; set; }

		public long IndexFrame { get; set; }

		public long FrameRate { get; set; }
	}
}