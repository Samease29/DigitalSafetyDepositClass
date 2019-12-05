using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DigitalSafetyDepositBoxClass;

namespace DigitalSafetyDepositClass
{
    public partial class InformationChange : Form
    {
        public InformationChange()
        {
            InitializeComponent();
        }

        private void InformationChange_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String helpText = "LENGTH\n+ Usernames must be 5 - 60 characters long\n" +
                "\nSPECIAL CHARACTERS\n+ Usernames can contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), or the following\n  characters( _@. )\n";
            MessageBox.Show(helpText, "DIGITAL SAFETY DEPOSIT BOX HELP");
            /*From Login Help Button*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(MatchEmailCheckBox.Checked == true)
            {

                UnameTextBox.ReadOnly = true;
                UnameTextBox.Text = EmailTextBox.Text;
                UnameTextBox.ReadOnly = true;

            }

            if(MatchEmailCheckBox.Checked == false)
            {
                UnameTextBox.ReadOnly = false;

                UnameTextBox.Text = "";
            }
        }

        private void UnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            String username = UnameTextBox.Text;
            String password = PassTextBox.Text;
            String email = EmailTextBox.Text;
            String firstName = FnameTextBox.Text;
            String lastName = LnametextBox.Text;
            String confirmUsername = ConfirmUsername.Text;
            String confirmPassword = ConfirmPassword.Text;
            Boolean usernameIsEmail = MatchEmailCheckBox.Checked;

            Boolean proceed5 = Helper.isValidEmail(email);


            Boolean passCharMatch = Helper.textCheck(password, "^(?=.{12,24}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$()%&_]{2,})");
            Boolean firstNameCharMatch = Helper.textCheck(firstName, "^[a-zA-Z]+$");
            Boolean lastNameCharMatch = Helper.textCheck(lastName, "^[a-zA-Z]+$");
            Boolean confirmUserCharMatch = Helper.textCheck(confirmUsername, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
            Boolean confirmPassCharMatch = Helper.textCheck(confirmPassword, "^(?=.{12,24}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$()%&_]{2,})");
            Boolean proceed1 = false;
            Boolean proceed2 = Helper.setTextBoxColor(PassTextBox, !passCharMatch, password.Contains(" "));
            Boolean proceed3 = Helper.setTextBoxColor(FnameTextBox, !firstNameCharMatch, firstName.Contains(" "));
            Boolean proceed4 = Helper.setTextBoxColor(LnametextBox, !lastNameCharMatch, lastName.Contains(" "));
            Boolean proceed6 = Helper.setTextBoxColor(ConfirmUsername, !confirmUserCharMatch, confirmUsername.Contains(" "));
            Boolean proceed7 = Helper.setTextBoxColor(ConfirmPassword, !confirmPassCharMatch, confirmPassword.Contains(" "));
            Helper.setTextBoxColor(EmailTextBox, proceed5, false);

            if (!proceed5 && usernameIsEmail)
            {
                Helper.setTextBoxColor(EmailTextBox, true, true);
                Helper.setTextBoxColor(UnameTextBox, true, true);
                MessageBox.Show("Changed Information Not Valid! Please Try Again!", "INFORMATION CHANGE FAILED");
                return;
            }
            if (usernameIsEmail)
            {
                username = email;
            }
            if (!proceed5 && email.Equals(""))
            {
                proceed5 = true;
                Boolean userCharMatch = Helper.textCheck(username, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
                proceed1 = Helper.setTextBoxColor(UnameTextBox, !userCharMatch, username.Contains(" "));
            }
            else
            {
                Boolean userCharMatch = Helper.textCheck(username, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
                proceed1 = Helper.setTextBoxColor(UnameTextBox, !userCharMatch, username.Contains(" "));
            }


            if (true)
            {
                bool result = Program.changeUserInformation(username, password, usernameIsEmail, email, firstName, lastName, confirmUsername, confirmPassword);
                if (result == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Changed Information Invalid! Please Try Again!", "INFORMATION CHANGE FAILED");
                }
            }
            else
            {
                MessageBox.Show("Changed Information Invalid! Please Try Again!", "INFORMATION CHANGE FAILED");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
