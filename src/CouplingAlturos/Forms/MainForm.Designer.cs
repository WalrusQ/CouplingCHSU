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
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confidenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoloItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.BtnStopVideo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.VideoPg = new System.Windows.Forms.TabPage();
            this.CouplingCounterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenVideoTxtBx = new System.Windows.Forms.RichTextBox();
            this.LogTxtBx = new System.Windows.Forms.RichTextBox();
            this._playBtn = new System.Windows.Forms.Button();
            this.PhotoPg = new System.Windows.Forms.TabPage();
            this.OpenFolderPhotoTxtBx = new System.Windows.Forms.RichTextBox();
            this.BtnOpenFolder = new System.Windows.Forms.Button();
            this.OpenPhotoTxtBx = new System.Windows.Forms.RichTextBox();
            this.picBx = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabelYoloInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this._progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoloItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.VideoPg.SuspendLayout();
            this.PhotoPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AutoGenerateColumns = false;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.confidenceDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn});
            this.dataGridViewResult.DataSource = this.yoloItemBindingSource;
            this.dataGridViewResult.Location = new System.Drawing.Point(6, 460);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.Size = new System.Drawing.Size(643, 44);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confidenceDataGridViewTextBoxColumn
            // 
            this.confidenceDataGridViewTextBoxColumn.DataPropertyName = "Confidence";
            this.confidenceDataGridViewTextBoxColumn.HeaderText = "Confidence";
            this.confidenceDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.confidenceDataGridViewTextBoxColumn.Name = "confidenceDataGridViewTextBoxColumn";
            this.confidenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.confidenceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yoloItemBindingSource
            // 
            this.yoloItemBindingSource.DataSource = typeof(Alturos.Yolo.Model.YoloItem);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(6, 35);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(643, 315);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(6, 6);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Открыть";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.FlatAppearance.BorderSize = 0;
            this.btnOpenVideo.Location = new System.Drawing.Point(6, 7);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(75, 23);
            this.btnOpenVideo.TabIndex = 2;
            this.btnOpenVideo.Text = "Открыть";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.BtnOpenVideo_Click);
            // 
            // BtnStopVideo
            // 
            this.BtnStopVideo.FlatAppearance.BorderSize = 0;
            this.BtnStopVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStopVideo.Image = ((System.Drawing.Image)(resources.GetObject("BtnStopVideo.Image")));
            this.BtnStopVideo.Location = new System.Drawing.Point(326, 356);
            this.BtnStopVideo.Name = "BtnStopVideo";
            this.BtnStopVideo.Size = new System.Drawing.Size(37, 37);
            this.BtnStopVideo.TabIndex = 5;
            this.BtnStopVideo.UseVisualStyleBackColor = true;
            this.BtnStopVideo.Click += new System.EventHandler(this.DetectorOnVideoClosed);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.VideoPg);
            this.tabControl1.Controls.Add(this.PhotoPg);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 564);
            this.tabControl1.TabIndex = 6;
            // 
            // VideoPg
            // 
            this.VideoPg.Controls.Add(this.CouplingCounterLabel);
            this.VideoPg.Controls.Add(this.label1);
            this.VideoPg.Controls.Add(this.OpenVideoTxtBx);
            this.VideoPg.Controls.Add(this.LogTxtBx);
            this.VideoPg.Controls.Add(this.pic);
            this.VideoPg.Controls.Add(this._playBtn);
            this.VideoPg.Controls.Add(this.BtnStopVideo);
            this.VideoPg.Controls.Add(this.btnOpenVideo);
            this.VideoPg.Location = new System.Drawing.Point(4, 22);
            this.VideoPg.Name = "VideoPg";
            this.VideoPg.Padding = new System.Windows.Forms.Padding(3);
            this.VideoPg.Size = new System.Drawing.Size(655, 538);
            this.VideoPg.TabIndex = 0;
            this.VideoPg.Text = "Видео";
            this.VideoPg.UseVisualStyleBackColor = true;
            // 
            // CouplingCounterLabel
            // 
            this.CouplingCounterLabel.AutoSize = true;
            this.CouplingCounterLabel.Location = new System.Drawing.Point(615, 368);
            this.CouplingCounterLabel.Name = "CouplingCounterLabel";
            this.CouplingCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.CouplingCounterLabel.TabIndex = 9;
            this.CouplingCounterLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Обнаружено сцепок:";
            // 
            // OpenVideoTxtBx
            // 
            this.OpenVideoTxtBx.Location = new System.Drawing.Point(87, 7);
            this.OpenVideoTxtBx.Name = "OpenVideoTxtBx";
            this.OpenVideoTxtBx.Size = new System.Drawing.Size(562, 22);
            this.OpenVideoTxtBx.TabIndex = 7;
            this.OpenVideoTxtBx.Text = "";
            // 
            // LogTxtBx
            // 
            this.LogTxtBx.Location = new System.Drawing.Point(6, 399);
            this.LogTxtBx.Name = "LogTxtBx";
            this.LogTxtBx.Size = new System.Drawing.Size(643, 129);
            this.LogTxtBx.TabIndex = 6;
            this.LogTxtBx.Text = "";
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
            // PhotoPg
            // 
            this.PhotoPg.Controls.Add(this.OpenFolderPhotoTxtBx);
            this.PhotoPg.Controls.Add(this.BtnOpenFolder);
            this.PhotoPg.Controls.Add(this.OpenPhotoTxtBx);
            this.PhotoPg.Controls.Add(this.picBx);
            this.PhotoPg.Controls.Add(this.dataGridViewResult);
            this.PhotoPg.Controls.Add(this.btnOpenFile);
            this.PhotoPg.Location = new System.Drawing.Point(4, 22);
            this.PhotoPg.Name = "PhotoPg";
            this.PhotoPg.Padding = new System.Windows.Forms.Padding(3);
            this.PhotoPg.Size = new System.Drawing.Size(655, 538);
            this.PhotoPg.TabIndex = 1;
            this.PhotoPg.Text = "Фото";
            this.PhotoPg.UseVisualStyleBackColor = true;
            // 
            // OpenFolderPhotoTxtBx
            // 
            this.OpenFolderPhotoTxtBx.Location = new System.Drawing.Point(125, 510);
            this.OpenFolderPhotoTxtBx.Name = "OpenFolderPhotoTxtBx";
            this.OpenFolderPhotoTxtBx.Size = new System.Drawing.Size(524, 22);
            this.OpenFolderPhotoTxtBx.TabIndex = 10;
            this.OpenFolderPhotoTxtBx.Text = "";
            // 
            // BtnOpenFolder
            // 
            this.BtnOpenFolder.Location = new System.Drawing.Point(6, 509);
            this.BtnOpenFolder.Name = "BtnOpenFolder";
            this.BtnOpenFolder.Size = new System.Drawing.Size(113, 23);
            this.BtnOpenFolder.TabIndex = 9;
            this.BtnOpenFolder.Text = "Открыть папку";
            this.BtnOpenFolder.UseVisualStyleBackColor = true;
            this.BtnOpenFolder.Click += new System.EventHandler(this.BtnOpenFolder_Click);
            // 
            // OpenPhotoTxtBx
            // 
            this.OpenPhotoTxtBx.Location = new System.Drawing.Point(87, 6);
            this.OpenPhotoTxtBx.Name = "OpenPhotoTxtBx";
            this.OpenPhotoTxtBx.Size = new System.Drawing.Size(562, 22);
            this.OpenPhotoTxtBx.TabIndex = 8;
            this.OpenPhotoTxtBx.Text = "";
            // 
            // picBx
            // 
            this.picBx.BackColor = System.Drawing.Color.White;
            this.picBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBx.Location = new System.Drawing.Point(6, 35);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(643, 419);
            this.picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx.TabIndex = 3;
            this.picBx.TabStop = false;
            // 
            // toolStripStatusLabelYoloInfo
            // 
            this.toolStripStatusLabelYoloInfo.Name = "toolStripStatusLabelYoloInfo";
            this.toolStripStatusLabelYoloInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // _progressBar
            // 
            this._progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._progressBar.Maximum = 20000;
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelYoloInfo,
            this._progressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 560);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(661, 22);
            this.StatusStrip.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coupling CHSU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoloItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.VideoPg.ResumeLayout(false);
            this.VideoPg.PerformLayout();
            this.PhotoPg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.BindingSource yoloItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confidenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOpenVideo;
		private System.Windows.Forms.Button BtnStopVideo;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage VideoPg;
		private System.Windows.Forms.TabPage PhotoPg;
        private System.Windows.Forms.PictureBox picBx;
        private System.Windows.Forms.RichTextBox OpenVideoTxtBx;
        private System.Windows.Forms.RichTextBox LogTxtBx;
        private System.Windows.Forms.Button _playBtn;
        private System.Windows.Forms.Label CouplingCounterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpenFolder;
        private System.Windows.Forms.RichTextBox OpenFolderPhotoTxtBx;
        private System.Windows.Forms.RichTextBox OpenPhotoTxtBx;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelYoloInfo;
		private System.Windows.Forms.ToolStripProgressBar _progressBar;
		private System.Windows.Forms.StatusStrip StatusStrip;
	}
}

