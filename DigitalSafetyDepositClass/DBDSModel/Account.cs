using System;
using System.Collections.Generic;
using System.Text;

namespace DSDBModel
{
    internal class Account
    {
        protected int userID { get; set; }
        protected String username { get; set; }
        protected String password { get; set; }
        protected String firstName { get; set; }
        protected String lastName { get; set; }
        protected String email { get; set; }
        protected bool admin { get; set; }
        protected String userIsEmail { get; set; }

        static internal bool validateUser(String user, String pass)
        {

            return true;
        }

    }

    
}
