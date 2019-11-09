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
            Boolean userSpaceMatch = Regex.IsMatch(username, "\\s | ");
            Boolean passSpaceMatch = Regex.IsMatch(password, "\\s");
            if (userSpaceMatch)
            {
                textBox1.BackColor = Color.Red;
            }
            if (passSpaceMatch)
            {
                textBox2.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
