using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Configuration;
using DSDBModel;

//For the test
namespace DigitalSafetyDepositClass
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new LoginForm());


        }

        static internal bool textCheck(String text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }

        static internal bool setTextBoxColor(TextBox tBox, bool match1, bool match2)
        {
            if (match1 | match2)
            {
                tBox.BackColor = Color.Red;
                return false;
            }
            else
            {
                tBox.BackColor = Color.White;
                return true;
            }
        }

        static internal bool checkUser(String username, String password) {
            User.verifyUserPass(username,password);

            return true;
        }

        static internal void registerAccount() 
        {
            Application.Run();
        }

        
    }
}
