using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PcToplama
{
    public partial class Form2 : Form
    {
        int userId = 0;
        private void ShowLoginForm()
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        public Form2(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //İşlemci
            comboBox1.DisplayMember = "Type";
            comboBox1.ValueMember = "Id";
            comboBoxIslemci.DisplayMember = "Name";
            comboBoxIslemci.ValueMember = "ItemTypeId";

            comboBox1.DataSource = ItemTipiYukle(1, 2);
            comboBox1.SelectedItem = null;
            comboBoxIslemci.Text = "";

            //Anakart
            comboBox2.DisplayMember = "Type";
            comboBox2.ValueMember = "Id";
            comboBoxAnakart.DisplayMember = "Name";
            comboBoxAnakart.ValueMember = "ItemTypeId";

            comboBox2.DataSource = ItemTipiYukle(3, 5);
            comboBox2.SelectedItem = null;
            comboBoxAnakart.Text = "";

            //Ram
            comboBox3.DisplayMember = "Type";
            comboBox3.ValueMember = "Id";
            comboBoxRam.DisplayMember = "Name";
            comboBoxRam.ValueMember = "ItemTypeId";

            comboBox3.DataSource = ItemTipiYukle(6, 15);
            comboBox3.SelectedItem = null;
            comboBoxRam.Text = "";

            //Ekaran Kartı
            comboBox4.DisplayMember = "Type";
            comboBox4.ValueMember = "Id";
            comboBoxEkranKarti.DisplayMember = "Name";
            comboBoxEkranKarti.ValueMember = "ItemTypeId";

            comboBox4.DataSource = ItemTipiYukle(16, 21);
            comboBox4.SelectedItem = null;
            comboBoxEkranKarti.Text = "";

            //Sabit Disk
            comboBox5.DisplayMember = "Type";
            comboBox5.ValueMember = "Id";
            comboBoxSabitDisk.DisplayMember = "Name";
            comboBoxSabitDisk.ValueMember = "ItemTypeId";

            comboBox5.DataSource = ItemTipiYukle(22, 24);
            comboBox5.SelectedItem = null;
            comboBoxSabitDisk.Text = "";

            //SSD Disk
            comboBox6.DisplayMember = "Type";
            comboBox6.ValueMember = "Id";
            comboBoxSsdDisk.DisplayMember = "Name";
            comboBoxSsdDisk.ValueMember = "ItemTypeId";

            comboBox6.DataSource = ItemTipiYukle(25, 43);
            comboBox6.SelectedItem = null;
            comboBoxSsdDisk.Text = "";

            //Monitör
            comboBox7.DisplayMember = "Type";
            comboBox7.ValueMember = "Id";
            comboBoxMonitor.DisplayMember = "Name";
            comboBoxMonitor.ValueMember = "ItemTypeId";

            comboBox7.DataSource = ItemTipiYukle(44, 55);
            comboBox7.SelectedItem = null;
            comboBoxMonitor.Text = "";

            //Kasa
            comboBox8.DisplayMember = "Type";
            comboBox8.ValueMember = "Id";
            comboBoxKasa.DisplayMember = "Name";
            comboBoxKasa.ValueMember = "ItemTypeId";

            comboBox8.DataSource = ItemTipiYukle(56, 71);
            comboBox8.SelectedItem = null;
            comboBoxKasa.Text = "";

            //Kasa Güç Kaynağı
            comboBox9.DisplayMember = "Type";
            comboBox9.ValueMember = "Id";
            comboBoxGucKaynagi.DisplayMember = "Name";
            comboBoxGucKaynagi.ValueMember = "ItemTypeId";

            comboBox9.DataSource = ItemTipiYukle(72, 85);
            comboBox9.SelectedItem = null;
            comboBoxGucKaynagi.Text = "";

            //Hoparlör
            comboBox10.DisplayMember = "Type";
            comboBox10.ValueMember = "Id";
            comboBoxHoparlor.DisplayMember = "Name";
            comboBoxHoparlor.ValueMember = "ItemTypeId";

            comboBox10.DataSource = ItemTipiYukle(86, 91);
            comboBox10.SelectedItem = null;
            comboBoxHoparlor.Text = "";

            //Klavye Mouse Set
            comboBox11.DisplayMember = "Type";
            comboBox11.ValueMember = "Id";
            comboBoxKlavyeMouseSet.DisplayMember = "Name";
            comboBoxKlavyeMouseSet.ValueMember = "ItemTypeId";

            comboBox11.DataSource = ItemTipiYukle(92, 98);
            comboBox11.SelectedItem = null;
            comboBoxKlavyeMouseSet.Text = "";

            //Klavye
            comboBox12.DisplayMember = "Type";
            comboBox12.ValueMember = "Id";
            comboBoxKlavye.DisplayMember = "Name";
            comboBoxKlavye.ValueMember = "ItemTypeId";

            comboBox12.DataSource = ItemTipiYukle(99, 116);
            comboBox12.SelectedItem = null;
            comboBoxKlavye.Text = "";

            //Mouse
            comboBox13.DisplayMember = "Type";
            comboBox13.ValueMember = "Id";
            comboBoxMouse.DisplayMember = "Name";
            comboBoxMouse.ValueMember = "ItemTypeId";

            comboBox13.DataSource = ItemTipiYukle(117, 136);
            comboBox13.SelectedItem = null;
            comboBoxMouse.Text = "";

            //Mouse Pad
            comboBox14.DisplayMember = "Type";
            comboBox14.ValueMember = "Id";
            comboBoxMousePad.DisplayMember = "Name";
            comboBoxMousePad.ValueMember = "ItemTypeId";

            comboBox14.DataSource = ItemTipiYukle(137, 138);
            comboBox14.SelectedItem = null;
            comboBoxMousePad.Text = "";

            //Kulaklık
            comboBox15.DisplayMember = "Type";
            comboBox15.ValueMember = "Id";
            comboBoxKulaklık.DisplayMember = "Name";
            comboBoxKulaklık.ValueMember = "ItemTypeId";

            comboBox15.DataSource = ItemTipiYukle(139, 151);
            comboBox15.SelectedItem = null;
            comboBoxKulaklık.Text = "";

            //Yazıcı
            comboBox16.DisplayMember = "Type";
            comboBox16.ValueMember = "Id";
            comboBoxYazici.DisplayMember = "Name";
            comboBoxYazici.ValueMember = "ItemTypeId";

            comboBox16.DataSource = ItemTipiYukle(152, 152);
            comboBox16.SelectedItem = null;
            comboBoxYazici.Text = "";

            //İşletim Sistemi
            comboBox17.DisplayMember = "Type";
            comboBox17.ValueMember = "Id";
            comboBoxIsletimSistemi.DisplayMember = "Name";
            comboBoxIsletimSistemi.ValueMember = "ItemTypeId";

            comboBox17.DataSource = ItemTipiYukle(153, 153);
            comboBox17.SelectedItem = null;
            comboBoxIsletimSistemi.Text = "";

            //Soğutucu
            comboBox18.DisplayMember = "Type";
            comboBox18.ValueMember = "Id";
            comboBoxSogutucu.DisplayMember = "Name";
            comboBoxSogutucu.ValueMember = "ItemTypeId";

            comboBox18.DataSource = ItemTipiYukle(154, 162);
            comboBox18.SelectedItem = null;
            comboBoxSogutucu.Text = "";
        }


        private DataTable ItemTipiYukle(int startIndex, int endIndex)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Constant.connetionString))
            {
                //MARKA
                SqlCommand sorgu19 = new SqlCommand("select Id, Type from ItemType where Id BETWEEN " + startIndex.ToString() + " AND " + endIndex.ToString(), connection);
                SqlDataAdapter adp19 = new SqlDataAdapter(sorgu19);
                adp19.Fill(dt);

            }
            return dt;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIslemci.DataSource = ItemYukle(Convert.ToInt32(comboBox1.SelectedValue));
            comboBoxIslemci.Text = null;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAnakart.DataSource = ItemYukle(Convert.ToInt32(comboBox2.SelectedValue));
            comboBoxAnakart.Text = null;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRam.DataSource = ItemYukle(Convert.ToInt32(comboBox3.SelectedValue));
            comboBoxRam.Text = null;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEkranKarti.DataSource = ItemYukle(Convert.ToInt32(comboBox4.SelectedValue));
            comboBoxEkranKarti.Text = null;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSabitDisk.DataSource = ItemYukle(Convert.ToInt32(comboBox5.SelectedValue));
            comboBoxSabitDisk.Text = null;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSsdDisk.DataSource = ItemYukle(Convert.ToInt32(comboBox6.SelectedValue));
            comboBoxSsdDisk.Text = null;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMonitor.DataSource = ItemYukle(Convert.ToInt32(comboBox7.SelectedValue));
            comboBoxMonitor.Text = null;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKasa.DataSource = ItemYukle(Convert.ToInt32(comboBox8.SelectedValue));
            comboBoxKasa.Text = null;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGucKaynagi.DataSource = ItemYukle(Convert.ToInt32(comboBox9.SelectedValue));
            comboBoxGucKaynagi.Text = null;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHoparlor.DataSource = ItemYukle(Convert.ToInt32(comboBox10.SelectedValue));
            comboBoxHoparlor.Text = null;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKlavyeMouseSet.DataSource = ItemYukle(Convert.ToInt32(comboBox11.SelectedValue));
            comboBoxKlavyeMouseSet.Text = null;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKlavye.DataSource = ItemYukle(Convert.ToInt32(comboBox12.SelectedValue));
            comboBoxKlavye.Text = null;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMouse.DataSource = ItemYukle(Convert.ToInt32(comboBox13.SelectedValue));
            comboBoxMouse.Text = null;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMousePad.DataSource = ItemYukle(Convert.ToInt32(comboBox14.SelectedValue));
            comboBoxMousePad.Text = null;
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKulaklık.DataSource = ItemYukle(Convert.ToInt32(comboBox15.SelectedValue));
            comboBoxKulaklık.Text = null;
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxYazici.DataSource = ItemYukle(Convert.ToInt32(comboBox16.SelectedValue));
            comboBoxYazici.Text = null;
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIsletimSistemi.DataSource = ItemYukle(Convert.ToInt32(comboBox17.SelectedValue));
            comboBoxIsletimSistemi.Text = null;
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSogutucu.DataSource = ItemYukle(Convert.ToInt32(comboBox18.SelectedValue));
            comboBoxSogutucu.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }


        private DataTable ItemYukle(int type)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Constant.connetionString))
            {
                string query = "select Id, ItemTypeId, Name from Item where ItemTypeId = " + type.ToString();
                SqlCommand sorgu = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(sorgu);
                adp.Fill(dt);
            }
            return dt;
        }

        private int ItemFiyatHesapla(object itemId)
        {
            int toplamFiyat = 0;

            if (itemId != null)
            {

                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(Constant.connetionString))
                {
                    string query = "select Price from Item where Id = " + itemId;
                    SqlCommand sorgu = new SqlCommand(query, connection);
                    SqlDataAdapter adp = new SqlDataAdapter(sorgu);
                    adp.Fill(dt);

                    var deneme = dt.Rows[0];
                    DataRow row = dt.Rows[0];

                    toplamFiyat = Convert.ToInt32(row["Price"]);
                }
            }
            return toplamFiyat;
        }
        //-----------------------------------------------------------------------------------
        private void numericUpDownRam_ValueChanged_1(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxRam.SelectedValue);
            labelRamTl.Text = (numericUpDownRam.Value * toplamFiyat) + " TL";
        }

        private void numericUpDownSabitDisk_ValueChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxSabitDisk.SelectedValue);
            labelSabitDiskTl.Text = (numericUpDownSabitDisk.Value * toplamFiyat) + " TL";
        }

        private void numericUpDownSsdDisk_ValueChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxSsdDisk.SelectedValue);
            labelSsdDiskTl.Text = (numericUpDownSsdDisk.Value * toplamFiyat) + " TL";
        }
        //-------------------------------------------------------------------------------------
        private void comboBoxIslemci_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxIslemci.SelectedValue);
            labelIslemciTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxAnakart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxAnakart.SelectedValue);
            labelAnakartTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxRam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxRam.SelectedValue);
            labelRamTl.Text = (numericUpDownRam.Value * toplamFiyat) + " TL";
        }

        private void comboBoxEkranKarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxEkranKarti.SelectedValue);
            labelEkranKartiTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxSabitDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxSabitDisk.SelectedValue);
            labelSabitDiskTl.Text = (numericUpDownSabitDisk.Value * toplamFiyat) + " TL";
        }

        private void comboBoxSsdDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxSsdDisk.SelectedValue);
            labelSsdDiskTl.Text = (numericUpDownSsdDisk.Value * toplamFiyat) + " TL";
        }

        private void comboBoxMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxMonitor.SelectedValue);
            labelMonitorTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxKasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxKasa.SelectedValue);
            labelKasaTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxGucKaynagi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxGucKaynagi.SelectedValue);
            labelKasaGücKaynagiTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxHoparlor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxHoparlor.SelectedValue);
            labelHoparlorTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxKlavyeMouseSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxKlavyeMouseSet.SelectedValue);
            labelKlavyeMousSetTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxKlavye_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxKlavye.SelectedValue);
            labelKlavyeTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxMouse.SelectedValue);
            labelMouseTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxMousePad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxMousePad.SelectedValue);
            labelMousePadTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxKulaklık_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxKulaklık.SelectedValue);
            labelKulaklikTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxYazici_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxYazici.SelectedValue);
            labelYaziciTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxIsletimSistemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxIsletimSistemi.SelectedValue);
            labelIsletimSistemiTl.Text = toplamFiyat + " TL";
        }

        private void comboBoxSogutucu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplamFiyat = ItemFiyatHesapla(comboBoxSogutucu.SelectedValue);
            labelSogutucuTl.Text = toplamFiyat + " TL";
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();

            int computerId = ComputerKaydet();
            ItemKaydet(computerId);
        }

        private void ItemKaydet(int computerId)
        {
            int islemci = (int)comboBoxIslemci.SelectedValue;
            int islemciSayisi = 1;
            ComputerItemKaydet(computerId, islemci, islemciSayisi);

            int anakart = (int)comboBoxAnakart.SelectedValue;
            int anakartsayi = 1;
            ComputerItemKaydet(computerId, anakart, anakartsayi);

            int ram = (int)comboBoxRam.SelectedValue;
            int ramSayisi = (int)numericUpDownRam.Value;
            ComputerItemKaydet(computerId, ram, ramSayisi);

            int ekrankarti = (int)comboBoxEkranKarti.SelectedValue;
            int ekrankartisayi = 1;
            ComputerItemKaydet(computerId, ekrankarti, ekrankartisayi);

            int sabitdisk = (int)comboBoxSabitDisk.SelectedValue;
            int sabitdisksayi = (int)numericUpDownSabitDisk.Value;
            ComputerItemKaydet(computerId, sabitdisk, sabitdisksayi);

            int ssddisk = (int)comboBoxSsdDisk.SelectedValue;
            int ssddisksayi = (int)numericUpDownSsdDisk.Value;
            ComputerItemKaydet(computerId, ssddisk, ssddisksayi);

            int monitor = (int)comboBoxMonitor.SelectedValue;
            int monitorsayi = 1;
            ComputerItemKaydet(computerId, monitor, monitorsayi);

            int kasa = (int)comboBoxKasa.SelectedValue;
            int kasasayi = 1;
            ComputerItemKaydet(computerId, kasa, kasasayi);

            int kasaguc = (int)comboBoxGucKaynagi.SelectedValue;
            int kasagucsayi = 1;
            ComputerItemKaydet(computerId, kasaguc, kasagucsayi);

            int hoparlor = (int)comboBoxHoparlor.SelectedValue;
            int hoparlorsayi = 1;
            ComputerItemKaydet(computerId, hoparlor, hoparlorsayi);

            int klavyeset = (int)comboBoxKlavyeMouseSet.SelectedValue;
            int klavyesetsayi = 1;
            ComputerItemKaydet(computerId, klavyeset, klavyesetsayi);

            int klavye = (int)comboBoxKlavye.SelectedValue;
            int klavyesayi = 1;
            ComputerItemKaydet(computerId, klavye, klavyesayi);

            int mouse = (int)comboBoxMouse.SelectedValue;
            int mousesayi = 1;
            ComputerItemKaydet(computerId, mouse, mousesayi);

            int mouspad = (int)comboBoxMousePad.SelectedValue;
            int mouspadsayi = 1;
            ComputerItemKaydet(computerId, mouspad, mouspadsayi);

            int kulaklık = (int)comboBoxKulaklık.SelectedValue;
            int kulaklıksayi = 1;
            ComputerItemKaydet(computerId, kulaklık, kulaklıksayi);

            int yazici = (int)comboBoxYazici.SelectedValue;
            int yazicisayi = 1;
            ComputerItemKaydet(computerId, yazici, yazicisayi);

            int isletimsistemi = (int)comboBoxIsletimSistemi.SelectedValue;
            int isletimsistemisayi = 1;
            ComputerItemKaydet(computerId, isletimsistemi, isletimsistemisayi);

            int sogutucu = (int)comboBoxMonitor.SelectedValue;
            int sogutucusayi = 1;
            ComputerItemKaydet(computerId, sogutucu, sogutucusayi);
        }

        private void ComputerItemKaydet(int computerId, int itemId, int count)
        {
            using (SqlConnection connection = new SqlConnection(Constant.connetionString))
            {
                String query = "INSERT INTO ComputerItem (ComputerId, ItemId, Count) VALUES (@ComputerId, @ItemId, @Count)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ComputerId", computerId);
                    command.Parameters.AddWithValue("@ItemId", itemId);
                    command.Parameters.AddWithValue("@Count", count);

                    connection.Open();
                    var result = command.ExecuteNonQuery();

                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    else
                    {
                        //MessageBox.Show("Bilgisayarınız Kaydedildi");
                    }
                }
            }
        }

        private int ComputerKaydet()
        {

            using (SqlConnection connection = new SqlConnection(Constant.connetionString))
            {
                int computerId = 0;

                String query = "INSERT INTO Computer (Name, UserId) VALUES (@Name, @UserId); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (textBoxSistemAd.Text == "")
                    {
                        MessageBox.Show("Lütfen Sistem adını doldurunuz!!!");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Name", textBoxSistemAd.Text);
                        command.Parameters.AddWithValue("@UserId", this.userId);

                        connection.Open();
                        var result = Convert.ToInt32(command.ExecuteScalar());


                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                        else
                        {
                            computerId = result;
                        }
                    }

                }
                return computerId;
            }
        }
    }
}