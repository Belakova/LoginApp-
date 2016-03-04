using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 

namespace ConsoleApplication1
{
    class Program
    {
        
   
      static private  Authenticator user1 = new Authenticator();
 //   public localhost.WebService1 user1 = new localhost.WebService1();
    //public localhost.WebService1 user1 = new localhost.WebService1();
    
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter username ");
            string usr = Console.ReadLine();
            Console.WriteLine("Please enter username ");
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
