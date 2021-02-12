using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class GameForm : Form
    {
        public string[] board = { "", "", "", "", "", "", "", "", "" };
        private readonly string gameName;
        private readonly string playerMark; 
        private readonly string computerMark;
        private bool isPlayerTurn;

        public GameForm(string playerMark, string gameName)
        {
            InitializeComponent();
            this.gameName = gameName;
            this.playerMark = playerMark;
            computerMark = playerMark == "X" ? "O" : "X";
            isPlayerTurn = playerMark == "X";
            if (!isPlayerTurn) MakeComputerMove();
        }

        // Updates the board and button that corresponds to the move parameter.
        public void UpdateBoard(int move, string mark)
        {
            Button[] temp =
            {
                buttonA1, buttonA2, buttonA3,
                buttonB1, buttonB2, buttonB3,
                buttonC1, buttonC2, buttonC3
            };

            board[move] = mark;
            temp[move].Text = mark;
            CheckGameOver();
        }

        // Checks if the board has three in a row of the passed mark.
        public bool CheckForWinner(string mark)
        {
            return (board[0] == mark && board[1] == mark && board[2] == mark)
                || (board[3] == mark && board[4] == mark && board[5] == mark)
                || (board[6] == mark && board[7] == mark && board[8] == mark)
                || (board[0] == mark && board[3] == mark && board[6] == mark)
                || (board[1] == mark && board[4] == mark && board[7] == mark)
                || (board[2] == mark && board[5] == mark && board[8] == mark)
                || (board[0] == mark && board[4] == mark && board[8] == mark)
                || (board[2] == mark && board[4] == mark && board[6] == mark);
        }

        // Checks if an end condition has been met; otherwise switch turns.
        public void CheckGameOver()
        {
            if (board.Where(e => e == String.Empty).Count() == 0)
            {
                MessageBox.Show("IT'S A DRAW!");
                RecordGame("Draw");
                var startForm = new StartForm();
                startForm.Show();
                Hide();
            }
            else if (CheckForWinner(computerMark))
            {
                MessageBox.Show("YOU LOST!");
                RecordGame("Lost");
                var startForm = new StartForm();
                startForm.Show();
                Hide();
            }
            else if (CheckForWinner(playerMark))
            {
                MessageBox.Show("YOU WON!");
                RecordGame("Won");
                var startForm = new StartForm();
                startForm.Show();
                Hide();
            }
            else
            {
                isPlayerTurn = !isPlayerTurn;
            }
        }

        // Tests if the passed position had the passed mark, would that be a winning move.
        public bool TestWinner(int position, string mark)
        {
            board[position] = mark;
            if (CheckForWinner(mark)) return true;
            board[position] = String.Empty;
            return false;
        }

        // Finds a move for the computer by entering the computer mark into 
        // each empty spot, testing first for a winning move and then a blocking 
        // move. If neither are found, then selects a random move.
        public void MakeComputerMove()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == String.Empty && TestWinner(i, computerMark))
                {
                    UpdateBoard(i, computerMark);
                    return;
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == String.Empty && TestWinner(i, playerMark))
                {
                    UpdateBoard(i, computerMark);
                    return;
                }
            }

            Random rand = new Random();
            int[] emptySpots = (new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }).Where(e => board[e] == String.Empty).ToArray();
            if (emptySpots.Length != 0) UpdateBoard(emptySpots[rand.Next(emptySpots.Length)], computerMark);
        }

        // Connects to the database and executes a stored procedure to record the game.
        public void RecordGame(string result)
        {
            string cnnString = System.Configuration.ConfigurationManager.
                ConnectionStrings["MyConnection"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("InsertRecord", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", gameName));
                    cmd.Parameters.Add(new SqlParameter("@Mark", playerMark));
                    cmd.Parameters.Add(new SqlParameter("@Result", result));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // If the spot is empty and it's the player's turn,
        // update board with clicked button and switch turns.
        public void BoardClick(int position)
        {
            if (isPlayerTurn && board[position] == String.Empty)
            {
                UpdateBoard(position, playerMark);
                MakeComputerMove();
            }
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            BoardClick(0);
        }
        private void buttonA2_Click(object sender, EventArgs e)
        {
            BoardClick(1);
        }
        private void buttonA3_Click(object sender, EventArgs e)
        {
            BoardClick(2);
        }
        private void buttonB1_Click(object sender, EventArgs e)
        {
            BoardClick(3);
        }
        private void buttonB2_Click(object sender, EventArgs e)
        {
            BoardClick(4);
        }
        private void buttonB3_Click(object sender, EventArgs e)
        {
            BoardClick(5);
        }
        private void buttonC1_Click(object sender, EventArgs e)
        {
            BoardClick(6);
        }
        private void buttonC2_Click(object sender, EventArgs e)
        {
            BoardClick(7);
        }
        private void buttonC3_Click(object sender, EventArgs e)
        {
            BoardClick(8);
        }
    }
}
