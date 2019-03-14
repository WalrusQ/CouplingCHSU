using Accord.Video.FFMPEG;
using Alturos.Yolo;
using Alturos.Yolo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CouplingAlturos.Abstractions;
using CouplingAlturos.Core;
using CouplingAlturos.Core.Converters;
using CouplingAlturos.Core.Models;
using System.Text;
using CouplingAlturos.Core.Extensions;

namespace CouplingAlturos
{

	public partial class MainForm : Form
	{
		#region Helper

		private class VideoRecognitionResults
		{
			public readonly List<IRecognitionResult> Items  = new List<IRecognitionResult>();

			public long Counter { get; set; }

			public long LastFrame { get; set; }
	}

        #endregion

        private string _videoFile;

        private int _incrementValue;
        
        private VideoRecognitionResults _videoRecognitionResults;

		public IDetector Detector { get; }

		public ILogger Logger { get; }

        public MainForm(IDetector detector, ILogger logger)
        {
            Detector = detector;
            Logger = logger;
            InitializeComponent();
			Detector.VideoClosed += DetectorOnVideoClosed;
            toolStripStatusLabelYoloInfo.Text = $@"Detection system: {Detector.YoloMetaInfo.DetectionSystem}";
        }

        private void DetectorOnVideoClosed(object sender, EventArgs e)
        {
            Detector.Stop();
            if (Logger.Messages.Any())
            {
                Logger.Save($@"{DateTime.Now:dd/MM/yy HH-mm-ss}");
                Logger.Clear();
            }
            _playBtn.Enabled = true;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
		{ 
			using (var ofd = new OpenFileDialog() { Filter = @"Image files(*.png; *.jpg; *.jpeg *.bmp | *.png; *.jpg; *.jpeg *.bmp" })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					var image = ofd.FileName;
					if(image == null) return;

					var result = Detector.ProcessImage(Image.FromFile(image));

					dataGridViewResult.DataSource = result.Items;
					picBx.Image = result.AppendBorder();
					OpenPhotoTxtBx.Text = ofd.FileName;

					result.SaveToJson(@"Results", ofd.SafeFileName);
				}
			}
		}

        private void BtnOpenVideo_Click(object sender, EventArgs e)
        {

            using (var ofd = new OpenFileDialog() { Filter = @"Video File(*.avi) | *.avi; *.mp4" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenVideoTxtBx.Text = ofd.FileName;
                    _videoFile = ofd.FileName;
                    pic.BackColor = Color.Black;
                    _playBtn.Enabled = true;
                    
                }
            }
        }

		private void PlayBtn_Click(object sender, EventArgs e)
		{
            _progressBar.Value = 0;
            _playBtn.Enabled = false;
			_videoRecognitionResults = new VideoRecognitionResults();
            var progress = new Progress<VideoRecognitionResult>(OnImageDetected);
    
            Detector.ProcessVideo(_videoFile, progress);
        }

		private void BtnOpenFolder_Click(object sender, EventArgs e)
		{
			using(var folderDialog = new FolderBrowserDialog())
			{
				folderDialog.SelectedPath = Application.StartupPath;
				if(folderDialog.ShowDialog(this) == DialogResult.OK)
				{
                    
					var path = new DirectoryInfo(folderDialog.SelectedPath);
                    OpenFolderPhotoTxtBx.Text = path.ToString();
                    var allFiles = path.GetFiles("*.*");

                    var images = allFiles.Where(file => Regex.IsMatch(file.Name, @".jpg|.png|.jpeg|.bmp$"))
                                         .Select(x => Image.FromFile(x.FullName).WithTag(x.Name));

                    _incrementValue = _progressBar.Maximum / images.Count();
                    _progressBar.Value = 0;
					var progress = new Progress<ImageRecognitionResult>(TestImagesProcess);

					Detector.ProcessImages(images, progress);
				} 
			}
		}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoRecognitionResults != null)
            {
                Logger.Save($"{DateTime.Now:dd/MM/yy HH-mm-ss}");
            }

            Detector.VideoClosed -= DetectorOnVideoClosed;

        }

        private void TestImagesProcess(ImageRecognitionResult result)
        {
            result.SaveToJson(Constants.ResultFolder, result.ImageName);

            _progressBar.Increment(_incrementValue);

        }

        private void OnImageDetected(VideoRecognitionResult result)
        {

            _incrementValue = (int)(_progressBar.Maximum / result.TotalFrames);
            pic.Image = result.ImageBytes.ToImage();
            _videoRecognitionResults.Items.Add(result);
            _progressBar.Increment(_incrementValue);
            if (_videoRecognitionResults.Items.Count > Constants.FrameLimit)
            {
                var validator = new FramesValidator(_videoRecognitionResults.Items);
                if (validator.IsValid)
                {
                    pic.Image = result.AppendBorder();
                    if (result.IndexFrame - _videoRecognitionResults.LastFrame > Constants.FrameDifference)
                    {
                        _videoRecognitionResults.Counter++;
                        CouplingCounterLabel.Text = _videoRecognitionResults.Counter.ToString();
                        foreach (var item in result.Items)
                        {
                            LogMsg(item, result);
                        }
                    }
                    _videoRecognitionResults.LastFrame = result.IndexFrame;

                }
                _videoRecognitionResults.Items.RemoveAt(0);
            }
        }

        private void LogMsg(YoloItem item, VideoRecognitionResult result)
        {
            var msg = new StringBuilder();
            msg.AppendLine("Номер кадра: " + result.IndexFrame);
            msg.AppendLine("Координата центра X: " + item.X);
            msg.AppendLine("Координата центра Y: " + item.Y);
            msg.AppendLine("Ширина: " + item.Width);
            msg.AppendLine("Высота: " + item.Height);
            Logger.WriteLine(msg.ToString());
            LogTxtBx.AppendText(Logger.Messages.Last() + "\r\n");
        }
    }
}
