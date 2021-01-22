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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ScrumTaskBoardProject
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static TextBox u;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R5P3ANL\\SQLEXPRESS;Initial Catalog=ScrumTaskBoardProject2;Integrated Security=True");
        string kullanici_adi, sifre;

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            kullanici_adi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;
            Login(kullanici_adi,sifre);
        }

        private void btn_uyeol_Click(object sender, EventArgs e)
        {

            UyeOl uye = new UyeOl();
            uye.Show();
            this.Hide();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = ('*');
        }

        public int Login(string kullaniciad, string sifre)
        {


            if (kullaniciad == "" || sifre == "")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return 0;
            }
            else
            {
                con.Open();
                string giris = "SELECT * from tbl_uye where uye_kullaniciadi=@kadi AND uye_sifre=@sifre";
                SqlCommand komut = new SqlCommand(giris, con);
                komut.Parameters.AddWithValue("@kadi", kullaniciad);
                komut.Parameters.AddWithValue("@sifre", sifre);

                SqlDataAdapter d = new SqlDataAdapter(komut);
                SqlDataReader r = komut.ExecuteReader();

                if (r.Read())
                {

                    kullaniciad = r["uye_kullaniciadi"].ToString();
                    sifre = r["uye_sifre"].ToString();
                    u = txt_uyeid;
                    txt_uyeid.Text = r["uyeid"].ToString();


                    con.Close();         
                    Arayuz ara = new Arayuz();
                    ara.Show();
                    this.Hide();
                    return 1;
                    
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
                    return 0; // UnitTest için değer döndürüldü.
                }
                                
            }
        }
    }
}
