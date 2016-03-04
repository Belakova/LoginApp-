using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class Authenticator
    
    {

        Dictionary<string, string> dict = new Dictionary<string, string>();

        private string username;
        private string password;

        public Authenticator(string usr, string psw) {
            username = usr;
            password = psw;
        }

         public Authenticator(string FileName)
         {

             try
             {    if (!File.Exists(FileName))
                 {
                     System.Console.WriteLine("file does not exist");
                 }
                  using (StreamReader sr = new StreamReader(FileName))
                 {
                     string userline;
                     while ((userline = sr.ReadLine()) != null)
                     { 
                         string[] parts = userline.Split();
                         dict.Add(parts[0], parts[1]);
                    }
                     sr.Close();                   
                     System.Console.ReadLine();
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("Could not read the file", e.ToString());
             }
            
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
             DateTime date = DateTime.Now;
             TextWriter text = new StreamWriter("stream.csv", true);

             text.WriteLine("\n\r  USER : " +  usr + " \n\r Registered: " + authenticated +" \n\r DATE : " + date  );
             text.Close();
             return authenticated;
         }
         
    }

        
 }
 
