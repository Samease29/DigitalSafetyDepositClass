using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSafetyDepositBoxClass
{
    public partial class Regis : Form
    {
        public Regis()
        {
            InitializeComponent();
        }

        private void SupportBt_Click(object sender, EventArgs e)
        {
            String helpText = "LENGTH\n+ Usernames must be 5 - 60 characters long" +
                "\n+Passwords must be 12 - 24 characters long\n\nSPECIAL CHARACTERS" +
                "\n+ Usernames can contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), or the following\n  characters( _@. )" +
                "\n+ Passwords must contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), and 2 or more of the\nfollowing characters ( !@#$()%&_ )";
            MessageBox.Show(helpText, "DIGITAL SAFETY DEPOSIT BOX HELP");
            /*From Login Help Button*/
        }

        private void MatchEmailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MatchEmailCheckBox.Checked == true)
            {
                //UnameTextBox.Text = EmailTextBox.Text;
                UnameTextBox.ReadOnly = true;
                UnameTextBox.Text = EmailtextBox.Text;
            }

            if (MatchEmailCheckBox.Checked == false)
            {
                UnameTextBox.ReadOnly = false;
                UnameTextBox.Text = "";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            String username = UnameTextBox.Text;
            String password = PassTextBox.Text;
            Boolean userCharMatch = Regex.IsMatch(username, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
            Boolean passCharMatch = Regex.IsMatch(password, "^(?=.{12,24}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$()%&_]{2,})");
            if (!userCharMatch)
            {
                UnameTextBox.BackColor = Color.Red;
            }
            else
            {
                UnameTextBox.BackColor = Color.White;
            }

            if (!passCharMatch)
            {
                PassTextBox.BackColor = Color.Red;
            }
            else
            {
                PassTextBox.BackColor = Color.White;
            }
            /*from LoginPage.cs*/

            if(REPassTextBox.Text == PassTextBox.Text)
            {
                REPassTextBox.BackColor = Color.White;
                PassTextBox.BackColor = Color.White;
            }
            else
            {
                REPassTextBox.BackColor = Color.Red;
                PassTextBox.BackColor = Color.Red;
            }

            if (MatchEmailCheckBox.Checked == true) 
            { 
                
            }


        }

        private void FnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
