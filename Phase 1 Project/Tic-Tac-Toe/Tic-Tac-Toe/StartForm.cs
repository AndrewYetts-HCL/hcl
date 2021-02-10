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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            radioButtonX.Select();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            string newName = textBoxNewName.Text;

            if (newName == "new") // Check that database does not have newName
            {
                var gameForm = new GameForm(radioButtonX.Checked ? "X" : "O");
                gameForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("That name is already taken.");
            }
        }
    }
}
