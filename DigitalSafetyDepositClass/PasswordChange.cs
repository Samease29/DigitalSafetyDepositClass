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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SupportBt_Click(object sender, EventArgs e)
        {
            String helpText = "LENGTH\n+ Passwords must be 12 - 24 characters long\n\nSPECIAL CHARACTERS\n" +
                "+ Passwords must contain any combination of letters\n  (Aa -Zz), numbers(0 - 9), and 2 or more of the\nfollowing characters ( !@#$()%&_ )";
            MessageBox.Show(helpText, "DIGITAL SAFETY DEPOSIT BOX HELP");
            /*From Login Help Button*/
        }
    }
}
