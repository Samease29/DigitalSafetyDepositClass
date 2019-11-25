using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSafetyDepositClass
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            Boolean userCharMatch = Program.textCheck(username, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");
            Boolean passCharMatch = Program.textCheck(password, "^(?=.{12,24}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$()%&_]{2,})");
            Boolean proceed1 = Program.setTextBoxColor(textBox1, !userCharMatch, username.Contains(" "));
            Boolean proceed2 = Program.setTextBoxColor(textBox2, !passCharMatch, password.Contains(" "));

            if(proceed1 & proceed2){
                bool result = Program.checkUser(username, password);
                if(result == true) 
                {

                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String helpText = "LENGTH\n+ Usernames must be 5 - 60 characters long\n+Passwords must be 12 - 24 characters long\n\nSPECIAL CHARACTERS\n+ Usernames can contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), or the following\n  characters( _@. )\n+ Passwords must contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), and 2 or more of the\nfollowing characters ( !@#$()%&_ )";
            MessageBox.Show(helpText,"DIGITAL SAFETY DEPOSIT BOX HELP");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
