using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using Jose;

namespace DigitalSafetyDepositBoxClass
{
    public static class Helper
    {
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

        /*This is the method that encrypts passwords for us. It takes unique identifier (Guid) called salt and
         * the password and converts them to a special hash for the user. You don't ever need to change this, just
         * call it where necessary.
         */
        static internal String encryptPass(String pass, Guid salt)
        {
            byte[] passBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] saltBytes = salt.ToByteArray();
            HMAC prf = new HMACSHA512();
            byte[] hash = PBKDF2.DeriveKey(passBytes, saltBytes, 2000, 256, prf);
            return Convert.ToBase64String(hash);
        }

        static internal bool isValidEmail(String email)
        {
            if (email.Equals(""))
                return false;
            try
            {
                MailAddress realEmail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
