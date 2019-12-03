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
            if(checkBox1.Checked == true)
            {
                UnameTextBox.ReadOnly = true;
                UnameTextBox.Text = EmailTextBox.Text;
            }

            if(checkBox1.Checked == false)
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
            if(checkBox1.Checked == true)
            {
                UnameTextBox.Text = EmailTextBox.Text;
            }
            String Username = UnameTextBox.Text;
            Boolean userCharMatch = Regex.IsMatch(Username, "^(?=.{5,60}$)(?=.*[\\da-zA-Z@._])");

            if (!userCharMatch)
            {
                UnameTextBox.BackColor = Color.Red;
            }
            else
            {
                UnameTextBox.BackColor = Color.White;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
