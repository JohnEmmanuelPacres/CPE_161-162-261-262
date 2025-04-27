using System.Drawing;
using System.Text;

namespace PacresPrelim
{
    public partial class SlidingPuzzle : Form
    {
        int i, j, blocks;
        private int gridSize = 3;
        private int tileSize = 130;
        private List<PictureBox> pictureboxlist = new List<PictureBox>();
        private List<Bitmap> images = new List<Bitmap>();
        private List<string> locations = new List<string>();
        private List<string> currentLocation = new List<string>();
        private string win_pos, current_pos;
        private List<Bitmap> originalImages = new List<Bitmap>();
        private Bitmap MainBitmap;
        private int moveCount = 0;
        private int elapsedTime = 0;
        private PictureBox miniSolvedImage = null;
        private PictureBox overlayImage = null;
        private List<Image> imagesLogo;
        private int currentImageIndex = 0;
        private PuzzleLogo _logoManager;
        private TitleDisplay titleDisplay;
        private PlayButton playButton;
        private SoundManager _soundManager;

        public SlidingPuzzle()
        {
            InitializeComponent();
            InitializeTitleScreen();
        }

        private void InitializeTitleScreen()
        {
            gameTimer.Interval = 1000;
            activateShuffle.Enabled = false;
            activateShuffle.Visible = false;
            label2.Visible = false;
            movesLabel.Visible = false;
            timerLabel.Visible = false;
            gradient1.Visible = true;
            _logoManager = new PuzzleLogo();
            titleDisplay = new TitleDisplay();
            playButton = new PlayButton();
            _soundManager = new SoundManager();
            PlayBackgroundMusic1();
            volumeTrackbar.Visible = false;
            volumeLabel.Visible = false;
            volumeTrackbar.Value = 100;
            volumeLabel.Text = "100%";
            volumeTimer.Interval = 2000;
            volumeTimer.Tick += volumeTimer_Tick;
            label2.Parent = gradient1;
            movesLabel.Parent = gradient1;
            timerLabel.Parent = gradient1;
        }
        private void OpenImage(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("menuStrip.wav");
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            int gridsize = 3;
            ResetGame();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files Only | *.jpg; *.jpeg; *.gif; *.png";
            open.Title = "Select an image to solve";

            DialogResult result = open.ShowDialog();

            if (result == DialogResult.Cancel || string.IsNullOrEmpty(open.FileName))
            {
                TitleScreen();
                return;
            }

            if (result == DialogResult.OK)
            {
                try
                {
                    activateShuffle.Enabled = true;
                    MainBitmap = new Bitmap(open.FileName);
                    CreatePictureBoxes(gridSize);
                    AddImages(gridSize);
                    UpdateFormSize(gridSize);
                    RepositionControls(gridSize);
                    DisplayMiniSolvedImage();

                    activateShuffle.Visible = true;
                    label2.Visible = true;
                    movesLabel.Visible = true;
                    timerLabel.Visible = true;

                    moveCount = 0;
                    elapsedTime = 0;
                    gameTimer.Stop();
                    UpdateMovesLabel();
                    UpdateTimerLabel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TitleScreen();
                }
            }
        }

        private void UpdateFormSize(int size)
        {
            int formWidth = (size * tileSize) + 600;
            int formHeight = (size * tileSize) + 200;
            this.Size = new Size(formWidth, formHeight);
        }
        private void RepositionControls(int size)
        {
            gradient1.SendToBack();
            int gridBottom = 50 + (size * tileSize);
            int gridRight = 300 + (size * tileSize);
            activateShuffle.Location = new Point(gridRight + 20, 50);
            label2.Location = new Point(50, 50);
            int labelY = gridBottom + 20;
            movesLabel.Location = new Point(300, labelY);
            timerLabel.Location = new Point(300, labelY + 35);

            volumeTrackbar.Location = new Point(50, 200);
            volumeLabel.Location = new Point(50, 255);
        }

        private void ResetGame()
        {
            gradient1.RefreshGradient();
            foreach (PictureBox pics in pictureboxlist.ToList())
            {
                this.Controls.Remove(pics);
            }

            if (miniSolvedImage != null && overlayImage != null)
            {
                this.Controls.Remove(miniSolvedImage);
                miniSolvedImage.Dispose();
                miniSolvedImage = null;

                this.Controls.Remove(overlayImage);
                overlayImage.Dispose();
                overlayImage = null;
            }

            pictureboxlist.Clear();
            images.Clear();
            locations.Clear();
            currentLocation.Clear();
            originalImages.Clear(); 
            win_pos = string.Empty;
            current_pos = string.Empty;
            label2.Text = string.Empty;

            moveCount = 0;
            elapsedTime = 0;
            gameTimer.Stop();
            UpdateMovesLabel();
            UpdateTimerLabel();
        }

