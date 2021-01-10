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
    public partial class Form4 : Form
    {
        int userId = 0;

        private BindingSource bindingSource1 = new BindingSource();
       

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void buttonYeniEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.userId);
            form2.Show();
            this.Hide();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        void BilgiGetir()
        {
            baglanti = new SqlConnection("Server=DESKTOP-1N40TLD;Database=YoncaPC;Trusted_Connection=True;");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Computer", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
            bindingSource1.DataSource = GetData();
            dataGridView1.DataSource = bindingSource1;

            

           

            //using (SqlConnection connection = new SqlConnection(Constant.connetionString))
            //{
            //    String query = "SELECT * FROM [Computer] WHERE UserId=@UserId";
            //    DataTable dt = new DataTable();
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@UserId", this.userId);
            //        connection.Open();
            //        var result = command.ExecuteReader();

            //        if (!result.HasRows)
            //            MessageBox.Show("Kullanıcı bulunamadı");
            //        else
            //        {
            //            result.Read();


            //            MessageBox.Show("Giriş başarılı.");
            //            ShowPCList(Convert.ToInt32(userId)); //veri tabanındaki kullanıcı id si gönderilecek.
            //        }
            //    }
            //}
        }

        private DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(Constant.connetionString);

            SqlCommand command = new SqlCommand("SELECT * FROM [Computer] WHERE UserId=@UserId", conn);
            command.Parameters.AddWithValue("@UserId", this.userId);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BilgiGetir();
        }
    }
}
