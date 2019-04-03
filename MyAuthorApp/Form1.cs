using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyAuthorApp
{
    public partial class FrmDatabase : Form
    {
        Button[] btnButtons = new Button[26];
        OleDbConnection conn;
        string sql = "SELECT a.Author, t.Title, p.Name " +
                    "FROM Authors as a, Titles as t, Publishers as p, Title_Author as ta " +
                    "WHERE a.AU_ID = ta.AU_ID " +
                    "AND t.ISBN = ta.ISBN " +
                    "AND t.PubID = p.PubID";

        public FrmDatabase()
        {
            InitializeComponent();
        }

        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            // Create the buttons programmatically
            int btnWidth, btnLeft, btnTop;
            int btnHeight = 30;

            var connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mizich01\Documents\Chris\Tutorials\Udemy\Jonas Fagerberg Memberships\Databases\Books.accdb;Persist Security Info=False;";
            conn = new OleDbConnection(connString);
            conn.Open();


            btnWidth = ClientSize.Width / 13;
            btnLeft = ClientSize.Width - (13 * btnWidth);

            btnTop = grdBooks.Top + grdBooks.Height + 15;

            for (int i = 0; i < 26; i++)
            {
                btnButtons[i] = new Button();
                //Ascii Characters A is 65
                btnButtons[i].Text = ((char)(65 + i)).ToString();
                btnButtons[i].Width = btnWidth;
                btnButtons[i].Height = btnHeight;
                btnButtons[i].Left = btnLeft;
                btnButtons[i].Top = btnTop;

                Controls.Add(btnButtons[i]);
                btnButtons[i].Click += new EventHandler(btnSQL_Click);
                btnLeft += btnWidth;

                if (i==12)
                {
                    // Reset the position of the left button
                    btnLeft = ClientSize.Width - (13 * btnWidth);
                    btnTop += btnHeight;
                }

            }
            btnAllRecords.PerformClick();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            OleDbCommand command = null;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable table = new DataTable();

            Button clickedButton = (Button)sender;
            string sqlStatement;
            switch (clickedButton.Text)
            {
                case "Show All Records":
                    sqlStatement = sql;
                    break;
                default:
                    sqlStatement = sql + " AND a.Author like '" + clickedButton.Text + "%' ";
                    
                    break;
            }

            try
            {
                //create Command obj
                command = new OleDbCommand(sqlStatement, conn);
                adapter.SelectCommand = command;

                //fill that table into an adpater
                adapter.Fill(table);
                grdBooks.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            command.Dispose();
            adapter.Dispose();
            table.Dispose();

        }
       

        private void frmFormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
