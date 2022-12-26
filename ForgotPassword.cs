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
using System.Net;
using System.Net.Mail;


namespace BeyogluOtomotiv
{
    public partial class ForgotPassword : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-43SO5ER;Initial Catalog=BeyogluOtomotiv;Integrated Security=True");
        public ForgotPassword()
        {
            InitializeComponent();
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                string godMail = "ferhattelman@outlook.com";
                string godPass = "phL26VRydF";
                string email = txt_email.Text;
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Pass FROM Owners WHERE Email='" + txt_email.Text + "'", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                string password = String.Empty;
                while (dataReader.Read())
                {
                    password = dataReader["Pass"].ToString();
                }

                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.Host = "smtp.outlook.com";
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(godMail, godPass);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(godMail, "Ferhat Telman");
                mail.To.Add(email);
                mail.Subject = "Password";
                mail.IsBodyHtml = true;
                mail.Body = password;

                smtp.Send(mail);

                MessageBox.Show("Email sent successfully!", "Imperial ");

                connection.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("There is a conflict in the system, please try again!", "Imperial ");
            }
            
        }
    }
}