        private void CreatePictureBoxes(int size)
        {
            for (i = 0; i < size * size; i++)
            {
                PictureBox temp_pic = new PictureBox();
                temp_pic.Size = new Size(tileSize, tileSize);
                temp_pic.Tag = i.ToString(); 
                temp_pic.Click += OnPicClick;
                pictureboxlist.Add(temp_pic);
                locations.Add(temp_pic.Tag.ToString());
            }
        }

        private void OnPicClick(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            PictureBox emptyBox = pictureboxlist.Find(x => x.Tag.ToString() == "0");

            Point pic1 = pictureBox.Location;
            Point pic2 = emptyBox.Location;

            if (IsAdjacent(pic1, pic2))
            {
                SwapTiles(pictureBox, emptyBox);
                moveCount++;
                UpdateMovesLabel();
                DetermineWin();
            }
        }

        private bool IsAdjacent(Point pic1, Point pic2)
        {
            return (Math.Abs(pic1.X - pic2.X) == tileSize && pic1.Y == pic2.Y) ||
                   (Math.Abs(pic1.Y - pic2.Y) == tileSize && pic1.X == pic2.X);
        }

        private void SwapTiles(PictureBox pic1, PictureBox pic2)
        {
            _soundManager.PlaySoundEffect("puzzle_sfx.wav");
            Point tempLocation = pic1.Location;
            pic1.Location = pic2.Location;
            pic2.Location = tempLocation;

            int index1 = pictureboxlist.IndexOf(pic1);
            int index2 = pictureboxlist.IndexOf(pic2);
            pictureboxlist[index1] = pic2;
            pictureboxlist[index2] = pic1;
        }

        private void CreateImage(Bitmap main_bitmap, int height, int width, int size)
        {
            int x = 0, y = 0;
            for (blocks = 0; blocks < size * size; blocks++)
            {
                Bitmap croppedImage = new Bitmap(width, height);
                for (i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        croppedImage.SetPixel(i, j, main_bitmap.GetPixel((i + x), (j + y)));
                    }
                }
                images.Add(croppedImage);
                originalImages.Add(croppedImage);
                x += tileSize;
                if (x == tileSize * size)
                {
                    x = 0;
                    y += tileSize;
                }
            }
        }
        private void AddImages(int size)
        {
            images.Clear();
            originalImages.Clear();

            Bitmap tempBitmap = new Bitmap(MainBitmap, new Size(tileSize * size, tileSize * size));
            CreateImage(tempBitmap, tileSize, tileSize, size);

            for (i = 0; i < pictureboxlist.Count; i++)
            {
                if (pictureboxlist[i].Tag.ToString() != "0")
                {
                    pictureboxlist[i].BackgroundImage = images[i];
                }
            }

            PlacePictureBoxesToForm(size);
        }
        private void PlacePictureBoxesToForm(int size)
        {
            int x = 300, y = 50;
            for (i = 0; i < pictureboxlist.Count; i++)
            {
                pictureboxlist[i].BackColor = Color.Purple;
                if (i % size == 0 && i != 0)
                {
                    y += tileSize;
                    x = 300;
                }
                pictureboxlist[i].BorderStyle = BorderStyle.FixedSingle;
                pictureboxlist[i].Location = new Point(x, y);
                this.Controls.Add(pictureboxlist[i]);
                x += tileSize;
                win_pos += locations[i];
            }
        }

        private void ShufflePuzzle(int size)
        {
            Random rand = new Random();
            int emptyIndex = size * size - 1;
            int moves = size == 3 ? 100 : size == 4 ? 200 : 1000;

            for (i = 0; i < moves; i++)
            {
                List<int> validMoves = new List<int>();
                if (emptyIndex % size != 0) validMoves.Add(emptyIndex - 1);
                if (emptyIndex % size != size - 1) validMoves.Add(emptyIndex + 1);
                if (emptyIndex >= size) validMoves.Add(emptyIndex - size);
                if (emptyIndex < size * (size - 1)) validMoves.Add(emptyIndex + size);
                int move = validMoves[rand.Next(validMoves.Count)];
                SwapTiles(pictureboxlist[emptyIndex], pictureboxlist[move]);
                emptyIndex = move;
            }

            if (!IsSolvable(size))
            {
                SwapTiles(pictureboxlist[0], pictureboxlist[1]);
            }
        }

