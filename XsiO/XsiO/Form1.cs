using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XsiO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ButonStart_Click(object sender, EventArgs e)
        {
            String username1 = Jucator1.Text;
            String username2 = Jucator2.Text;
            XsiO f = new XsiO(username1, username2);
            this.Hide();
            f.Show();
            
        }
       
    }
}
