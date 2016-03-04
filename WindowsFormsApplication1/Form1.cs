using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Authenticator user1 = new Authenticator("h:/visual studio 2010/Projects/CW/WindowsFormsApplication1/TextFile1.csv");
        public Form1()
        {
               InitializeComponent();
               this.BackColor = Color.Beige;                 
           
        }
        
        //private

        public void authenticate_Click(object sender, EventArgs e)
        
        {
            string usr = userbox.Text;
            string psw = passwordbox.Text;
            bool check = user1.authenticate(usr, psw);
            if (check)
            {
             
                result.Text = "loged in";                
                this.Hide();
                Confirmation form2=new Confirmation(usr);
                form2.ShowDialog();
                this.Close();
            }
            else {
                result.Text = "Username and Password don't match";
            }            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
           
       
    }
}
