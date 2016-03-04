using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication1
{
    class Authenticator
    {

        private string username;
        private string password;
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        public Authenticator()
        {
            dict.Add("Ben", "111");
            dict.Add("Bob", "222");
            dict.Add("Maria", "333");

        }
        public Authenticator(string usr, string psw)
        {
            username = usr;
            password = psw;
       

        }

        public bool authenticate(string usr, string psw)
        {
            bool authenticated;
            string value;
            if (dict.TryGetValue(usr, out value))
            {
                if (value == psw)

                    authenticated = true;
                else
                    authenticated = false;

            }
            else
                authenticated = false;
            return authenticated;
         
            
        }


    }
}
