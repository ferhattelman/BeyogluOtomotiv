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
using System.IO;

namespace BeyogluOtomotiv
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-43SO5ER;Initial Catalog=BeyogluOtomotiv;Integrated Security=True");

        string imgLocation = "";
        SqlCommand cmd;
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation= dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            connection.Open();
            string sqlQuery = "Insert into Owners(Id,Email,Username,Pass,Name_Surname,Photo)Values('" + txt_id.Text + "','" + txt_email.Text + "','" + txt_username.Text + "','" + txt_pass.Text + "','" + txt_namesurname.Text + "',@images)";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Saved Successfully...!");
        }
    }
}
