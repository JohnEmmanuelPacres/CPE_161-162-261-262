namespace PacresPrelim
{
    partial class SlidingPuzzle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlidingPuzzle));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openAnImageToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            returnToTitleScreen = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            scoresMenuItem = new ToolStripMenuItem();
            scores3x3MenuItem = new ToolStripMenuItem();
            scores4x4MenuItem = new ToolStripMenuItem();
            scores5x5MenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            ExitGame = new ToolStripMenuItem();
            modeToolStripMenuItem = new ToolStripMenuItem();
            Mode3x3 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            Mode4x4 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            Mode5x5 = new ToolStripMenuItem();
            Sound = new ToolStripMenuItem();
            bgm1Play = new ToolStripMenuItem();
            bgm2Play = new ToolStripMenuItem();
            bgm3Play = new ToolStripMenuItem();
            bgmCustom = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            adjustVolume = new ToolStripMenuItem();
            HowToPlayMessage = new ToolStripMenuItem();
            activateShuffle = new Button();
            label2 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            gameTimer = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            movesLabel = new Label();
            pictureBox1 = new PictureBox();
            logoTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            titleTimer = new System.Windows.Forms.Timer(components);
            gradient1 = new Gradient();
            volumeLabel = new Label();
            pictureBox3 = new PictureBox();
            volumeTrackbar = new TrackBar();
            playButtonTimer = new System.Windows.Forms.Timer(components);
            ModePlay = new ContextMenuStrip(components);
            x3ToolStripMenuItem = new ToolStripMenuItem();
            x4ToolStripMenuItem1 = new ToolStripMenuItem();
            x5ToolStripMenuItem1 = new ToolStripMenuItem();
            volumeTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volumeTrackbar).BeginInit();
            ModePlay.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, modeToolStripMenuItem, Sound, HowToPlayMessage });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1259, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openAnImageToolStripMenuItem, toolStripSeparator2, returnToTitleScreen, toolStripSeparator6, scoresMenuItem, toolStripSeparator5, ExitGame });
            fileToolStripMenuItem.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(120, 33);
            fileToolStripMenuItem.Text = "Actions";
            fileToolStripMenuItem.Click += MenuStrip_sfx;
            // 
            // openAnImageToolStripMenuItem
            // 
            openAnImageToolStripMenuItem.Image = Properties.Resources.open_file;
            openAnImageToolStripMenuItem.Name = "openAnImageToolStripMenuItem";
            openAnImageToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openAnImageToolStripMenuItem.Size = new Size(373, 34);
            openAnImageToolStripMenuItem.Text = "Open an Image";
            openAnImageToolStripMenuItem.Click += OpenImage;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(370, 6);
            toolStripSeparator2.Click += MenuStrip_sfx;
            // 
            // returnToTitleScreen
            // 
            returnToTitleScreen.Image = Properties.Resources.home1;
            returnToTitleScreen.Name = "returnToTitleScreen";
            returnToTitleScreen.Size = new Size(373, 34);
            returnToTitleScreen.Text = "Return To Titlescreen";
            returnToTitleScreen.Click += returnToTitleScreen_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(370, 6);
            toolStripSeparator6.Click += MenuStrip_sfx;
            // 
            // scoresMenuItem
            // 
            scoresMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scores3x3MenuItem, scores4x4MenuItem, scores5x5MenuItem });
            scoresMenuItem.Image = Properties.Resources.view_scores;
            scoresMenuItem.Name = "scoresMenuItem";
            scoresMenuItem.Size = new Size(373, 34);
            scoresMenuItem.Text = "VIEW SCORE";
            // 
            // scores3x3MenuItem
            // 
            scores3x3MenuItem.Image = Properties.Resources._3f;
            scores3x3MenuItem.Name = "scores3x3MenuItem";
            scores3x3MenuItem.Size = new Size(232, 34);
            scores3x3MenuItem.Text = "3x3 Scores";
            scores3x3MenuItem.Click += scores3x3MenuItem_Click;
            // 
            // scores4x4MenuItem
            // 
            scores4x4MenuItem.Image = Properties.Resources._4f;
            scores4x4MenuItem.Name = "scores4x4MenuItem";
            scores4x4MenuItem.Size = new Size(232, 34);
            scores4x4MenuItem.Text = "4X4 Scores";
            scores4x4MenuItem.Click += scores4x4MenuItem_Click;
            // 
            // scores5x5MenuItem
            // 
            scores5x5MenuItem.Image = Properties.Resources._5f;
            scores5x5MenuItem.Name = "scores5x5MenuItem";
            scores5x5MenuItem.Size = new Size(232, 34);
            scores5x5MenuItem.Text = "5x5 Scores";
            scores5x5MenuItem.Click += scores5x5MenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(370, 6);
            toolStripSeparator5.Click += MenuStrip_sfx;
            // 
            // ExitGame
            // 
            ExitGame.Image = Properties.Resources.prelim_resource;
            ExitGame.Name = "ExitGame";
            ExitGame.ShortcutKeys = Keys.Control | Keys.E;
            ExitGame.Size = new Size(373, 34);
            ExitGame.Text = "EXIT GAME";
            ExitGame.Click += ExitGame_Click;
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Mode3x3, toolStripSeparator4, Mode4x4, toolStripSeparator1, Mode5x5 });
            modeToolStripMenuItem.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(93, 33);
            modeToolStripMenuItem.Text = "Mode";
            modeToolStripMenuItem.Click += MenuStrip_sfx;
            // 
            // Mode3x3
            // 
            Mode3x3.Image = Properties.Resources._3f;
            Mode3x3.Name = "Mode3x3";
            Mode3x3.Size = new Size(271, 34);
            Mode3x3.Text = "3 x 3 (Default)";
            Mode3x3.Click += ThreeByThreeMode;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(268, 6);
            toolStripSeparator4.Click += MenuStrip_sfx;
            // 
            // Mode4x4
            // 
            Mode4x4.Image = Properties.Resources._4f;
            Mode4x4.Name = "Mode4x4";
            Mode4x4.Size = new Size(271, 34);
            Mode4x4.Text = "4 x 4";
            Mode4x4.Click += FourByFourMode;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(268, 6);
            toolStripSeparator1.Click += MenuStrip_sfx;
            // 
            // Mode5x5
            // 
            Mode5x5.Image = Properties.Resources._5f;
            Mode5x5.Name = "Mode5x5";
            Mode5x5.Size = new Size(271, 34);
            Mode5x5.Text = "5 x 5";
            Mode5x5.Click += FiveByFiveMode;
            // 
            // Sound
            // 
            Sound.DropDownItems.AddRange(new ToolStripItem[] { bgm1Play, bgm2Play, bgm3Play, bgmCustom, toolStripSeparator3, adjustVolume });
            Sound.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sound.Name = "Sound";
            Sound.Size = new Size(115, 33);
            Sound.Text = "SOUNDS";
            Sound.Click += MenuStrip_sfx;
            // 
            // bgm1Play
            // 
            bgm1Play.Image = Properties.Resources.mountain;
            bgm1Play.Name = "bgm1Play";
            bgm1Play.Size = new Size(287, 34);
            bgm1Play.Text = "BGM 1 (DEFAULT)";
            bgm1Play.Click += bgm1Play_Click;
            // 
            // bgm2Play
            // 
            bgm2Play.Image = Properties.Resources.island;
            bgm2Play.Name = "bgm2Play";
            bgm2Play.Size = new Size(287, 34);
            bgm2Play.Text = "BGM 2";
            bgm2Play.Click += bgm2Play_Click;
            // 
            // bgm3Play
            // 
            bgm3Play.Image = Properties.Resources.urban;
            bgm3Play.Name = "bgm3Play";
            bgm3Play.Size = new Size(287, 34);
            bgm3Play.Text = "BGM 3";
            bgm3Play.Click += bgm3Play_Click;
            // 
            // bgmCustom
            // 
            bgmCustom.Image = Properties.Resources.customMusic;
            bgmCustom.Name = "bgmCustom";
            bgmCustom.Size = new Size(287, 34);
            bgmCustom.Text = "CUSTOM";
            bgmCustom.Click += bgmCustom_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(284, 6);
            toolStripSeparator3.Click += MenuStrip_sfx;
            // 
            // adjustVolume
            // 
            adjustVolume.Name = "adjustVolume";
            adjustVolume.Size = new Size(287, 34);
            adjustVolume.Text = "Adjust Volume";
            adjustVolume.Click += adjustVolume_Click;
            // 
            // HowToPlayMessage
            // 
            HowToPlayMessage.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HowToPlayMessage.Name = "HowToPlayMessage";
            HowToPlayMessage.Size = new Size(195, 33);
            HowToPlayMessage.Text = "HOW TO PLAY?";
            HowToPlayMessage.Click += HowToPlayMessage_Click;
            // 
            // activateShuffle
            // 
            activateShuffle.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold);
            activateShuffle.Location = new Point(1074, 591);
            activateShuffle.Name = "activateShuffle";
            activateShuffle.Size = new Size(156, 51);
            activateShuffle.TabIndex = 1;
            activateShuffle.Text = "SHUFFLE";
            activateShuffle.UseVisualStyleBackColor = true;
            activateShuffle.Click += activateShuffle_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 15F);
            label2.Location = new Point(1074, 404);
            label2.Name = "label2";
            label2.Size = new Size(173, 94);
            label2.TabIndex = 3;
            label2.Text = "STATUS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gameTimer
            // 
            gameTimer.Tick += GameTimer_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(1074, 538);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(97, 40);
            timerLabel.TabIndex = 4;
            timerLabel.Text = "Time: ";
            // 
            // movesLabel
            // 
            movesLabel.AutoSize = true;
            movesLabel.BackColor = Color.Transparent;
            movesLabel.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movesLabel.Location = new Point(1074, 498);
            movesLabel.Name = "movesLabel";
            movesLabel.Size = new Size(109, 40);
            movesLabel.TabIndex = 5;
            movesLabel.Text = "Moves: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.frame_000_delay_0_03s;
            pictureBox1.Location = new Point(24, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // logoTimer
            // 
            logoTimer.Tick += logoTimer_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.t0;
            pictureBox2.Location = new Point(199, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(869, 433);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // titleTimer
            // 
            titleTimer.Tick += titleTimer_Tick;
            // 
            // gradient1
            // 
            gradient1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradient1.Angle = 0F;
            gradient1.BackColor = Color.Violet;
            gradient1.BottomColor = Color.Empty;
            gradient1.Controls.Add(pictureBox1);
            gradient1.Controls.Add(pictureBox2);
            gradient1.Controls.Add(volumeLabel);
            gradient1.Controls.Add(pictureBox3);
            gradient1.Controls.Add(volumeTrackbar);
            gradient1.Location = new Point(0, 0);
            gradient1.Name = "gradient1";
            gradient1.Size = new Size(1259, 654);
            gradient1.TabIndex = 8;
            gradient1.TopColor = Color.DarkMagenta;
            // 
            // volumeLabel
            // 
            volumeLabel.AutoSize = true;
            volumeLabel.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeLabel.Location = new Point(12, 124);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new Size(60, 28);
            volumeLabel.TabIndex = 10;
            volumeLabel.Text = "100%";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = Properties.Resources.p7;
            pictureBox3.Location = new Point(483, 522);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // volumeTrackbar
            // 
            volumeTrackbar.BackColor = Color.Purple;
            volumeTrackbar.Location = new Point(12, 65);
            volumeTrackbar.Maximum = 100;
            volumeTrackbar.Name = "volumeTrackbar";
            volumeTrackbar.Size = new Size(165, 56);
            volumeTrackbar.TabIndex = 9;
            volumeTrackbar.Value = 100;
            volumeTrackbar.Scroll += volumeTrackbar_Scroll;
            // 
            // playButtonTimer
            // 
            playButtonTimer.Tick += playButtonTimer_Tick;
            // 
            // ModePlay
            // 
            ModePlay.ImageScalingSize = new Size(20, 20);
            ModePlay.Items.AddRange(new ToolStripItem[] { x3ToolStripMenuItem, x4ToolStripMenuItem1, x5ToolStripMenuItem1 });
            ModePlay.Name = "contextMenuStrip1";
            ModePlay.Size = new Size(258, 134);
            // 
            // x3ToolStripMenuItem
            // 
            x3ToolStripMenuItem.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x3ToolStripMenuItem.Image = Properties.Resources._3f;
            x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            x3ToolStripMenuItem.Size = new Size(257, 34);
            x3ToolStripMenuItem.Text = "3 x 3 (Default)";
            x3ToolStripMenuItem.Click += ThreeByThreeMode;
            // 
            // x4ToolStripMenuItem1
            // 
            x4ToolStripMenuItem1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x4ToolStripMenuItem1.Image = Properties.Resources._4f;
            x4ToolStripMenuItem1.Name = "x4ToolStripMenuItem1";
            x4ToolStripMenuItem1.Size = new Size(257, 34);
            x4ToolStripMenuItem1.Text = "4 x 4 ";
            x4ToolStripMenuItem1.Click += FourByFourMode;
            // 
            // x5ToolStripMenuItem1
            // 
            x5ToolStripMenuItem1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            x5ToolStripMenuItem1.Image = Properties.Resources._5f;
            x5ToolStripMenuItem1.Name = "x5ToolStripMenuItem1";
            x5ToolStripMenuItem1.Size = new Size(257, 34);
            x5ToolStripMenuItem1.Text = "5 x 5";
            x5ToolStripMenuItem1.Click += FiveByFiveMode;
            // 
            // volumeTimer
            // 
            volumeTimer.Interval = 2000;
            // 
            // SlidingPuzzle
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1259, 654);
            Controls.Add(movesLabel);
            Controls.Add(timerLabel);
            Controls.Add(label2);
            Controls.Add(activateShuffle);
            Controls.Add(menuStrip1);
            Controls.Add(gradient1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "SlidingPuzzle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sliding Puzzle Game";
            Load += SlidingPuzzle_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gradient1.ResumeLayout(false);
            gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)volumeTrackbar).EndInit();
            ModePlay.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openAnImageToolStripMenuItem;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem Mode3x3;
        private ToolStripMenuItem Mode4x4;
        private ToolStripMenuItem Mode5x5;
        private Button activateShuffle;
        private Label label2;
        private FileSystemWatcher fileSystemWatcher1;
        private ToolStripMenuItem HowToPlayMessage;
        private ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer gameTimer;
        private Label timerLabel;
        private Label movesLabel;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer logoTimer;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitGame;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer titleTimer;
        private ToolStripSeparator toolStripSeparator4;
        private Gradient gradient1;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer playButtonTimer;
        private ToolStripMenuItem scoresMenuItem;
        private ToolStripMenuItem scores3x3MenuItem;
        private ToolStripMenuItem scores4x4MenuItem;
        private ToolStripMenuItem scores5x5MenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem returnToTitleScreen;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem Sound;
        private ToolStripMenuItem bgm1Play;
        private ToolStripMenuItem bgm2Play;
        private ToolStripMenuItem bgm3Play;
        private ToolStripMenuItem bgmCustom;
        private ToolStripSeparator toolStripSeparator3;
        private ContextMenuStrip ModePlay;
        private ToolStripMenuItem x3ToolStripMenuItem;
        private ToolStripMenuItem x4ToolStripMenuItem1;
        private ToolStripMenuItem x5ToolStripMenuItem1;
        private TrackBar volumeTrackbar;
        private Label volumeLabel;
        private System.Windows.Forms.Timer volumeTimer;
        private ToolStripMenuItem adjustVolume;
    }
}
