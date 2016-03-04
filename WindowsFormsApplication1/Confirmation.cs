using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Confirmation : Form
    {
        

        Authenticator user1 = new Authenticator("h:/visual studio 2010/Projects/CW/WindowsFormsApplication1/TextFile1.csv");
      
        public Confirmation(string user)
        {
            this.BackColor = Color.Beige;
            InitializeComponent();
            UserWelcome.Text = user;
            
        }

        
        private void Confirmation_Load(object sender, EventArgs e)
        {
            
     
              

        }

        private void button1_Click(object sender, EventArgs e)
        {
             

             
            using (StreamReader reader = new StreamReader("stream.csv")) 
                
                    
                        while(!reader.EndOfStream)
            {
                richTextBox1.AppendText(reader.ReadLine());
            
                }
           
            } 
 
        }
    }
 

