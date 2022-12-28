using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BeyogluOtomotiv
{
    public partial class MainPage : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-43SO5ER;Initial Catalog=BeyogluOtomotiv;Integrated Security=True");

        public MainPage()
        {
            InitializeComponent();
        }
        string userName = Login.username;
        string name_surname = string.Empty;
        

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
           
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lbl_user.Text = userName;
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Name_Surname FROM Owner WHERE Username='" + userName + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                lbl_namesurname.Text = dataReader["Name_Surname"].ToString();
            }
            connection.Close();
            
        }
    }
}
