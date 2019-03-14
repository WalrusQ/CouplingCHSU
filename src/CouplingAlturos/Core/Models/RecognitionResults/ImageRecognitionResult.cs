using System;
using System.Collections.Generic;
using Alturos.Yolo.Model;

namespace CouplingAlturos.Core.Models
{
	public class ImageRecognitionResult : IRecognitionResult
	{
		public TimeSpan ElapsedTime { get; set; }

		public IEnumerable<YoloItem> Items { get; set; }

		public byte[] ImageBytes { get; set; }

		public string ImageName { get; set; }
	}
}