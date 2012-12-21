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
            this.btnUpdateGames = new System.Windows.Forms.Button();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.groupGames = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangeGame = new System.Windows.Forms.Button();
            this.btnUpdateGameMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressGames = new System.Windows.Forms.ProgressBar();
            this.btnValidateGame = new System.Windows.Forms.Button();
            this.contextMenuUpdateGames = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuUpdateAllGames = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMnuPlayBest = new System.Windows.Forms.Button();
            this.contextMenuPlayBest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuPlayBest = new System.Windows.Forms.ToolStripMenuItem();
            this.imgCmbGames = new DesktopLiveStreamer.ImageDropDownList();
            this.imgCmbLiveStreams = new DesktopLiveStreamer.ImageDropDownList();
            this.imgCmbStreams = new DesktopLiveStreamer.ImageDropDownList();
            this.groupBox1.SuspendLayout();
            this.groupLive.SuspendLayout();
            this.groupFavorites.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuUpdateGames.SuspendLayout();
            this.contextMenuPlayBest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeStreamer
            // 
            this.btnChangeStreamer.Location = new System.Drawing.Point(12, 305);
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
            this.btnPlay.Location = new System.Drawing.Point(388, 305);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 54);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(510, 305);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 176);
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
            this.groupLive.Size = new System.Drawing.Size(555, 61);
            this.groupLive.TabIndex = 18;
            this.groupLive.TabStop = false;
            this.groupLive.Text = "Currently online";
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
            this.groupFavorites.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 22);
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
            this.btnChangeVLC.Location = new System.Drawing.Point(109, 305);
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
            this.btnUpdateGames.Location = new System.Drawing.Point(443, 19);
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
            this.btnOpenBrowser.Location = new System.Drawing.Point(274, 305);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(108, 54);
            this.btnOpenBrowser.TabIndex = 14;
            this.btnOpenBrowser.Text = "Open in Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // groupGames
            // 
            this.groupGames.Controls.Add(this.label4);
            this.groupGames.Controls.Add(this.btnChangeGame);
            this.groupGames.Controls.Add(this.btnUpdateGames);
            this.groupGames.Controls.Add(this.btnUpdateGameMenu);
            this.groupGames.Controls.Add(this.label3);
            this.groupGames.Controls.Add(this.pictureBox3);
            this.groupGames.Controls.Add(this.label2);
            this.groupGames.Controls.Add(this.pictureBox2);
            this.groupGames.Controls.Add(this.label1);
            this.groupGames.Controls.Add(this.pictureBox1);
            this.groupGames.Controls.Add(this.imgCmbGames);
            this.groupGames.Controls.Add(this.progressGames);
            this.groupGames.Controls.Add(this.btnValidateGame);
            this.groupGames.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGames.Location = new System.Drawing.Point(12, 12);
            this.groupGames.Name = "groupGames";
            this.groupGames.Size = new System.Drawing.Size(596, 86);
            this.groupGames.TabIndex = 21;
            this.groupGames.TabStop = false;
            this.groupGames.Text = "Live Game to Watch :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "(Own3D doesn\'t report the number of viewers for game lists)";
            // 
            // btnChangeGame
            // 
            this.btnChangeGame.Location = new System.Drawing.Point(498, 19);
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
            this.btnUpdateGameMenu.Location = new System.Drawing.Point(466, 19);
            this.btnUpdateGameMenu.Name = "btnUpdateGameMenu";
            this.btnUpdateGameMenu.Size = new System.Drawing.Size(19, 23);
            this.btnUpdateGameMenu.TabIndex = 35;
            this.btnUpdateGameMenu.UseVisualStyleBackColor = true;
            this.btnUpdateGameMenu.Click += new System.EventHandler(this.btnUpdateGameMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Own3D only";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DesktopLiveStreamer.Properties.Resources.own3d;
            this.pictureBox3.Location = new System.Drawing.Point(177, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Twitch only";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DesktopLiveStreamer.Properties.Resources.twitch;
            this.pictureBox2.Location = new System.Drawing.Point(90, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "All hosts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesktopLiveStreamer.Properties.Resources.all_hosts;
            this.pictureBox1.Location = new System.Drawing.Point(18, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // progressGames
            // 
            this.progressGames.Location = new System.Drawing.Point(6, 40);
            this.progressGames.MarqueeAnimationSpeed = 20;
            this.progressGames.Name = "progressGames";
            this.progressGames.Size = new System.Drawing.Size(431, 10);
            this.progressGames.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressGames.TabIndex = 24;
            this.progressGames.Visible = false;
            // 
            // btnValidateGame
            // 
            this.btnValidateGame.Location = new System.Drawing.Point(498, 19);
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
            this.btnAbout.Location = new System.Drawing.Point(12, 305);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(91, 54);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMnuPlayBest
            // 
            this.btnMnuPlayBest.Image = global::DesktopLiveStreamer.Properties.Resources.arrow;
            this.btnMnuPlayBest.Location = new System.Drawing.Point(485, 305);
            this.btnMnuPlayBest.Name = "btnMnuPlayBest";
            this.btnMnuPlayBest.Size = new System.Drawing.Size(19, 54);
            this.btnMnuPlayBest.TabIndex = 36;
            this.btnMnuPlayBest.UseVisualStyleBackColor = true;
            this.btnMnuPlayBest.Click += new System.EventHandler(this.btnMnuPlayBest_Click);
            // 
            // contextMenuPlayBest
            // 
            this.contextMenuPlayBest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlayBest});
            this.contextMenuPlayBest.Name = "mnuUpdateGames";
            this.contextMenuPlayBest.Size = new System.Drawing.Size(163, 26);
            // 
            // mnuPlayBest
            // 
            this.mnuPlayBest.Name = "mnuPlayBest";
            this.mnuPlayBest.Size = new System.Drawing.Size(162, 22);
            this.mnuPlayBest.Text = "Play Best Quality";
            this.mnuPlayBest.Click += new System.EventHandler(this.mnuPlayBest_Click);
            // 
            // imgCmbGames
            // 
            this.imgCmbGames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imgCmbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgCmbGames.FormattingEnabled = true;
            this.imgCmbGames.Location = new System.Drawing.Point(6, 19);
            this.imgCmbGames.Name = "imgCmbGames";
            this.imgCmbGames.Size = new System.Drawing.Size(431, 23);
            this.imgCmbGames.TabIndex = 28;
            // 
            // imgCmbLiveStreams
            // 
            this.imgCmbLiveStreams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imgCmbLiveStreams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgCmbLiveStreams.FormattingEnabled = true;
            this.imgCmbLiveStreams.Location = new System.Drawing.Point(6, 21);
            this.imgCmbLiveStreams.Name = "imgCmbLiveStreams";
            this.imgCmbLiveStreams.Size = new System.Drawing.Size(396, 23);
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
            this.imgCmbStreams.Size = new System.Drawing.Size(513, 23);
            this.imgCmbStreams.TabIndex = 22;
            this.imgCmbStreams.SelectedIndexChanged += new System.EventHandler(this.imgCmbStreams_SelectedIndexChanged);
            // 
            // FrmStreams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 384);
            this.Controls.Add(this.btnMnuPlayBest);
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
            this.groupGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuUpdateGames.ResumeLayout(false);
            this.contextMenuPlayBest.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateGameMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuUpdateGames;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAllGames;
        private System.Windows.Forms.Button btnChangeGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMnuPlayBest;
        private System.Windows.Forms.ContextMenuStrip contextMenuPlayBest;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayBest;
    }
}

