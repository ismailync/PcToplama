using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcToplama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonKaydol_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string eposta, sifre;

            eposta = textBoxEmail.Text;
            sifre = textBoxSifre.Text;

            using (SqlConnection connection = new SqlConnection(Constant.connetionString))
            {
                String query = "SELECT * FROM [User] WHERE Email=@Email AND Password=@Password";
                DataTable dt = new DataTable();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", eposta);
                    command.Parameters.AddWithValue("@Password", sifre);

                    connection.Open();
                    var result = command.ExecuteReader();

                    if (!result.HasRows)
                        MessageBox.Show("Kullanıcı bulunamadı");
                    else
                    {
                        result.Read();
                        string userId = result["Id"].ToString();

                        MessageBox.Show("Giriş başarılı.");
                        ShowPCList(Convert.ToInt32(userId)); //veri tabanındaki kullanıcı id si gönderilecek.
                    }
                }
            }
        }
        private void ShowPCList(int userId)
        {
            Form4 pcList = new Form4(userId);
            pcList.Show();
            this.Hide();

        }
    }
}
