using System;

namespace DSDBModel
{
    public class User : Account
    {

        String username = "";

        public User(String user, String pass, String fName, String lName) 
        {
            
            //password = pass;
            //firstName = fName;
            //lastName = lName;

        }

        static bool verifyUserPass() 
        {
            return true;
        }
    }

}
