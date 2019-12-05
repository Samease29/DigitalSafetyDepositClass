using DigitalSafetyDepositClass;
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
    public partial class ProfileMain : Form
    {
        public ProfileMain()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hi!";
            textBox2.Text = "Your name here";
            textBox3.Text = "Still your name, but your last name";
            textBox4.Text = "Your gmail/yahoo or whatever you use, if you have one";
            textBox6.Text = "This account type: Super Admin/Admin/Normal User.";
            user_idField.Text = "#123456";
            InformationChange infoChagWindow = new InformationChange();
            infoChagWindow.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //PasswordChange PwcWindow = new PasswordChange();
            //PwcWindow.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfileMain_Load(object sender, EventArgs e)
        {

        }
    }
}
