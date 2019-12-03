using DigitalSafetyDepositBoxClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            //Application.Run(new LoginForm());
            //Application.Run(new ProfileMain());
            //Application.Run(new InformationChange());
            /*Application.Run(new PasswordChange());*/
            Application.Run(new Regis());
        }
    }
}
