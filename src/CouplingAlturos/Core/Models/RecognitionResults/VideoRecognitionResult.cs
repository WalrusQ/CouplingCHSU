namespace CouplingAlturos.Core.Models
{
	public class VideoRecognitionResult : ImageRecognitionResult
	{
        public long TotalFrames { get; set; }

		public long IndexFrame { get; set; }

		public long FrameRate { get; set; }
	}
}