using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyogluOtomotiv
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-43SO5ER;Initial Catalog=BeyogluOtomotiv;Integrated Security=True");
        public static string username = string.Empty;
        public Login()
        {
            InitializeComponent();
        }
        private void btn_lgn_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(txt_username.Text.Trim()==String.Empty || txt_pass.Text.Trim()==String.Empty)
            {
                MessageBox.Show("Please Enter Username and Password!");
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("Select *From Owner where Username=@username AND Pass=@pass", connection);
                    command.Parameters.AddWithValue("@username", txt_username.Text);
                    command.Parameters.AddWithValue("@pass", txt_pass.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        username = txt_username.Text;
                        MessageBox.Show("Login successful!");
                        MainPage main = new MainPage();
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! Please check your informations!");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid username!");
                }
            }
            connection.Close();

            
        }

        private void frgt_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
            this.Close();
        }

        private void frgt_pass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
            this.Close();
        }
    }
   
}
