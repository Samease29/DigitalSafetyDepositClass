using System;

namespace DSDBModel
{
    class User : Account
    {

        

        public User(String user, String pass, String fName, String lName) 
        {
            username = user;
            password = pass;
            firstName = fName;
            lastName = lName;

        }

        static bool verifyUserPass() 
        {
            return true;
        }
    }

}
