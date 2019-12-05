using DigitalSafetyDepositBoxClass.DBDSModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using DigitalSafetyDepositBoxClass;

namespace DigitalSafetyDepositClass
{
    public partial class LoginForm : Form
    {
        internal int currentUser = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_name = textBox1.Text;
            String password = textBox2.Text;
            Boolean userCharMatch = Helper.textCheck(user_name, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
            Boolean passCharMatch = Helper.textCheck(password, "^(?=.{12,24}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$()%&_]{2,})");
            Boolean proceed1 = Helper.setTextBoxColor(textBox1, !userCharMatch, user_name.Contains(" "));
            Boolean proceed2 = Helper.setTextBoxColor(textBox2, !passCharMatch, password.Contains(" "));

            if (proceed1 & proceed2)
            {
                int result = Program.verifyAccount(user_name, password);
                if (result != 0)
                {
                    currentUser = result;
                    this.Close();
                }
                else
                {
                    Helper.setTextBoxColor(textBox1, false, false);
                    Helper.setTextBoxColor(textBox2, false, false);
                    MessageBox.Show("Username or Password Not Valid! Please Try Again!", "LOGIN FAILED");
                }
            }
            else
            {
                MessageBox.Show("Username or Password Not Valid! Please Try Again!", "LOGIN FAILED");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Run(new Regis());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String helpText = "LENGTH\n+ user_names must be 5 - 60 characters long\n+Passwords must be 12 - 24 characters long\n\nSPECIAL CHARACTERS\n+ user_names can contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), or the following\n  characters( _@. )\n+ Passwords must contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), and 2 or more of the\nfollowing characters ( !@#$()%&_ )";
            MessageBox.Show(helpText,"DIGITAL SAFETY DEPOSIT BOX HELP");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String email = "";
            Boolean validEmail = Helper.isValidEmail(email);
            MailAddress emailToSend = new MailAddress(email);
            
        }
    }
}
