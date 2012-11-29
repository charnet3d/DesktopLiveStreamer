namespace DesktopLiveStreamer
{
    partial class FrmStreams
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnChangeStreamer = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupLive = new System.Windows.Forms.GroupBox();
            this.progressQuality = new System.Windows.Forms.ProgressBar();
            this.progressLiveStreams = new System.Windows.Forms.ProgressBar();
            this.btnAddLiveStream = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbQualities = new System.Windows.Forms.ComboBox();
            this.groupFavorites = new System.Windows.Forms.GroupBox();
            this.progressFavorites = new System.Windows.Forms.ProgressBar();
            this.btnCheckOnline = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAddStream = new System.Windows.Forms.Button();
            this.radioList2 = new System.Windows.Forms.RadioButton();
            this.radioList1 = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnChangeVLC = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.imgCmbLiveStreams = new DesktopLiveStreamer.ImageDropDownList();
            this.imgCmbStreams = new DesktopLiveStreamer.ImageDropDownList();
            this.groupBox1.SuspendLayout();
            this.groupLive.SuspendLayout();
            this.groupFavorites.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeStreamer
            // 
            this.btnChangeStreamer.Location = new System.Drawing.Point(116, 200);
            this.btnChangeStreamer.Name = "btnChangeStreamer";
            this.btnChangeStreamer.Size = new System.Drawing.Size(91, 54);
            this.btnChangeStreamer.TabIndex = 0;
            this.btnChangeStreamer.Text = "Configure Live Streamer Executable";
            this.btnChangeStreamer.UseVisualStyleBackColor = true;
            this.btnChangeStreamer.Visible = false;
            this.btnChangeStreamer.Click += new System.EventHandler(this.btnChangeStreamer_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(406, 200);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 54);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(510, 200);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 54);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupLive);
            this.groupBox1.Controls.Add(this.groupFavorites);
            this.groupBox1.Controls.Add(this.radioList2);
            this.groupBox1.Controls.Add(this.radioList1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 174);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream lists";
            // 
            // groupLive
            // 
            this.groupLive.Controls.Add(this.progressQuality);
            this.groupLive.Controls.Add(this.progressLiveStreams);
            this.groupLive.Controls.Add(this.imgCmbLiveStreams);
            this.groupLive.Controls.Add(this.btnAddLiveStream);
            this.groupLive.Controls.Add(this.btnUpdate);
            this.groupLive.Controls.Add(this.cmbQualities);
            this.groupLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLive.Location = new System.Drawing.Point(35, 19);
            this.groupLive.Name = "groupLive";
            this.groupLive.Size = new System.Drawing.Size(555, 61);
            this.groupLive.TabIndex = 18;
            this.groupLive.TabStop = false;
            this.groupLive.Text = "Currently online on Twitch.tv and Own3D.tv";
            // 
            // progressQuality
            // 
            this.progressQuality.Location = new System.Drawing.Point(438, 42);
            this.progressQuality.Margin = new System.Windows.Forms.Padding(1);
            this.progressQuality.MarqueeAnimationSpeed = 20;
            this.progressQuality.Name = "progressQuality";
            this.progressQuality.Size = new System.Drawing.Size(81, 10);
            this.progressQuality.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressQuality.TabIndex = 25;
            this.progressQuality.Visible = false;
            // 
            // progressLiveStreams
            // 
            this.progressLiveStreams.Location = new System.Drawing.Point(6, 42);
            this.progressLiveStreams.MarqueeAnimationSpeed = 20;
            this.progressLiveStreams.Name = "progressLiveStreams";
            this.progressLiveStreams.Size = new System.Drawing.Size(396, 10);
            this.progressLiveStreams.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressLiveStreams.TabIndex = 24;
            this.progressLiveStreams.Visible = false;
            // 
            // btnAddLiveStream
            // 
            this.btnAddLiveStream.Image = global::DesktopLiveStreamer.Properties.Resources.favoriteImg;
            this.btnAddLiveStream.Location = new System.Drawing.Point(525, 20);
            this.btnAddLiveStream.Name = "btnAddLiveStream";
            this.btnAddLiveStream.Size = new System.Drawing.Size(24, 23);
            this.btnAddLiveStream.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnAddLiveStream, "Add to favorites");
            this.btnAddLiveStream.UseVisualStyleBackColor = true;
            this.btnAddLiveStream.Click += new System.EventHandler(this.btnAddLiveStream_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::DesktopLiveStreamer.Properties.Resources.refreshImg;
            this.btnUpdate.Location = new System.Drawing.Point(408, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(24, 23);
            this.btnUpdate.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnUpdate, "Update Stream list from the server");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbQualities
            // 
            this.cmbQualities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualities.FormattingEnabled = true;
            this.cmbQualities.Location = new System.Drawing.Point(438, 21);
            this.cmbQualities.Name = "cmbQualities";
            this.cmbQualities.Size = new System.Drawing.Size(81, 21);
            this.cmbQualities.TabIndex = 18;
            // 
            // groupFavorites
            // 
            this.groupFavorites.Controls.Add(this.progressFavorites);
            this.groupFavorites.Controls.Add(this.imgCmbStreams);
            this.groupFavorites.Controls.Add(this.btnCheckOnline);
            this.groupFavorites.Controls.Add(this.btnClone);
            this.groupFavorites.Controls.Add(this.btnDelete);
            this.groupFavorites.Controls.Add(this.btnModify);
            this.groupFavorites.Controls.Add(this.btnAddStream);
            this.groupFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFavorites.Location = new System.Drawing.Point(35, 88);
            this.groupFavorites.Name = "groupFavorites";
            this.groupFavorites.Size = new System.Drawing.Size(555, 80);
            this.groupFavorites.TabIndex = 17;
            this.groupFavorites.TabStop = false;
            this.groupFavorites.Text = "Favorites";
            // 
            // progressFavorites
            // 
            this.progressFavorites.Location = new System.Drawing.Point(6, 37);
            this.progressFavorites.Name = "progressFavorites";
            this.progressFavorites.Size = new System.Drawing.Size(513, 10);
            this.progressFavorites.Step = 1;
            this.progressFavorites.TabIndex = 23;
            this.progressFavorites.Visible = false;
            // 
            // btnCheckOnline
            // 
            this.btnCheckOnline.Image = global::DesktopLiveStreamer.Properties.Resources.refreshImg;
            this.btnCheckOnline.Location = new System.Drawing.Point(525, 16);
            this.btnCheckOnline.Name = "btnCheckOnline";
            this.btnCheckOnline.Size = new System.Drawing.Size(24, 23);
            this.btnCheckOnline.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnCheckOnline, "Check online status for favourite streams");
            this.btnCheckOnline.UseVisualStyleBackColor = true;
            this.btnCheckOnline.Click += new System.EventHandler(this.btnCheckOnline_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(103, 51);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(91, 23);
            this.btnClone.TabIndex = 16;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(200, 51);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 23);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAddStream
            // 
            this.btnAddStream.Location = new System.Drawing.Point(6, 51);
            this.btnAddStream.Name = "btnAddStream";
            this.btnAddStream.Size = new System.Drawing.Size(91, 23);
            this.btnAddStream.TabIndex = 13;
            this.btnAddStream.Text = "Add";
            this.btnAddStream.UseVisualStyleBackColor = true;
            this.btnAddStream.Click += new System.EventHandler(this.btnAddStream_Click);
            // 
            // radioList2
            // 
            this.radioList2.AutoSize = true;
            this.radioList2.Location = new System.Drawing.Point(15, 35);
            this.radioList2.Name = "radioList2";
            this.radioList2.Size = new System.Drawing.Size(14, 13);
            this.radioList2.TabIndex = 14;
            this.radioList2.TabStop = true;
            this.radioList2.UseVisualStyleBackColor = true;
            // 
            // radioList1
            // 
            this.radioList1.AutoSize = true;
            this.radioList1.Location = new System.Drawing.Point(15, 119);
            this.radioList1.Name = "radioList1";
            this.radioList1.Size = new System.Drawing.Size(14, 13);
            this.radioList1.TabIndex = 13;
            this.radioList1.TabStop = true;
            this.radioList1.UseVisualStyleBackColor = true;
            this.radioList1.CheckedChanged += new System.EventHandler(this.radioList1_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            this.progressBar.Step = 20;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;
            // 
            // btnChangeVLC
            // 
            this.btnChangeVLC.Location = new System.Drawing.Point(12, 200);
            this.btnChangeVLC.Name = "btnChangeVLC";
            this.btnChangeVLC.Size = new System.Drawing.Size(98, 54);
            this.btnChangeVLC.TabIndex = 13;
            this.btnChangeVLC.Text = "Configure VLC Executable";
            this.btnChangeVLC.UseVisualStyleBackColor = true;
            this.btnChangeVLC.Click += new System.EventHandler(this.btnChangeVLC_Click);
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Location = new System.Drawing.Point(302, 200);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(98, 54);
            this.btnOpenBrowser.TabIndex = 14;
            this.btnOpenBrowser.Text = "Open in Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // imgCmbLiveStreams
            // 
            this.imgCmbLiveStreams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imgCmbLiveStreams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgCmbLiveStreams.FormattingEnabled = true;
            this.imgCmbLiveStreams.Location = new System.Drawing.Point(6, 21);
            this.imgCmbLiveStreams.Name = "imgCmbLiveStreams";
            this.imgCmbLiveStreams.Size = new System.Drawing.Size(396, 21);
            this.imgCmbLiveStreams.TabIndex = 21;
            this.imgCmbLiveStreams.SelectedIndexChanged += new System.EventHandler(this.imgCmbLiveStreams_SelectedIndexChanged_1);
            // 
            // imgCmbStreams
            // 
            this.imgCmbStreams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imgCmbStreams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgCmbStreams.FormattingEnabled = true;
            this.imgCmbStreams.Location = new System.Drawing.Point(6, 16);
            this.imgCmbStreams.Name = "imgCmbStreams";
            this.imgCmbStreams.Size = new System.Drawing.Size(513, 21);
            this.imgCmbStreams.TabIndex = 22;
            this.imgCmbStreams.SelectedIndexChanged += new System.EventHandler(this.imgCmbStreams_SelectedIndexChanged);
            // 
            // FrmStreams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 287);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.btnChangeVLC);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnChangeStreamer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStreams";
            this.Text = "Desktop Live Streamer for LoL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStreams_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupLive.ResumeLayout(false);
            this.groupFavorites.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeStreamer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioList2;
        private System.Windows.Forms.RadioButton radioList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupLive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbQualities;
        private System.Windows.Forms.GroupBox groupFavorites;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAddStream;
        private System.Windows.Forms.Button btnChangeVLC;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Button btnAddLiveStream;
        private ImageDropDownList imgCmbLiveStreams;
        private System.Windows.Forms.Button btnCheckOnline;
        private ImageDropDownList imgCmbStreams;
        private System.Windows.Forms.ProgressBar progressQuality;
        private System.Windows.Forms.ProgressBar progressLiveStreams;
        private System.Windows.Forms.ProgressBar progressFavorites;
        private System.Windows.Forms.Button btnOpenBrowser;
    }
}

