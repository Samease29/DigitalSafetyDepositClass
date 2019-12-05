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
using System.Net.Mail;
using DigitalSafetyDepositClass;

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
            String email = EmailtextBox.Text;
            String firstName = FnameTextBox.Text;
            String lastName = LnametextBox.Text;
            String reEnterPassword = REPassTextBox.Text;
            Boolean usernameIsEmail = MatchEmailCheckBox.Checked;

            Boolean proceed5 = Helper.isValidEmail(email);
            if (proceed5 && usernameIsEmail)
                username = email;

            //Boolean userCharMatch = Regex.IsMatch(username, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
            Boolean userCharMatch = Helper.textCheck(username, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
            //Boolean passCharMatch = Regex.IsMatch(password, "^(?=.{12,24}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$()%&_]{2,})");
            Boolean passCharMatch = Helper.textCheck(password, "^(?=.{12,24}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$()%&_]{2,})");
            Boolean firstNameCharMatch = Helper.textCheck(firstName, "^[a-zA-Z]+$");
            Boolean lastNameCharMatch = Helper.textCheck(lastName, "^[a-zA-Z]+$");
            Boolean proceed1 = Helper.setTextBoxColor(UnameTextBox, !userCharMatch, username.Contains(" "));
            Boolean proceed2 = Helper.setTextBoxColor(PassTextBox, !passCharMatch, password.Contains(" "));
            Boolean proceed3 = Helper.setTextBoxColor(FnameTextBox, !firstNameCharMatch, firstName.Contains(" "));
            Boolean proceed4 = Helper.setTextBoxColor(LnametextBox, !lastNameCharMatch, lastName.Contains(" "));


            /*
             * if (!userCharMatch)
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
            if (proceed1 && proceed2 && proceed3 && proceed4 && proceed5)
            {
                if (reEnterPassword.Equals(password))
                {
                    Helper.setTextBoxColor(REPassTextBox, true, true);
                    Helper.setTextBoxColor(PassTextBox, true, true);
                    bool result = Program.registerAccount(username, password, usernameIsEmail, email, firstName, lastName);
                }
                else
                {
                    Helper.setTextBoxColor(REPassTextBox, false, false);
                    Helper.setTextBoxColor(PassTextBox, false, false);
                }
            }
            else 
            {
                MessageBox.Show("Registration Information Not Valid! Please Try Again!", "REGISTRATION FAILED");
            }


        }

        private void FnameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LnametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
