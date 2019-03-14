using System;
using System.Collections.Generic;
using System.Drawing;
using CouplingAlturos.Core.Models;

namespace CouplingAlturos.Core
{
	public interface IDetector
	{
		/// <summary> Мета информация об инициализации детектора </summary>
		YoloMetaInfo YoloMetaInfo { get; }

		/// <summary> Обрабатывает изображения. Только для тестов. </summary>
		void Stop();

		/// <summary> Обрабатывает изображение </summary>
		IRecognitionResult ProcessImage(Image image);

		/// <summary> Обрабатывает изображения. Только для тестов. </summary>
		void ProcessImages(IEnumerable<Image> images, IProgress<ImageRecognitionResult> progress);

		/// <summary> Создает поток для распознавания сцепок из видеофайла </summary>
		void ProcessVideo(string filename, IProgress<VideoRecognitionResult> progress);
	}
}