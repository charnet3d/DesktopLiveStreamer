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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStreams));
            this.btnChangeStreamer = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupLive = new System.Windows.Forms.GroupBox();
            this.progressQuality = new System.Windows.Forms.ProgressBar();
            this.progressLiveStreams = new System.Windows.Forms.ProgressBar();
            this.imgCmbLiveStreams = new DesktopLiveStreamer.ImageDropDownList();
            this.btnAddLiveStream = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbQualities = new System.Windows.Forms.ComboBox();
            this.groupFavorites = new System.Windows.Forms.GroupBox();
            this.progressFavorites = new System.Windows.Forms.ProgressBar();
            this.imgCmbStreams = new DesktopLiveStreamer.ImageDropDownList();
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
            this.btnUpdateGames = new System.Windows.Forms.Button();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.groupGames = new System.Windows.Forms.GroupBox();
            this.btnChangeGame = new System.Windows.Forms.Button();
            this.btnUpdateGameMenu = new System.Windows.Forms.Button();
            this.imgCmbGames = new DesktopLiveStreamer.ImageDropDownList();
            this.progressGames = new System.Windows.Forms.ProgressBar();
            this.btnValidateGame = new System.Windows.Forms.Button();
            this.contextMenuUpdateGames = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuUpdateAllGames = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupLive.SuspendLayout();
            this.groupFavorites.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupGames.SuspendLayout();
            this.contextMenuUpdateGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeStreamer
            // 
            this.btnChangeStreamer.Location = new System.Drawing.Point(12, 258);
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
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(468, 258);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(107, 54);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(581, 258);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 54);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 176);
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
            this.groupLive.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLive.Location = new System.Drawing.Point(35, 19);
            this.groupLive.Name = "groupLive";
            this.groupLive.Size = new System.Drawing.Size(635, 61);
            this.groupLive.TabIndex = 18;
            this.groupLive.TabStop = false;
            this.groupLive.Text = "Currently online";
            // 
            // progressQuality
            // 
            this.progressQuality.Location = new System.Drawing.Point(501, 41);
            this.progressQuality.Margin = new System.Windows.Forms.Padding(1);
            this.progressQuality.MarqueeAnimationSpeed = 20;
            this.progressQuality.Name = "progressQuality";
            this.progressQuality.Size = new System.Drawing.Size(98, 11);
            this.progressQuality.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressQuality.TabIndex = 25;
            this.progressQuality.Visible = false;
            // 
            // progressLiveStreams
            // 
            this.progressLiveStreams.Location = new System.Drawing.Point(6, 42);
            this.progressLiveStreams.MarqueeAnimationSpeed = 20;
            this.progressLiveStreams.Name = "progressLiveStreams";
            this.progressLiveStreams.Size = new System.Drawing.Size(459, 10);
            this.progressLiveStreams.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressLiveStreams.TabIndex = 24;
            this.progressLiveStreams.Visible = false;
            // 
            // imgCmbLiveStreams
            // 
            this.imgCmbLiveStreams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imgCmbLiveStreams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgCmbLiveStreams.FormattingEnabled = true;
            this.imgCmbLiveStreams.Location = new System.Drawing.Point(6, 20);
            this.imgCmbLiveStreams.Name = "imgCmbLiveStreams";
            this.imgCmbLiveStreams.Size = new System.Drawing.Size(459, 23);
            this.imgCmbLiveStreams.TabIndex = 21;
            this.imgCmbLiveStreams.SelectedIndexChanged += new System.EventHandler(this.imgCmbLiveStreams_SelectedIndexChanged_1);
            // 
            // btnAddLiveStream
            // 
            this.btnAddLiveStream.Image = global::DesktopLiveStreamer.Properties.Resources.favoriteImg;
            this.btnAddLiveStream.Location = new System.Drawing.Point(605, 20);
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
            this.btnUpdate.Location = new System.Drawing.Point(471, 19);
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
            this.cmbQualities.Location = new System.Drawing.Point(501, 21);
            this.cmbQualities.Name = "cmbQualities";
            this.cmbQualities.Size = new System.Drawing.Size(98, 21);
            this.cmbQualities.TabIndex = 18;
            this.cmbQualities.SelectedIndexChanged += new System.EventHandler(this.cmbQualities_SelectedIndexChanged);
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
            this.groupFavorites.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFavorites.Location = new System.Drawing.Point(35, 88);
            this.groupFavorites.Name = "groupFavorites";
            this.groupFavorites.Size = new System.Drawing.Size(635, 80);
            this.groupFavorites.TabIndex = 17;
            this.groupFavorites.TabStop = false;
            this.groupFavorites.Text = "Favorites";
            // 
            // progressFavorites
            // 
            this.progressFavorites.Location = new System.Drawing.Point(6, 37);
            this.progressFavorites.Name = "progressFavorites";
            this.progressFavorites.Size = new System.Drawing.Size(593, 10);
            this.progressFavorites.Step = 1;
            this.progressFavorites.TabIndex = 23;
            this.progressFavorites.Visible = false;
            // 
            // imgCmbStreams
            // 
            this.imgCmbStreams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imgCmbStreams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgCmbStreams.FormattingEnabled = true;
            this.imgCmbStreams.Location = new System.Drawing.Point(6, 16);
            this.imgCmbStreams.Name = "imgCmbStreams";
            this.imgCmbStreams.Size = new System.Drawing.Size(593, 23);
            this.imgCmbStreams.TabIndex = 22;
            this.imgCmbStreams.SelectedIndexChanged += new System.EventHandler(this.imgCmbStreams_SelectedIndexChanged);
            // 
            // btnCheckOnline
            // 
            this.btnCheckOnline.Image = global::DesktopLiveStreamer.Properties.Resources.refreshImg;
            this.btnCheckOnline.Location = new System.Drawing.Point(605, 16);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 17);
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
            this.btnChangeVLC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeVLC.Location = new System.Drawing.Point(109, 258);
            this.btnChangeVLC.Name = "btnChangeVLC";
            this.btnChangeVLC.Size = new System.Drawing.Size(98, 54);
            this.btnChangeVLC.TabIndex = 13;
            this.btnChangeVLC.Text = "Configure VLC Executable";
            this.btnChangeVLC.UseVisualStyleBackColor = true;
            this.btnChangeVLC.Click += new System.EventHandler(this.btnChangeVLC_Click);
            // 
            // btnUpdateGames
            // 
            this.btnUpdateGames.Image = global::DesktopLiveStreamer.Properties.Resources.refreshImg;
            this.btnUpdateGames.Location = new System.Drawing.Point(536, 19);
            this.btnUpdateGames.Name = "btnUpdateGames";
            this.btnUpdateGames.Size = new System.Drawing.Size(24, 23);
            this.btnUpdateGames.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnUpdateGames, "Update game list from the server");
            this.btnUpdateGames.UseVisualStyleBackColor = true;
            this.btnUpdateGames.Click += new System.EventHandler(this.btnUpdateGames_Click);
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBrowser.Location = new System.Drawing.Point(354, 258);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(108, 54);
            this.btnOpenBrowser.TabIndex = 14;
            this.btnOpenBrowser.Text = "Open in Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // groupGames
            // 
            this.groupGames.Controls.Add(this.btnChangeGame);
            this.groupGames.Controls.Add(this.btnUpdateGames);
            this.groupGames.Controls.Add(this.btnUpdateGameMenu);
            this.groupGames.Controls.Add(this.imgCmbGames);
            this.groupGames.Controls.Add(this.progressGames);
            this.groupGames.Controls.Add(this.btnValidateGame);
            this.groupGames.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGames.Location = new System.Drawing.Point(12, 12);
            this.groupGames.Name = "groupGames";
            this.groupGames.Size = new System.Drawing.Size(676, 58);
            this.groupGames.TabIndex = 21;
            this.groupGames.TabStop = false;
            this.groupGames.Text = "Live Game to Watch :";
            // 
            // btnChangeGame
            // 
            this.btnChangeGame.Location = new System.Drawing.Point(584, 19);
            this.btnChangeGame.Name = "btnChangeGame";
            this.btnChangeGame.Size = new System.Drawing.Size(86, 23);
            this.btnChangeGame.TabIndex = 27;
            this.btnChangeGame.Text = "Change";
            this.btnChangeGame.UseVisualStyleBackColor = true;
            this.btnChangeGame.Click += new System.EventHandler(this.btnChangeGame_Click);
            // 
            // btnUpdateGameMenu
            // 
            this.btnUpdateGameMenu.Image = global::DesktopLiveStreamer.Properties.Resources.arrow;
            this.btnUpdateGameMenu.Location = new System.Drawing.Point(559, 19);
            this.btnUpdateGameMenu.Name = "btnUpdateGameMenu";
            this.btnUpdateGameMenu.Size = new System.Drawing.Size(19, 23);
            this.btnUpdateGameMenu.TabIndex = 35;
            this.btnUpdateGameMenu.UseVisualStyleBackColor = true;
            this.btnUpdateGameMenu.Click += new System.EventHandler(this.btnUpdateGameMenu_Click);
            // 
            // imgCmbGames
            // 
            this.imgCmbGames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imgCmbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgCmbGames.FormattingEnabled = true;
            this.imgCmbGames.Location = new System.Drawing.Point(6, 19);
            this.imgCmbGames.Name = "imgCmbGames";
            this.imgCmbGames.Size = new System.Drawing.Size(524, 23);
            this.imgCmbGames.TabIndex = 28;
            // 
            // progressGames
            // 
            this.progressGames.Location = new System.Drawing.Point(6, 40);
            this.progressGames.MarqueeAnimationSpeed = 20;
            this.progressGames.Name = "progressGames";
            this.progressGames.Size = new System.Drawing.Size(524, 10);
            this.progressGames.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressGames.TabIndex = 24;
            this.progressGames.Visible = false;
            // 
            // btnValidateGame
            // 
            this.btnValidateGame.Location = new System.Drawing.Point(584, 19);
            this.btnValidateGame.Name = "btnValidateGame";
            this.btnValidateGame.Size = new System.Drawing.Size(86, 23);
            this.btnValidateGame.TabIndex = 27;
            this.btnValidateGame.Text = "OK";
            this.btnValidateGame.UseVisualStyleBackColor = true;
            this.btnValidateGame.Click += new System.EventHandler(this.btnValidateGame_Click);
            // 
            // contextMenuUpdateGames
            // 
            this.contextMenuUpdateGames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateAllGames});
            this.contextMenuUpdateGames.Name = "mnuUpdateGames";
            this.contextMenuUpdateGames.Size = new System.Drawing.Size(154, 26);
            // 
            // mnuUpdateAllGames
            // 
            this.mnuUpdateAllGames.Name = "mnuUpdateAllGames";
            this.mnuUpdateAllGames.Size = new System.Drawing.Size(153, 22);
            this.mnuUpdateAllGames.Text = "Load all games";
            this.mnuUpdateAllGames.Click += new System.EventHandler(this.mnuUpdateAllGames_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(12, 258);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(91, 54);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FrmStreams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 340);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupGames);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.btnChangeVLC);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnChangeStreamer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStreams";
            this.Text = "Desktop Live Streamer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStreams_FormClosed);
            this.Load += new System.EventHandler(this.FrmStreams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupLive.ResumeLayout(false);
            this.groupFavorites.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupGames.ResumeLayout(false);
            this.contextMenuUpdateGames.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupGames;
        private System.Windows.Forms.Button btnValidateGame;
        private System.Windows.Forms.ProgressBar progressGames;
        private System.Windows.Forms.Button btnUpdateGames;
        private ImageDropDownList imgCmbGames;
        private System.Windows.Forms.Button btnUpdateGameMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuUpdateGames;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAllGames;
        private System.Windows.Forms.Button btnChangeGame;
        private System.Windows.Forms.Button btnAbout;
    }
}