        private bool IsSolvable(int size)
        {
            int inversions = 0;
            for (i = 0; i < pictureboxlist.Count - 1; i++)
            {
                for (int j = i + 1; j < pictureboxlist.Count; j++)
                {
                    if (int.Parse(pictureboxlist[i].Tag.ToString()) > int.Parse(pictureboxlist[j].Tag.ToString()))
                    {
                        inversions++;
                    }
                }
            }
            return inversions % 2 == 0;
        }

        private void DetermineWin()
        {
            bool isCorrect = true;
            for (i = 0; i < pictureboxlist.Count; i++)
            {
                if (pictureboxlist[i].Tag.ToString() != i.ToString())
                {
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect)
            {
                if (elapsedTime == 0)
                {
                    label2.Text = "Shuffle it next time!";
                }
                else
                {
                    label2.Text = "Great work!";
                }

                gameTimer.Stop();
                OverlayOriginalImage();
                activateShuffle.Enabled = false;
                int min = elapsedTime / 60;
                int sec = elapsedTime % 60;

                if (elapsedTime == 0)
                {
                    _soundManager.PlaySoundEffect("oof_sfx.wav");
                    MessageBox.Show("You did not shuffle the puzzle!", "Score Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _soundManager.PlaySoundEffect("win_sfx.wav");
                    MessageBox.Show($"You solved the puzzle in {min:D2}:{sec:D2} and {moveCount} moves", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //SAVE SCORE
                    string playerName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "Save Score", "Player");
                    if (!string.IsNullOrEmpty(playerName))
                    {
                        Score score = new Score(playerName, elapsedTime, moveCount, gridSize);
                        SaveScoreToCSV(score);
                    }
                }
            }
            else
            {
                label2.Text = "Keep going!";
            }
        }

        private void OverlayOriginalImage()
        {
            if (overlayImage != null)
            {
                this.Controls.Remove(overlayImage);
            }
            overlayImage = new PictureBox();
            overlayImage.Size = new Size(tileSize * gridSize, tileSize * gridSize);
            overlayImage.Location = new Point(300, 50);
            overlayImage.SizeMode = PictureBoxSizeMode.StretchImage;
            overlayImage.Image = MainBitmap;
            this.Controls.Add(overlayImage);
            overlayImage.BringToFront();
        }

        private void DisplayMiniSolvedImage()
        {
            if (miniSolvedImage != null)
            {
                this.Controls.Remove(miniSolvedImage);
                miniSolvedImage.Dispose();
            }

            miniSolvedImage = new PictureBox();
            miniSolvedImage.Size = new Size(200, 200);
            miniSolvedImage.Location = new Point(50, 300);
            miniSolvedImage.SizeMode = PictureBoxSizeMode.StretchImage;

            Bitmap solvedImage = new Bitmap(tileSize * gridSize, tileSize * gridSize);
            using (Graphics g = Graphics.FromImage(solvedImage))
            {
                for (i = 0; i < pictureboxlist.Count; i++)
                {
                    if (pictureboxlist[i].BackgroundImage == null) continue;

                    int originalIndex = int.Parse(pictureboxlist[i].Tag.ToString());
                    int row = originalIndex / gridSize;
                    int col = originalIndex % gridSize;

                    g.DrawImage(pictureboxlist[i].BackgroundImage, col * tileSize, row * tileSize);
                }
            }

            miniSolvedImage.Image = new Bitmap(solvedImage, new Size(200, 200));
            this.Controls.Add(miniSolvedImage);
            miniSolvedImage.BringToFront();
        }

        private void ThreeByThreeMode(object sender, EventArgs e)
        {
            ResetGame();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            activateShuffle.Visible = true;
            label2.Visible = true;
            movesLabel.Visible = true;
            timerLabel.Visible = true;

            gridSize = 3;
            UpdateFormSize(gridSize);
            RepositionControls(gridSize);
            OpenImage(sender, e);
        }

        private void FourByFourMode(object sender, EventArgs e)
        {
            ResetGame();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            activateShuffle.Visible = true;
            label2.Visible = true;
            movesLabel.Visible = true;
            timerLabel.Visible = true;

            gridSize = 4;
            UpdateFormSize(gridSize);
            RepositionControls(gridSize);
            OpenImage(sender, e);
        }

        private void FiveByFiveMode(object sender, EventArgs e)
        {
            ResetGame();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            activateShuffle.Visible = true;
            label2.Visible = true;
            movesLabel.Visible = true;
            timerLabel.Visible = true;

            gridSize = 5;
            UpdateFormSize(gridSize);
            RepositionControls(gridSize);
            OpenImage(sender, e);
        }

        private void activateShuffle_Click(object sender, EventArgs e)
        {
            if (pictureboxlist.Count == 9)
            {
                ShufflePuzzle(3);
                ShuffleState();
            }
            else if (pictureboxlist.Count == 16)
            {
                ShufflePuzzle(4);
                ShuffleState();
            }
            else if (pictureboxlist.Count == 25)
            {
                ShufflePuzzle(5);
                ShuffleState();
            }
        }

        private void ShuffleState()
        {
            moveCount = 0;
            elapsedTime = 0;
            gameTimer.Start();
            UpdateMovesLabel();
            UpdateTimerLabel();
            activateShuffle.Enabled = false;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            UpdateTimerLabel();
        }
        private void UpdateTimerLabel()
        {
            int min = elapsedTime / 60;
            int sec = elapsedTime % 60;
            timerLabel.Text = $"Time: {min:D2}:{sec:D2}";
        }
        private void UpdateMovesLabel()
        {
            movesLabel.Text = $"Moves: {moveCount}";
        }

        private void ShuffleButtonStyle()
        {
            activateShuffle.FlatStyle = FlatStyle.Flat;
            activateShuffle.BackColor = Color.FromArgb(100, 142, 68, 173);
            activateShuffle.FlatAppearance.BorderSize = 1;
            activateShuffle.FlatAppearance.BorderColor = Color.Yellow;
            activateShuffle.FlatAppearance.MouseOverBackColor = Color.Gold;
            activateShuffle.FlatAppearance.MouseDownBackColor = Color.RebeccaPurple;
        }

        private void SlidingPuzzle_Load(object sender, EventArgs e)
        {
            ShuffleButtonStyle();
            try
            {
                _logoManager.LoadLogoImages();
                if (_logoManager.ImagesLogo.Count > 0)
                {
                    pictureBox1.Image = _logoManager.ImagesLogo[_logoManager.CurrentImageIndex];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                logoTimer.Interval = 1;
                logoTimer.Enabled = true;
                logoTimer.Start();

                titleDisplay.LoadTitleDisplay();
                if (titleDisplay.ImagesLogo.Count > 0)
                {
                    pictureBox2.Image = titleDisplay.ImagesLogo[titleDisplay.CurrentImageIndex];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                titleTimer.Interval = 50;
                titleTimer.Enabled = true;
                titleTimer.Start();

                playButton.LoadPlayButton();
                if (playButton.ImagesLogo.Count > 0)
                {
                    pictureBox3.Image = playButton.ImagesLogo[playButton.CurrentImageIndex];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                playButtonTimer.Interval = 50;
                playButtonTimer.Enabled = true;
                playButtonTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = _logoManager.GetNextImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void titleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = titleDisplay.GetNextImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void playButtonTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox3.Image = playButton.GetNextImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("menuStrip.wav");
            DialogResult result = MessageBox.Show("Are you sure you want toe exit the program?",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("play.wav");
            ModePlay.Show(pictureBox3, 0, pictureBox3.Height);
        }

        private void SaveScoreToCSV(Score score)
        {
            string fileName = $"scores_{score.GridSize}x{score.GridSize}.csv";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "PlayerName,TimeInSeconds,Moves\n");
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{score.PlayerName},{score.TimeInSeconds},{score.Moves}");
            }
        }

        private List<Score> LoadScoresFromCSV(int gridSize)
        {
            string fileName = $"scores_{gridSize}x{gridSize}.csv";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            List<Score> scores = new List<Score>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("PlayerName")) continue;

                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string playerName = parts[0];
                            int timeInSeconds = int.Parse(parts[1]);
                            int moves = int.Parse(parts[2]);

                            scores.Add(new Score(playerName, timeInSeconds, moves, gridSize));
                        }
                    }
                }
            }
            scores.Sort((x, y) => x.TimeInSeconds.CompareTo(y.TimeInSeconds));
            return scores.Take(5).ToList();
        }

