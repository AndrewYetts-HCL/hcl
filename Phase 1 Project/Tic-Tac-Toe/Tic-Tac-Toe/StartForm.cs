using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class StartForm : Form
    {
        private readonly DataSet ds;

        public StartForm()
        {
            InitializeComponent();
            radioButtonX.Select();
            ds = GetRecordsDataSet();
            PopulateListBoxRecords();
        }

        // Fills the list box with formated past games data.
        private void PopulateListBoxRecords()
        {
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string record = String.Format("| {0} | {1} | {2} |", row["Name"], row["Mark"], row["Result"]);
                listBoxRecords.Items.Add(record);
            }
        }

        // Connects to the database and executes a stored procedure to get past games data.
        private DataSet GetRecordsDataSet()
        {
            DataSet dataSetResult = new DataSet();
            string cnnString = System.Configuration.ConfigurationManager.
                ConnectionStrings["MyConnection"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("RetrieveRecords", cnn);
                    dataAdapter.Fill(dataSetResult);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return dataSetResult;
        }

        // Checks if entered name already exists in the past games data
        // then shows GameForm by passing the player's mark and game name.
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            string newName = textBoxNewName.Text.PadRight(10);

            if (!ds.Tables[0].AsEnumerable().Select(r => r["Name"]).Contains(newName))
            {
                var gameForm = new GameForm(radioButtonX.Checked ? "X" : "O", newName);
                gameForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("That name is already taken.");
            }
        }
    }
}
