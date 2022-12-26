using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyogluOtomotiv
{
    public partial class MainPage : Form
    {
        bool sideBarExpand;
        public MainPage()
        {
            InitializeComponent();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            while(sideBarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                    break;
                }
                else
                {
                    sidebar.Width += 10;
                    if(sidebar.Width == MaximumSize.Width)
                    {
                        sideBarExpand = true;
                        sideBarTimer.Stop();
                        break;
                    }
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