        private void scores3x3MenuItem_Click(object sender, EventArgs e)
        {
            DisplayScores(3);
        }

        private void scores4x4MenuItem_Click(object sender, EventArgs e)
        {
            DisplayScores(4);
        }

        private void scores5x5MenuItem_Click(object sender, EventArgs e)
        {
            DisplayScores(5);
        }
        private void DisplayScores(int gridSize)
        {
            List<Score> scores = LoadScoresFromCSV(gridSize);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Top 5 Scores for {gridSize}x{gridSize} Puzzle:");
            int order = 1;
            foreach (var score in scores)
            {
                int min = score.TimeInSeconds / 60;
                int sec = score.TimeInSeconds % 60;
                sb.AppendLine($"{order}. {score.PlayerName}: {min:D2}:{sec:D2} and {score.Moves} moves");
                order++;
            }

            MessageBox.Show(sb.ToString(), $"Top 5 Scores for {gridSize}x{gridSize}");
        }

        private void returnToTitleScreen_Click(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("menuStrip.wav");
            TitleScreen();
        }

        private void TitleScreen()
        {
            ResetGame();
            gradient1.RefreshGradient();
            this.Size = new Size(1277, 701);
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            activateShuffle.Enabled = false;
            activateShuffle.Visible = false;
            label2.Visible = false;
            movesLabel.Visible = false;
            timerLabel.Visible = false;
            if (miniSolvedImage != null)
            {
                miniSolvedImage.Dispose();
            }
            volumeTrackbar.Location = new Point(12, 65);
            volumeLabel.Location = new Point(12, 124);
        }
        private void PlayBackgroundMusic1()
        {
            string backgroundMusicPath = "bgm1.wav";
            _soundManager.PlayBackgroundMusic(backgroundMusicPath, loop: true);
        }
        private void PlayBackgroundMusic2()
        {
            string backgroundMusicPath = "bgm2.wav";
            _soundManager.PlayBackgroundMusic(backgroundMusicPath, loop: true);
        }
        private void PlayBackgroundMusic3()
        {
            string backgroundMusicPath = "bgm3.wav";
            _soundManager.PlayBackgroundMusic(backgroundMusicPath, loop: true);
        }
        private void bgm1Play_Click(object sender, EventArgs e)
        {
            PlayBackgroundMusic1();
        }
        private void bgm2Play_Click(object sender, EventArgs e)
        {
            PlayBackgroundMusic2();
        }
        private void bgm3Play_Click(object sender, EventArgs e)
        {
            PlayBackgroundMusic3();
        }

