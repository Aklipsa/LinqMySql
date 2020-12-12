using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class loginForm : Form
    {   
       
        public loginForm()
        {
            InitializeComponent();
            UserName.Text = "root";
            Password.Text = "1111";
        }
              
        private void button_ok_Click(object sender, EventArgs e)
        {
            
        }
        private void button_otmena_Click(object sender, EventArgs e)
        {
            
        }
    }
}
