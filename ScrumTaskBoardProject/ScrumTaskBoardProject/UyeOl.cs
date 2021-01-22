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

namespace ScrumTaskBoardProject
{
    public partial class UyeOl : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R5P3ANL\\SQLEXPRESS;Initial Catalog=ScrumTaskBoardProject2;Integrated Security=True");
        public UyeOl()
        {
            InitializeComponent();
        }

        private void btn_uyeoltamamla_Click_1(object sender, EventArgs e)
        {
            if (mtb_adsoyad.Text == "" || mtb_kullaniciadi.Text == "" || mtb_sifre.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_uye(uye_ad,uye_kullaniciadi,uye_sifre) values(@ad,@kullaniciadi,@sifre)", con);
                komut.Parameters.AddWithValue("@ad", mtb_adsoyad.Text);
                komut.Parameters.AddWithValue("@kullaniciadi", mtb_kullaniciadi.Text);
                komut.Parameters.AddWithValue("@sifre", mtb_sifre.Text);

                komut.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Üyeliğiniz başarıyla oluşturuldu.");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                Form1 gr = new Form1();
                gr.Show();
                this.Hide();
            }
        }



        private void UyeOl_Load(object sender, EventArgs e)
        {

        }

        private void mtb_adsoyad_Click(object sender, EventArgs e)
        {
            mtb_adsoyad.Text = "";
        }

        private void mtb_kullaniciadi_Click(object sender, EventArgs e)
        {
            mtb_kullaniciadi.Text = "";

        }

        private void mtb_sifre_Click(object sender, EventArgs e)
        {
            mtb_sifre.Text = "";
            mtb_sifre.PasswordChar = '*';
        }

        private void btn_uyeolgeri_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide(); // geri butonu ile giriş yapılan ekrana yönlendirdik.
        }

        private void cb_sifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sifregoster.Checked)
            {
                //karakteri göster.
                mtb_sifre.PasswordChar = '\0';
            }
            else
                //karakteri gizle.
                mtb_sifre.PasswordChar = '*';
        }
    }
}
