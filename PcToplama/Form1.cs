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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonKayıtGiris_Click(object sender, EventArgs e)
        {
            string ad, soyad, cep, eposta, sifre, adres;

            ad = textBoxAd.Text;
            soyad = textBoxSoyad.Text;
            cep = maskedTextBoxTel.Text;
            eposta = textBoxEposta.Text;
            sifre = textBoxSifreKayit.Text;
            adres = richTextBoxAdres.Text;

            string connetionString = "Server=DESKTOP-1N40TLD;Database=YoncaPC;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                String query = "INSERT INTO [User] (Name,Surname,Email,Password,Address,PhoneNumber) VALUES (@Name,@Surname,@Email,@Password,@Address,@PhoneNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (ad == "" || soyad == "" || cep == "" || eposta == "" || sifre == "" || adres == "") {
                        MessageBox.Show("Lütfen Tüm Yerleri Doldurunuz!!!");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Name", ad);
                        command.Parameters.AddWithValue("@Surname", soyad);
                        command.Parameters.AddWithValue("@Email", eposta);
                        command.Parameters.AddWithValue("@Password", sifre);
                        command.Parameters.AddWithValue("@Address", adres);
                        command.Parameters.AddWithValue("@PhoneNumber", cep);

                        connection.Open();
                        int result = command.ExecuteNonQuery();


                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                        else
                        {
                            MessageBox.Show("Kullanıcınız başarılı bir şekilde oluşturulmuştur. Eposta adresi ve şifreniz ile giriş yapabilirsiniz.");
                            ShowLoginForm();
                        }
                    }

                }
            }
        }

        private void ShowLoginForm()
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
    }
}
