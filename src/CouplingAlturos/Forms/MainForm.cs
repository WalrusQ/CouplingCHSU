using Alturos.Yolo.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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

		#region Data

		private string _videoFile;

        private int _incrementValue;
        
        private VideoRecognitionResults _videoRecognitionResults;

		#endregion

		#region Propirties

		public IDetector Detector { get; }

		public ILogger Logger { get; }

		#endregion

		#region ctor & dsp

		public MainForm(IDetector detector, ILogger logger)
        {
            Detector = detector;
            Logger = logger;
            InitializeComponent();
			Detector.VideoClosed += DetectorOnVideoClosed;
            _toolStripStatusLabelYoloInfo.Text = $@"Detection system: {Detector.YoloMetaInfo.DetectionSystem}";
        }

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            Detector.Stop();
            Detector.VideoClosed -= DetectorOnVideoClosed;
            
			//todo: что ниже удалить, если юзер закрыл не дожидаясь завершения то ему не нужен лог
            if (_videoRecognitionResults != null)
			{
                
				Logger.Save($"{DateTime.Now:dd/MM/yy HH-mm-ss}");
                Logger.Clear();
			}
		}

		#endregion

		#region Handlers

		private void DetectorOnVideoClosed(object sender, EventArgs e)
        {
            Detector.Stop();
            if (Logger.Messages.Any())
            {
                Logger.Save($@"{DateTime.Now:dd/MM/yy HH-mm-ss}");
                Logger.Clear();
            }
			
            _playBtn.SetPropertyThreadSafe(() => _playBtn.Enabled, true);

            _pic.Invoke(new Action(() => { _pic.Image = null; }));
            _statusStrip.Invoke(new Action(() => { _progressBar.Value = _progressBar.Maximum; }));
           
		}

		private void OpenBtn_Click(object sender, EventArgs e)
		{ 
			using (var ofd = new OpenFileDialog()
			{
				Filter = @"Image files(*.png; *.jpg; *.jpeg *.bmp | *.png; *.jpg; *.jpeg *.bmp"
			})
			{
				if (ofd.ShowDialog(this) == DialogResult.OK)
				{
					var image = ofd.FileName;
					if(image == null) return;

					var result = Detector.ProcessImage(Image.FromFile(image));

					_dataGridViewResult.DataSource = result.Items;
					_picBx.Image = result.AppendBorder();
					_openPhotoTxtBx.Text = ofd.FileName;

					result.SaveToJson(@"Results", ofd.SafeFileName);
				}
			}
		}

        private void BtnOpenVideo_Click(object sender, EventArgs e)
        {

            using (var ofd = new OpenFileDialog()
            {
	            Filter = @"Video File(*.avi) | *.avi; *.mp4"
            })
            {
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    _pic.Image = null;
                    _openVideoTxtBx.Text = ofd.FileName;
                    _videoFile = ofd.FileName;
                    _pic.BackColor = Color.Black;
                    _playBtn.Enabled = true;
                    
                }
            }
        }

		private void PlayBtn_Click(object sender, EventArgs e)
		{
            _couplingCounterLabel.Text = "0";
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
                    _openFolderPhotoTxtBx.Text = path.ToString();
                    var allFiles = path.GetFiles("*.*");

                    var images = allFiles.Where(file => Regex.IsMatch(file.Name, @".jpg|.png|.jpeg|.bmp$"))
                                         .Select(x => Image.FromFile(x.FullName).WithTag(x.Name))
                                         .ToList();

                    _incrementValue = _progressBar.Maximum / images.Count;
                    _progressBar.Value = 0;
					var progress = new Progress<ImageRecognitionResult>(TestImagesProcess);

					Detector.ProcessImages(images, progress);
				} 
			}
		}

		#endregion

		#region Methods

		private void TestImagesProcess(ImageRecognitionResult result)
        {
            result.SaveToJson(Constants.ResultFolder, result.ImageName);
            _progressBar.Increment(_incrementValue);
        }

        private void OnImageDetected(VideoRecognitionResult result)
        {
            if (IsDisposed) return;
            _incrementValue = (int)(_progressBar.Maximum / result.TotalFrames);
            _pic.Image = result.ImageBytes.ToImage();
            _videoRecognitionResults.Items.Add(result);
            _progressBar.Increment(_incrementValue);
            if (_videoRecognitionResults.Items.Count > Constants.FrameLimit)
            {
                var validator = new FramesValidator(_videoRecognitionResults.Items);
                if (validator.IsValid)
                {
                    _pic.Image = result.AppendBorder();
                    if (result.IndexFrame - _videoRecognitionResults.LastFrame > Constants.FrameDifference)
                    {
                        _videoRecognitionResults.Counter++;
                        _couplingCounterLabel.Text = _videoRecognitionResults.Counter.ToString();
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
            _logTxtBx.AppendText(Logger.Messages.Last() + "\r\n");
        }

        #endregion
	}
}
