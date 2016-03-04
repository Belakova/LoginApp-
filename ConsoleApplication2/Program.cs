using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static private Authenticator user1 = new Authenticator();
        static void Main(string[] args)
        {    Console.WriteLine("Please enter username ");
            string usr = Console.ReadLine();
            Console.WriteLine("Please enter password ");
            string psw = Console.ReadLine();
            if (user1.authenticate(usr, psw))
            {
                Console.WriteLine("Loged in");
            }
            else {
                Console.Write("do not match");  
            }
            
            Console.ReadLine();

        }
        }
    }