        private void bgmCustom_Click(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("menuStrip.wav");
            OpenFileDialog openAudio = new OpenFileDialog();
            openAudio.Filter = "Audio Files|*.mp3;*.wav;*.ogg;*.flac";
            openAudio.Title = "Select an audio file";
            if (openAudio.ShowDialog() == DialogResult.OK)
            {
                string audioFilePath = openAudio.FileName;
                _soundManager.PlayBackgroundMusic(audioFilePath, loop: true);
            }
        }

        private void volumeTrackbar_Scroll(object sender, EventArgs e)
        {
            float volume = volumeTrackbar.Value / 100f;
            _soundManager.SetVolume(volume);
            volumeLabel.Text = $"{volumeTrackbar.Value}%";
            volumeTrackbar.Visible = true;
            volumeLabel.Visible = true;
            volumeTimer.Stop();
            volumeTimer.Start();
        }

        private void volumeTimer_Tick(object sender, EventArgs e)
        {
            volumeTrackbar.Visible = false;
            volumeLabel.Visible = false;
            volumeTimer.Stop();
        }

        private void adjustVolume_Click(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("menuStrip.wav");
            volumeTrackbar.Visible = true;
            volumeLabel.Visible = true;
            volumeTimer.Stop();
            volumeTimer.Start();
        }

        private void MenuStrip_sfx(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("menuStrip.wav");
        }

        private void HowToPlayMessage_Click(object sender, EventArgs e)
        {
            _soundManager.PlaySoundEffect("menuStrip.wav");
            DialogResult howToPlay = MessageBox.Show("Add an image either in *.jpg, *.jpeg, *.gif, *.png\n" +
                "- You can use 'File' and choose an image which will be turned to 3x3 gridsize by default.\n" +
                "- You can choose other gridsize with 'Modes'.\n" +
                "- After choosing an image, you can start shuffling the boxes to solve it.\n" +
                "- You can only shuffle once, then the timer will start and your moves will be counted.\n" +
                "- After solving the puzzle, the timer will stop.", "How to Play?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}