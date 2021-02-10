using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class GameForm : Form
    {
        private Button[] board;
        private bool isPlayerTurn;
        private readonly string playerMark;
        private readonly string computerMark;

        public GameForm(string playerMark)
        {
            InitializeComponent();

            this.board = new Button[]
            {
                buttonA1, buttonA2, buttonA3,
                buttonB1, buttonB2, buttonB3,
                buttonC1, buttonC2, buttonC3
            };

            this.playerMark = playerMark;
            computerMark = playerMark == "X" ? "O" : "X";
            isPlayerTurn = playerMark == "X";

            if (!isPlayerTurn) makeComputerMove();
        }

        private void makeComputerMove()
        {
            bool hasMoved = false;

            int[,] wins =
            {
                { 0, 1, 2 }, { 0, 2, 1 }, { 1, 2, 0 }, { 3, 4, 5 }, { 3, 5, 4 }, { 4, 5, 3 }, { 6, 7, 8 }, { 6, 8, 7 }, { 7, 8, 6 },
                { 0, 3, 6 }, { 0, 6, 3 }, { 3, 6, 0 }, { 1, 4, 7 }, { 1, 7, 4 }, { 4, 7, 1 }, { 2, 5, 8 }, { 2, 8, 5 }, { 5, 8, 2 },
                { 0, 4, 8 }, { 0, 8, 4 }, { 4, 8, 0 }, { 2, 4, 6 }, { 2, 6, 4 }, { 4, 6, 2 }
            };

            for (int i = 0; i < wins.GetLength(0); i++)
            {
                if (board[wins[i, 0]].Text != String.Empty && board[wins[i, 0]].Text == board[wins[i, 1]].Text && board[wins[i, 2]].Text == String.Empty)
                {
                    board[wins[i, 2]].Text = computerMark;
                    hasMoved = !hasMoved;
                    break;
                }
            }

            if (!hasMoved)
            {
                var emptyBoard = board.Where(e => e.Text == String.Empty).ToArray();

                if (emptyBoard.Length > 0)
                {
                    Random rand = new Random();
                    emptyBoard[rand.Next(emptyBoard.Length)].Text = computerMark;
                }
            }

            CheckGameStatus();
            isPlayerTurn = !isPlayerTurn;
        }

        private void CheckGameStatus()
        {
            if (board.Where(e => e.Text == String.Empty).Count() == 0)
            {
                MessageBox.Show("IT'S A DRAW!");
                RecordGame();
                Application.Exit();
            }
            else if ((board[0].Text == playerMark && board[0].Text == board[1].Text && board[1].Text == board[2].Text)
            || (board[3].Text == playerMark && board[3].Text == board[4].Text && board[4].Text == board[5].Text)
            || (board[6].Text == playerMark && board[6].Text == board[7].Text && board[7].Text == board[8].Text)
            || (board[0].Text == playerMark && board[0].Text == board[3].Text && board[3].Text == board[6].Text)
            || (board[1].Text == playerMark && board[1].Text == board[4].Text && board[4].Text == board[7].Text)
            || (board[2].Text == playerMark && board[2].Text == board[5].Text && board[5].Text == board[8].Text)
            || (board[0].Text == playerMark && board[0].Text == board[4].Text && board[4].Text == board[8].Text)
            || (board[2].Text == playerMark && board[2].Text == board[4].Text && board[4].Text == board[6].Text))
            {
                MessageBox.Show("YOU WON!");
                RecordGame();
                Application.Exit();
            }
            else if ((board[0].Text == computerMark && board[0].Text == board[1].Text && board[1].Text == board[2].Text)
           || (board[3].Text == computerMark && board[3].Text == board[4].Text && board[4].Text == board[5].Text)
           || (board[6].Text == computerMark && board[6].Text == board[7].Text && board[7].Text == board[8].Text)
           || (board[0].Text == computerMark && board[0].Text == board[3].Text && board[3].Text == board[6].Text)
           || (board[1].Text == computerMark && board[1].Text == board[4].Text && board[4].Text == board[7].Text)
           || (board[2].Text == computerMark && board[2].Text == board[5].Text && board[5].Text == board[8].Text)
           || (board[0].Text == computerMark && board[0].Text == board[4].Text && board[4].Text == board[8].Text)
           || (board[2].Text == computerMark && board[2].Text == board[4].Text && board[4].Text == board[6].Text))
            {
                MessageBox.Show("YOU LOST!");
                RecordGame();
                Application.Exit();
            }
        }

        private void RecordGame()
        {

        }

        private void makePlayerMove(int selection)
        {
            isPlayerTurn = !isPlayerTurn;
            board[selection].Text = playerMark;
            CheckGameStatus();
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[0].Text == String.Empty)
            {
                makePlayerMove(0);
                makeComputerMove();
            }
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[1].Text == String.Empty)
            {
                makePlayerMove(1);
                makeComputerMove();
            }
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[2].Text == String.Empty)
            {
                makePlayerMove(2);
                makeComputerMove();
            }
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[3].Text == String.Empty)
            {
                makePlayerMove(3);
                makeComputerMove();
            }
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[4].Text == String.Empty)
            {
                makePlayerMove(4);
                makeComputerMove();
            }
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[5].Text == String.Empty)
            {
                makePlayerMove(5);
                makeComputerMove();
            }
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[6].Text == String.Empty)
            {
                makePlayerMove(6);
                makeComputerMove();
            }
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[7].Text == String.Empty)
            {
                makePlayerMove(7);
                makeComputerMove();
            }
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn && board[8].Text == String.Empty)
            {
                makePlayerMove(8);
                makeComputerMove();
            }
        }
    }
}
