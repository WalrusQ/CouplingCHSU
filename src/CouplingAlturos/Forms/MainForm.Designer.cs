namespace CouplingAlturos
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._dataGridViewResult = new System.Windows.Forms.DataGridView();
            this._typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._confidenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._yoloItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pic = new System.Windows.Forms.PictureBox();
            this._btnOpenFile = new System.Windows.Forms.Button();
            this._btnOpenVideo = new System.Windows.Forms.Button();
            this._btnStopVideo = new System.Windows.Forms.Button();
            this._tabControl1 = new System.Windows.Forms.TabControl();
            this._videoPg = new System.Windows.Forms.TabPage();
            this._couplingCounterLabel = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            this._openVideoTxtBx = new System.Windows.Forms.RichTextBox();
            this._logTxtBx = new System.Windows.Forms.RichTextBox();
            this._playBtn = new System.Windows.Forms.Button();
            this._photoPg = new System.Windows.Forms.TabPage();
            this._openFolderPhotoTxtBx = new System.Windows.Forms.RichTextBox();
            this._btnOpenFolder = new System.Windows.Forms.Button();
            this._openPhotoTxtBx = new System.Windows.Forms.RichTextBox();
            this._picBx = new System.Windows.Forms.PictureBox();
            this._toolStripStatusLabelYoloInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this._progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._yoloItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pic)).BeginInit();
            this._tabControl1.SuspendLayout();
            this._videoPg.SuspendLayout();
            this._photoPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picBx)).BeginInit();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataGridViewResult
            // 
            this._dataGridViewResult.AllowUserToAddRows = false;
            this._dataGridViewResult.AllowUserToDeleteRows = false;
            this._dataGridViewResult.AutoGenerateColumns = false;
            this._dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._typeDataGridViewTextBoxColumn,
            this._confidenceDataGridViewTextBoxColumn,
            this._xDataGridViewTextBoxColumn,
            this._yDataGridViewTextBoxColumn,
            this._widthDataGridViewTextBoxColumn,
            this._heightDataGridViewTextBoxColumn});
            this._dataGridViewResult.DataSource = this._yoloItemBindingSource;
            this._dataGridViewResult.Location = new System.Drawing.Point(6, 460);
            this._dataGridViewResult.Name = "_dataGridViewResult";
            this._dataGridViewResult.ReadOnly = true;
            this._dataGridViewResult.Size = new System.Drawing.Size(643, 44);
            this._dataGridViewResult.TabIndex = 0;
            // 
            // _typeDataGridViewTextBoxColumn
            // 
            this._typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this._typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this._typeDataGridViewTextBoxColumn.Name = "_typeDataGridViewTextBoxColumn";
            this._typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _confidenceDataGridViewTextBoxColumn
            // 
            this._confidenceDataGridViewTextBoxColumn.DataPropertyName = "Confidence";
            this._confidenceDataGridViewTextBoxColumn.HeaderText = "Confidence";
            this._confidenceDataGridViewTextBoxColumn.MaxInputLength = 4;
            this._confidenceDataGridViewTextBoxColumn.Name = "_confidenceDataGridViewTextBoxColumn";
            this._confidenceDataGridViewTextBoxColumn.ReadOnly = true;
            this._confidenceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _xDataGridViewTextBoxColumn
            // 
            this._xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this._xDataGridViewTextBoxColumn.HeaderText = "X";
            this._xDataGridViewTextBoxColumn.Name = "_xDataGridViewTextBoxColumn";
            this._xDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _yDataGridViewTextBoxColumn
            // 
            this._yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this._yDataGridViewTextBoxColumn.HeaderText = "Y";
            this._yDataGridViewTextBoxColumn.Name = "_yDataGridViewTextBoxColumn";
            this._yDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _widthDataGridViewTextBoxColumn
            // 
            this._widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this._widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this._widthDataGridViewTextBoxColumn.Name = "_widthDataGridViewTextBoxColumn";
            this._widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _heightDataGridViewTextBoxColumn
            // 
            this._heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this._heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this._heightDataGridViewTextBoxColumn.Name = "_heightDataGridViewTextBoxColumn";
            this._heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _yoloItemBindingSource
            // 
            this._yoloItemBindingSource.DataSource = typeof(Alturos.Yolo.Model.YoloItem);
            // 
            // _pic
            // 
            this._pic.BackColor = System.Drawing.Color.White;
            this._pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pic.Location = new System.Drawing.Point(6, 35);
            this._pic.Name = "_pic";
            this._pic.Size = new System.Drawing.Size(643, 315);
            this._pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pic.TabIndex = 1;
            this._pic.TabStop = false;
            // 
            // _btnOpenFile
            // 
            this._btnOpenFile.Location = new System.Drawing.Point(6, 6);
            this._btnOpenFile.Name = "_btnOpenFile";
            this._btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this._btnOpenFile.TabIndex = 2;
            this._btnOpenFile.Text = "Открыть";
            this._btnOpenFile.UseVisualStyleBackColor = true;
            this._btnOpenFile.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // _btnOpenVideo
            // 
            this._btnOpenVideo.FlatAppearance.BorderSize = 0;
            this._btnOpenVideo.Location = new System.Drawing.Point(6, 7);
            this._btnOpenVideo.Name = "_btnOpenVideo";
            this._btnOpenVideo.Size = new System.Drawing.Size(75, 23);
            this._btnOpenVideo.TabIndex = 2;
            this._btnOpenVideo.Text = "Открыть";
            this._btnOpenVideo.UseVisualStyleBackColor = true;
            this._btnOpenVideo.Click += new System.EventHandler(this.BtnOpenVideo_Click);
            // 
            // _btnStopVideo
            // 
            this._btnStopVideo.FlatAppearance.BorderSize = 0;
            this._btnStopVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnStopVideo.Image = ((System.Drawing.Image)(resources.GetObject("_btnStopVideo.Image")));
            this._btnStopVideo.Location = new System.Drawing.Point(326, 356);
            this._btnStopVideo.Name = "_btnStopVideo";
            this._btnStopVideo.Size = new System.Drawing.Size(37, 37);
            this._btnStopVideo.TabIndex = 5;
            this._btnStopVideo.UseVisualStyleBackColor = true;
            this._btnStopVideo.Click += new System.EventHandler(this.DetectorOnVideoClosed);
            // 
            // _tabControl1
            // 
            this._tabControl1.Controls.Add(this._videoPg);
            this._tabControl1.Controls.Add(this._photoPg);
            this._tabControl1.Location = new System.Drawing.Point(0, 0);
            this._tabControl1.Name = "_tabControl1";
            this._tabControl1.SelectedIndex = 0;
            this._tabControl1.Size = new System.Drawing.Size(663, 564);
            this._tabControl1.TabIndex = 6;
            // 
            // _videoPg
            // 
            this._videoPg.Controls.Add(this._couplingCounterLabel);
            this._videoPg.Controls.Add(this._label1);
            this._videoPg.Controls.Add(this._openVideoTxtBx);
            this._videoPg.Controls.Add(this._logTxtBx);
            this._videoPg.Controls.Add(this._pic);
            this._videoPg.Controls.Add(this._playBtn);
            this._videoPg.Controls.Add(this._btnStopVideo);
            this._videoPg.Controls.Add(this._btnOpenVideo);
            this._videoPg.Location = new System.Drawing.Point(4, 22);
            this._videoPg.Name = "_videoPg";
            this._videoPg.Padding = new System.Windows.Forms.Padding(3);
            this._videoPg.Size = new System.Drawing.Size(655, 538);
            this._videoPg.TabIndex = 0;
            this._videoPg.Text = "Видео";
            this._videoPg.UseVisualStyleBackColor = true;
            // 
            // _couplingCounterLabel
            // 
            this._couplingCounterLabel.AutoSize = true;
            this._couplingCounterLabel.Location = new System.Drawing.Point(615, 368);
            this._couplingCounterLabel.Name = "_couplingCounterLabel";
            this._couplingCounterLabel.Size = new System.Drawing.Size(13, 13);
            this._couplingCounterLabel.TabIndex = 9;
            this._couplingCounterLabel.Text = "0";
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(497, 368);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(112, 13);
            this._label1.TabIndex = 8;
            this._label1.Text = "Обнаружено сцепок:";
            // 
            // _openVideoTxtBx
            // 
            this._openVideoTxtBx.Location = new System.Drawing.Point(87, 7);
            this._openVideoTxtBx.Name = "_openVideoTxtBx";
            this._openVideoTxtBx.Size = new System.Drawing.Size(562, 22);
            this._openVideoTxtBx.TabIndex = 7;
            this._openVideoTxtBx.Text = "";
            // 
            // _logTxtBx
            // 
            this._logTxtBx.Location = new System.Drawing.Point(6, 399);
            this._logTxtBx.Name = "_logTxtBx";
            this._logTxtBx.Size = new System.Drawing.Size(643, 129);
            this._logTxtBx.TabIndex = 6;
            this._logTxtBx.Text = "";
            // 
            // _playBtn
            // 
            this._playBtn.Enabled = false;
            this._playBtn.FlatAppearance.BorderSize = 0;
            this._playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._playBtn.Image = ((System.Drawing.Image)(resources.GetObject("_playBtn.Image")));
            this._playBtn.Location = new System.Drawing.Point(283, 356);
            this._playBtn.Name = "_playBtn";
            this._playBtn.Size = new System.Drawing.Size(37, 37);
            this._playBtn.TabIndex = 5;
            this._playBtn.UseVisualStyleBackColor = true;
            this._playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // _photoPg
            // 
            this._photoPg.Controls.Add(this._openFolderPhotoTxtBx);
            this._photoPg.Controls.Add(this._btnOpenFolder);
            this._photoPg.Controls.Add(this._openPhotoTxtBx);
            this._photoPg.Controls.Add(this._picBx);
            this._photoPg.Controls.Add(this._dataGridViewResult);
            this._photoPg.Controls.Add(this._btnOpenFile);
            this._photoPg.Location = new System.Drawing.Point(4, 22);
            this._photoPg.Name = "_photoPg";
            this._photoPg.Padding = new System.Windows.Forms.Padding(3);
            this._photoPg.Size = new System.Drawing.Size(655, 538);
            this._photoPg.TabIndex = 1;
            this._photoPg.Text = "Фото";
            this._photoPg.UseVisualStyleBackColor = true;
            // 
            // _openFolderPhotoTxtBx
            // 
            this._openFolderPhotoTxtBx.Location = new System.Drawing.Point(125, 510);
            this._openFolderPhotoTxtBx.Name = "_openFolderPhotoTxtBx";
            this._openFolderPhotoTxtBx.Size = new System.Drawing.Size(524, 22);
            this._openFolderPhotoTxtBx.TabIndex = 10;
            this._openFolderPhotoTxtBx.Text = "";
            // 
            // _btnOpenFolder
            // 
            this._btnOpenFolder.Location = new System.Drawing.Point(6, 509);
            this._btnOpenFolder.Name = "_btnOpenFolder";
            this._btnOpenFolder.Size = new System.Drawing.Size(113, 23);
            this._btnOpenFolder.TabIndex = 9;
            this._btnOpenFolder.Text = "Открыть папку";
            this._btnOpenFolder.UseVisualStyleBackColor = true;
            this._btnOpenFolder.Click += new System.EventHandler(this.BtnOpenFolder_Click);
            // 
            // _openPhotoTxtBx
            // 
            this._openPhotoTxtBx.Location = new System.Drawing.Point(87, 6);
            this._openPhotoTxtBx.Name = "_openPhotoTxtBx";
            this._openPhotoTxtBx.Size = new System.Drawing.Size(562, 22);
            this._openPhotoTxtBx.TabIndex = 8;
            this._openPhotoTxtBx.Text = "";
            // 
            // _picBx
            // 
            this._picBx.BackColor = System.Drawing.Color.White;
            this._picBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picBx.Location = new System.Drawing.Point(6, 35);
            this._picBx.Name = "_picBx";
            this._picBx.Size = new System.Drawing.Size(643, 419);
            this._picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picBx.TabIndex = 3;
            this._picBx.TabStop = false;
            // 
            // _toolStripStatusLabelYoloInfo
            // 
            this._toolStripStatusLabelYoloInfo.Name = "_toolStripStatusLabelYoloInfo";
            this._toolStripStatusLabelYoloInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // _progressBar
            // 
            this._progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._progressBar.Maximum = 20000;
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripStatusLabelYoloInfo,
            this._progressBar});
            this._statusStrip.Location = new System.Drawing.Point(0, 560);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(661, 22);
            this._statusStrip.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 582);
            this.Controls.Add(this._tabControl1);
            this.Controls.Add(this._statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coupling CHSU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._yoloItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pic)).EndInit();
            this._tabControl1.ResumeLayout(false);
            this._videoPg.ResumeLayout(false);
            this._videoPg.PerformLayout();
            this._photoPg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picBx)).EndInit();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridViewResult;
        private System.Windows.Forms.PictureBox _pic;
        private System.Windows.Forms.Button _btnOpenFile;
        private System.Windows.Forms.BindingSource _yoloItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _confidenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button _btnOpenVideo;
		private System.Windows.Forms.Button _btnStopVideo;
		private System.Windows.Forms.TabControl _tabControl1;
		private System.Windows.Forms.TabPage _videoPg;
		private System.Windows.Forms.TabPage _photoPg;
        private System.Windows.Forms.PictureBox _picBx;
        private System.Windows.Forms.RichTextBox _openVideoTxtBx;
        private System.Windows.Forms.RichTextBox _logTxtBx;
        private System.Windows.Forms.Button _playBtn;
        private System.Windows.Forms.Label _couplingCounterLabel;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.Button _btnOpenFolder;
        private System.Windows.Forms.RichTextBox _openFolderPhotoTxtBx;
        private System.Windows.Forms.RichTextBox _openPhotoTxtBx;
		private System.Windows.Forms.ToolStripStatusLabel _toolStripStatusLabelYoloInfo;
		private System.Windows.Forms.ToolStripProgressBar _progressBar;
		private System.Windows.Forms.StatusStrip _statusStrip;
	}
}

