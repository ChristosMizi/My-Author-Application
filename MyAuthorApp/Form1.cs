using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAuthorApp
{
    public partial class FrmDatabase : Form
    {
        Button[] btnButtons = new Button[26];
        public FrmDatabase()
        {
            InitializeComponent();
        }

        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            // Create the buttons programmatically
            int btnWidth, btnLeft, btnTop;
            int btnHeight = 30;

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
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {

        }
    }
}
