using Milestone1___CST_250;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilestoneGUI
{
    public partial class Game : Form
    {
        Image flag = Image.FromFile("flag.png");
        Image mine = Image.FromFile("mine.jpg");
        static Board board = new Board(10);
        public Button[,] btnGrid = new Button[board.Size, board.Size];
        int bombs;
        Stopwatch watch = new Stopwatch();

        public Game(String difficulty)
        {
            InitializeComponent();

            switch (difficulty)
            {
                case "Easy":
                    this.BackColor = Color.Green;
                    board.setupLiveNeighbors(10);
                    board.calculateLiveNeighbors();
                    break;

                case "Medium":
                    this.BackColor = Color.Orange;
                    board.setupLiveNeighbors(25);
                    board.calculateLiveNeighbors();
                    break;

                case "Hard":
                    this.BackColor = Color.Red;
                    board.setupLiveNeighbors(50);
                    board.calculateLiveNeighbors();
                    break;
            }
            bombs = (int)board.bombs;
            lbl_bombs.Text = "Bombs: " + bombs.ToString();
            buildGame();
            watch.Start();
            timer1.Start();
        }

        // Generate buttons for game
        public void buildGame()
        {
            // This function will fill the panel1 control with butons
            int buttonSize = panel1.Width / board.Size; // Calculate button width
            panel1.Height = panel1.Width; // Create a square board

            // Nested loop. Create buttons and place them in the panel
            for (int r = 0; r < board.Size; r++)
            {
                for (int c = 0; c < board.Size; c++)
                {
                    btnGrid[r, c] = new Button();
                    btnGrid[r, c].BackColor = Color.White;

                    // Make each button square
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;

                    btnGrid[r, c].MouseDown += button_MouseDown; // Add the same click event to each button
                    panel1.Controls.Add(btnGrid[r, c]); // Place button on panel
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c); // Position button

                    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                }
            }
        }

        // MouseEventHandler for buttons
        public void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;

            // If right click
            if (e.Button == MouseButtons.Right)
            {
                if (b.Image != flag)
                {
                    b.Image = flag;
                    bombs--;
                    lbl_bombs.Text = "Bombs: " + bombs.ToString();
                }

                else
                {
                    b.Image = null;
                    bombs++;
                    lbl_bombs.Text = "Bombs: " + bombs.ToString();
                }
            }

            else
            {
                if (b.Image != flag)
                {
                    checkMove(b);
                    b.Enabled = false;
                }
            }
        }

        private void checkMove(Button b)
        {
            // Find btnGrid location
            string[] strArr = b.Tag.ToString().Split('|');
            int c = int.Parse(strArr[0]);
            int r = int.Parse(strArr[1]);

            if (!board.Grid[r, c].Live)
            {
                b.BackColor = Color.Gray;
                board.floodFill(r,c);
                drawBoard();
                lbl_moves.Text = "Moves: " + board.moves.ToString();
                if (board.moves == board.Grid.Length - board.bombs)
                {
                    victory();
                }
            }

            else
            {
                loss();
            }
        }

        // Redraws board after each turn
        private void drawBoard()
        {
           
            foreach (Button b in panel1.Controls)
            {
                string[] strArr = b.Tag.ToString().Split('|');
                int c = int.Parse(strArr[0]);
                int r = int.Parse(strArr[1]);
                if (board.Grid[r,c].Visited)
                {
                    b.BackColor = Color.Gray;
                    b.Enabled = false;
                    b.Text = board.Grid[r, c].LiveNeighbors.ToString();
                }
            }
        }

        // Triggers when win is detected
        private void victory()
        {
            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            foreach (Button b in panel1.Controls)
            {
                if (b.Enabled)
                {
                    b.Image = flag;
                }
            }
            MessageBox.Show(string.Format("You Win!\n Time Elapsed: {0}:{1}", ts.Minutes, ts.Seconds), "You Win!");
            reset();
        }

        // Triggers when loss is detected
        private void loss()
        {
            watch.Stop();
            foreach (Button b in panel1.Controls)
            {
                string[] strArr = b.Tag.ToString().Split('|');
                int c = int.Parse(strArr[0]);
                int r = int.Parse(strArr[1]);
                if (board.Grid[r, c].LiveNeighbors < 9)
                {
                    b.Text = board.Grid[r, c].LiveNeighbors.ToString();
                }
                else
                {
                    b.Image = mine;
                    b.BackColor = Color.Red;
                }
            }
            MessageBox.Show("You Lose!", "You Lose!");
            reset();
        }

        private void reset()
        {
            board.moves = 0;
            board.bombs = 0;
            watch.Reset();
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    board.Grid[r, c].LiveNeighbors = 0;
                    board.Grid[r, c].Live = false;
                    board.Grid[r, c].Visited = false;
                }
            }
        }

        // Return to main menu when form is closed
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is SelectLevel)
                {
                    open.Show();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer formatting
            TimeSpan ts = watch.Elapsed;
            lbl_time.Text = string.Format("Time: {0:00,}:{1:00}", ts.Minutes, ts.Seconds);
        }
    }
}