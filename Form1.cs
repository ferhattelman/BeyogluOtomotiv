using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; // Sql için gerekli olan kütüphane

namespace BeyogluOtomotiv
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
        private void timer_Tick(object sender, EventArgs e)
        {
            if(timer.Interval >= 5000)
            {
                timer.Stop();
                Login lgn = new Login();
                lgn.Show();
                this.Hide();
            }
        }
    }
}