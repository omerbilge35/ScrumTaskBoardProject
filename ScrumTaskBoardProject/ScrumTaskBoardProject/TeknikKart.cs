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
    public partial class TeknikKart : MetroFramework.Forms.MetroForm
    {
        public TeknikKart()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R5P3ANL\\SQLEXPRESS;Initial Catalog=ScrumTaskBoardProject2;Integrated Security=True");
        public static Button statikButon;
        public static Button statikButon2;
        public static Button statikButon3;
        public static Button statikButon4;
        public static TextBox txt, txt_projeadi1, txt_isinaciklamasi1, txt_notlar1, txt_uyeidis1, txt_teknikuzman1;
        public static Label lbl, lbl_tahminisure1, lbl_gerceklesensure1;
        int veriokumadongusu = 0;
        string kartnotut = "";
        static public string isid1, isid2, isid3, isid4, isid5, isid6, isid7;
        private void TeknikKart_Load(object sender, EventArgs e)
        {
            statikButon = btn_duzenletamamla;
            statikButon2 = btn_isitamamla;
            statikButon3 = btn_geridon;
            statikButon4 = btn_geridonislere;
            txt = txt_kartno;
            txt_projeadi1 = txt_projeadi;
            txt_isinaciklamasi1 = txt_isinaciklamasi;
            txt_uyeidis1 = txt_uyeidis;
            txt_teknikuzman1 = txt_teknikuzman;
            txt_notlar1 = txt_notlar;

            lbl = lbl_kartnotext;
            lbl_gerceklesensure1 = lbl_gerceklesensure;
            lbl_tahminisure1 = lbl_tahminisure;
            txt_tarih.Text = DateTime.Now.ToString();
            
            
            txt_tarih.Enabled = false;
            txt_uyeidis.Text = Form1.u.Text;

            con.Open();
            string giris = "SELECT uye_ad from tbl_uye where uyeid=@id";
            SqlCommand komut = new SqlCommand(giris, con);
            komut.Parameters.AddWithValue("@id", txt_uyeidis.Text);

            SqlDataAdapter d = new SqlDataAdapter(komut);
            SqlDataReader r = komut.ExecuteReader();

            if (r.Read())
            {

                txt_teknikuzman.Text = r["uye_ad"].ToString();

            }


            con.Close();
            if (IsleriGoruntule.buton == true) // eğer işleri görüntüle formundan geldiyse buton değişkeni true değeri alıyor ve onunla birlikte gerekli butonlar görünür yapılıyor ve değerler atanıyor.
            {
                btn_duzenletamamla.Visible = true;
                btn_isitamamla.Visible = false;
                txt_kartno.Visible = true;
                lbl_kartnotext.Visible = true;
                btn_geridon.Visible = false;
                btn_geridonislere.Visible = true;
                txt_kartno.Text = IsleriGoruntule.a;
                txt_projeadi.Text = IsleriGoruntule.b;
                lbl_tahminisure.Text = IsleriGoruntule.c;
                lbl_gerceklesensure.Text = IsleriGoruntule.d;
                txt_isinaciklamasi.Text = IsleriGoruntule.ee;
                txt_notlar.Text = IsleriGoruntule.f;
                txt_uyeidis.Text = IsleriGoruntule.g;
                txt_teknikuzman.Text = IsleriGoruntule.h;
                txt_tarih.Text = IsleriGoruntule.j;
                lbl_gerceklesensure.Text = DateTime.Now.ToString();
                IsleriGoruntule.buton = false; 
            }
            if (txt_kartno.Text == "")
            {

            }
            else
            {
                kartnotut = txt_kartno.Text;
                con.Open();
                SqlCommand verioku = new SqlCommand("select * from tbl_is where is_fk_kartno=@kartno", con);
                verioku.Parameters.AddWithValue("@kartno", kartnotut);

                verioku.ExecuteNonQuery();
                SqlDataReader oku;
                oku = verioku.ExecuteReader();

                while (oku.Read())
                {
                    if (veriokumadongusu == 0)
                    {
                        txt_yapilacakis1.Text = oku["is_yapilacakis"].ToString();
                        txt_aciklama1.Text = oku["is_yapilacakis_aciklama"].ToString();
                        cmb_durum1.Text = oku["is_durum"].ToString();
                        isid1 = oku["is_id"].ToString();
                        veriokumadongusu++;

                    }
                    else if (veriokumadongusu == 1)
                    {
                        txt_yapilacakis2.Text = oku["is_yapilacakis"].ToString();
                        txt_aciklama2.Text = oku["is_yapilacakis_aciklama"].ToString();
                        cmb_durum2.Text = oku["is_durum"].ToString();
                        isid2 = oku["is_id"].ToString();
                        veriokumadongusu++;
                    }
                    else if (veriokumadongusu == 2)
                    {
                        txt_yapilacakis3.Text = oku["is_yapilacakis"].ToString();
                        txt_aciklama3.Text = oku["is_yapilacakis_aciklama"].ToString();
                        cmb_durum3.Text = oku["is_durum"].ToString();
                        isid3 = oku["is_id"].ToString();
                        veriokumadongusu++;
                    }
                    else if (veriokumadongusu == 3)
                    {
                        txt_yapilacakis4.Text = oku["is_yapilacakis"].ToString();
                        txt_aciklama4.Text = oku["is_yapilacakis_aciklama"].ToString();
                        cmb_durum4.Text = oku["is_durum"].ToString();
                        isid4 = oku["is_id"].ToString();
                        veriokumadongusu++;
                    }
                    else if (veriokumadongusu == 4)
                    {
                        txt_yapilacakis5.Text = oku["is_yapilacakis"].ToString();
                        txt_aciklama5.Text = oku["is_yapilacakis_aciklama"].ToString();
                        cmb_durum5.Text = oku["is_durum"].ToString();
                        isid5 = oku["is_id"].ToString();
                        veriokumadongusu++;
                    }
                    else if (veriokumadongusu == 5)
                    {
                        txt_yapilacakis6.Text = oku["is_yapilacakis"].ToString();
                        txt_aciklama6.Text = oku["is_yapilacakis_aciklama"].ToString();
                        cmb_durum6.Text = oku["is_durum"].ToString();
                        isid6 = oku["is_id"].ToString();
                        veriokumadongusu++;
                    }
                    else if (veriokumadongusu == 6)
                    {
                        txt_yapilacakis7.Text = oku["is_yapilacakis"].ToString();
                        txt_aciklama7.Text = oku["is_yapilacakis_aciklama"].ToString();
                        cmb_durum7.Text = oku["is_durum"].ToString();
                        isid7 = oku["is_id"].ToString();
                        veriokumadongusu++;
                    }

                }
                oku.Close();
                con.Close();
            }


        }
        
        private void btn_geridon_Click(object sender, EventArgs e)
        {
            Arayuz aray = new Arayuz();
            aray.Show();
            this.Hide();
        }

        private void btn_geridonislere_Click(object sender, EventArgs e)
        {
            IsleriGoruntule isg = new IsleriGoruntule();
            isg.Show();
            this.Hide();
        }

        private void txt_tarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_duzenletamamla_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                string kayit = "update tbl_proje set proje_projeadi=@projead, proje_tahminisure=@tahminisure,proje_aciklama=@aciklama,proje_notlar=@notlar,proje_fk_uyeid=@fkuyeid,proje_uzman=@uzman, proje_tarih=@tarih where proje_kartno=@kartno";//proje tablosundaki verileri, kartnoya göre düzenleme ekranına aktarıyoruz.

                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@projead", txt_projeadi.Text);
                komut.Parameters.AddWithValue("@tahminisure", lbl_tahminisure.Text);              
                komut.Parameters.AddWithValue("@aciklama", txt_isinaciklamasi.Text);
                komut.Parameters.AddWithValue("@notlar", txt_notlar.Text);
                komut.Parameters.AddWithValue("@fkuyeid", txt_uyeidis.Text);
                komut.Parameters.AddWithValue("@uzman", txt_teknikuzman.Text);
                komut.Parameters.AddWithValue("@kartno", txt_kartno.Text);
                komut.Parameters.AddWithValue("@tarih", txt_tarih.Text);
                komut.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik alanları doldurunuz!");
            }
            try
            {
                if (txt_yapilacakis1.Text == "" || txt_aciklama1.Text == "" || cmb_durum1.Text == "")
                {
                    if (txt_yapilacakis1.Text == "" && txt_aciklama1.Text == "" && cmb_durum1.Text == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("1.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                    }

                }
                else if (txt_yapilacakis1.Text != "" && txt_aciklama1.Text != "" && cmb_durum1.Text != "")
                {
                    if (isid1 != null)
                    {
                        con.Open();
                        SqlCommand komut4 = new SqlCommand("update tbl_is set is_yapilacakis=@yapilacakis, is_yapilacakis_aciklama=@aciklamaa, is_durum=@durum, is_fk_kartno=@fkkartno where is_id=@idis", con);//eğer eski iş değiştirildiyse güncelliyor,,,,
                        komut4.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis1.Text);
                        komut4.Parameters.AddWithValue("@aciklamaa", txt_aciklama1.Text);
                        komut4.Parameters.AddWithValue("@durum", cmb_durum1.Text);
                        komut4.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut4.Parameters.AddWithValue("@idis", isid1);

                        komut4.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (isid1 == null)
                    {
                        con.Open();
                        SqlCommand komut4 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//eğer eski işlere yenisi yazılıyorsa düzenlemek yerine ekleme işlemi yapılıyor.,,,,,,,,,,,,
                        komut4.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis1.Text);
                        komut4.Parameters.AddWithValue("@aciklamaa", txt_aciklama1.Text);
                        komut4.Parameters.AddWithValue("@durum", cmb_durum1.Text);
                        komut4.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut4.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }
                //
                if (txt_yapilacakis2.Text == "" || txt_aciklama2.Text == "" || cmb_durum2.Text == "")
                {
                    if (txt_yapilacakis2.Text == "" && txt_aciklama2.Text == "" && cmb_durum2.Text == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("2.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                    }

                }
                else if (txt_yapilacakis2.Text != "" && txt_aciklama2.Text != "" && cmb_durum2.Text != "")
                {
                    if (isid2 != null)
                    {
                        con.Open();
                        SqlCommand komut10 = new SqlCommand("update tbl_is set is_yapilacakis=@yapilacakis, is_yapilacakis_aciklama=@aciklamaa, is_durum=@durum, is_fk_kartno=@fkkartno where is_id=@idis", con);//eğer eski iş değiştirildiyse güncelliyor,
                        komut10.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis2.Text);
                        komut10.Parameters.AddWithValue("@aciklamaa", txt_aciklama2.Text);
                        komut10.Parameters.AddWithValue("@durum", cmb_durum2.Text);
                        komut10.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut10.Parameters.AddWithValue("@idis", isid2);
                        komut10.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (isid2 == null)
                    {

                        con.Open();
                        SqlCommand komut10 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//eğer eski işlere yenisi yazılıyorsa düzenlemek yerine ekleme işlemi yapılıyor.,,,,,,
                        komut10.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis2.Text);
                        komut10.Parameters.AddWithValue("@aciklamaa", txt_aciklama2.Text);
                        komut10.Parameters.AddWithValue("@durum", cmb_durum2.Text);
                        komut10.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        
                        komut10.ExecuteNonQuery();
                        con.Close();
                    }
                }
                //
                if (txt_yapilacakis3.Text == "" || txt_aciklama3.Text == "" || cmb_durum3.Text == "")
                {
                    if (txt_yapilacakis3.Text == "" && txt_aciklama3.Text == "" && cmb_durum3.Text == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("3.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                    }

                }
                else if (txt_yapilacakis3.Text != "" && txt_aciklama3.Text != "" && cmb_durum3.Text != "")
                {
                    if (isid3 != null)
                    {
                        con.Open();
                        SqlCommand komut5 = new SqlCommand("update tbl_is set is_yapilacakis=@yapilacakis, is_yapilacakis_aciklama=@aciklamaa, is_durum=@durum, is_fk_kartno=@fkkartno where is_id=@idis", con);//eğer eski iş değiştirildiyse güncelliyor,,.
                        komut5.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis3.Text);
                        komut5.Parameters.AddWithValue("@aciklamaa", txt_aciklama3.Text);
                        komut5.Parameters.AddWithValue("@durum", cmb_durum3.Text);
                        komut5.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut5.Parameters.AddWithValue("@idis", isid3);
                        komut5.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (isid3 == null)
                    {
                        con.Open();
                        SqlCommand komut5 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//eğer eski işlere yenisi yazılıyorsa düzenlemek yerine ekleme işlemi yapılıyor.,,,,,
                        komut5.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis3.Text);
                        komut5.Parameters.AddWithValue("@aciklamaa", txt_aciklama3.Text);
                        komut5.Parameters.AddWithValue("@durum", cmb_durum3.Text);
                        komut5.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        
                        komut5.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }
                //
                if (txt_yapilacakis4.Text == "" || txt_aciklama4.Text == "" || cmb_durum4.Text == "")
                {
                    if (txt_yapilacakis4.Text == "" && txt_aciklama4.Text == "" && cmb_durum4.Text == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("4.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                    }

                }
                else if (txt_yapilacakis4.Text != "" && txt_aciklama4.Text != "" && cmb_durum4.Text != "")
                {
                    if (isid4 != null)
                    {
                        con.Open();
                        SqlCommand komut6 = new SqlCommand("update tbl_is set is_yapilacakis=@yapilacakis, is_yapilacakis_aciklama=@aciklamaa, is_durum=@durum, is_fk_kartno=@fkkartno where is_id=@idis", con);//eğer eski iş değiştirildiyse güncelliyor.,.,
                        komut6.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis4.Text);
                        komut6.Parameters.AddWithValue("@aciklamaa", txt_aciklama4.Text);
                        komut6.Parameters.AddWithValue("@durum", cmb_durum4.Text);
                        komut6.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut6.Parameters.AddWithValue("@idis", isid4);
                        komut6.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (isid4 == null)
                    {
                        con.Open();
                        SqlCommand komut6 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//eğer eski işlere yenisi yazılıyorsa düzenlemek yerine ekleme işlemi yapılıyor.,,,,
                        komut6.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis4.Text);
                        komut6.Parameters.AddWithValue("@aciklamaa", txt_aciklama4.Text);
                        komut6.Parameters.AddWithValue("@durum", cmb_durum4.Text);
                        komut6.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        
                        komut6.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }
                //
                if (txt_yapilacakis5.Text == "" || txt_aciklama5.Text == "" || cmb_durum5.Text == "")
                {
                    if (txt_yapilacakis5.Text == "" && txt_aciklama5.Text == "" && cmb_durum5.Text == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("5.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                    }

                }
                else if (txt_yapilacakis5.Text != "" && txt_aciklama5.Text != "" && cmb_durum5.Text != "")
                {
                    if (isid5 != null)
                    {
                        con.Open();
                        SqlCommand komut7 = new SqlCommand("update tbl_is set is_yapilacakis=@yapilacakis, is_yapilacakis_aciklama=@aciklamaa, is_durum=@durum, is_fk_kartno=@fkkartno where is_id=@idis", con);//eğer eski iş değiştirildiyse güncelliyor,.,.
                        komut7.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis5.Text);
                        komut7.Parameters.AddWithValue("@aciklamaa", txt_aciklama5.Text);
                        komut7.Parameters.AddWithValue("@durum", cmb_durum5.Text);
                        komut7.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut7.Parameters.AddWithValue("@idis", isid5);
                        komut7.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (isid5 == null)
                    {
                        con.Open();
                        SqlCommand komut7 = new SqlCommand("insert into tbl_is(is_yapilacakis, is_yapilacakis_aciklama, is_durum, is_fk_kartno) values(@yapilacakis, @aciklamaa, @durum, @fkkartno)", con);//eğer eski işlere yenisi yazılıyorsa düzenlemek yerine ekleme işlemi yapılıyor.,,,
                        komut7.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis5.Text);
                        komut7.Parameters.AddWithValue("@aciklamaa", txt_aciklama5.Text);
                        komut7.Parameters.AddWithValue("@durum", cmb_durum5.Text);
                        komut7.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        
                        komut7.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }
                //
                if (txt_yapilacakis6.Text == "" || txt_aciklama6.Text == "" || cmb_durum6.Text == "")
                {
                    if (txt_yapilacakis6.Text == "" && txt_aciklama6.Text == "" && cmb_durum6.Text == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("6.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                    }

                }
                else if (txt_yapilacakis6.Text != "" && txt_aciklama6.Text != "" && cmb_durum6.Text != "")
                {
                    if (isid6 != null)
                    {
                        con.Open();
                        SqlCommand komut8 = new SqlCommand("update tbl_is set is_yapilacakis=@yapilacakis, is_yapilacakis_aciklama=@aciklamaa, is_durum=@durum, is_fk_kartno=@fkkartno where is_id=@idis", con);//eğer eski iş değiştirildiyse güncelliyor..,,
                        komut8.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis6.Text);
                        komut8.Parameters.AddWithValue("@aciklamaa", txt_aciklama6.Text);
                        komut8.Parameters.AddWithValue("@durum", cmb_durum6.Text);
                        komut8.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut8.Parameters.AddWithValue("@idis", isid6);
                        komut8.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (isid6 == null)
                    {
                        con.Open();
                        SqlCommand komut8 = new SqlCommand("insert into tbl_is(is_yapilacakis, is_yapilacakis_aciklama, is_durum, is_fk_kartno) values(@yapilacakis, @aciklamaa, @durum, @fkkartno)", con);//eğer eski işlere yenisi yazılıyorsa düzenlemek yerine ekleme işlemi yapılıyor.,,
                        komut8.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis6.Text);
                        komut8.Parameters.AddWithValue("@aciklamaa", txt_aciklama6.Text);
                        komut8.Parameters.AddWithValue("@durum", cmb_durum6.Text);
                        komut8.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        
                        komut8.ExecuteNonQuery();
                        con.Close();
                    }
                }
                    
                
                //
                if (txt_yapilacakis7.Text == "" || txt_aciklama7.Text == "" || cmb_durum7.Text == "")
                {
                    if (txt_yapilacakis7.Text == "" && txt_aciklama7.Text == "" && cmb_durum7.Text == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("7.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                    }

                }
                else if (txt_yapilacakis7.Text != "" && txt_aciklama7.Text != "" && cmb_durum7.Text != "")
                {
                    if (isid7 != null)
                    {
                        con.Open();
                        SqlCommand komut9 = new SqlCommand("update tbl_is set is_yapilacakis=@yapilacakis, is_yapilacakis_aciklama=@aciklamaa, is_durum=@durum, is_fk_kartno=@fkkartno where is_id=@idis", con); //eğer eski iş değiştirildiyse güncelliyor,,..
                        komut9.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis7.Text);
                        komut9.Parameters.AddWithValue("@aciklamaa", txt_aciklama7.Text);
                        komut9.Parameters.AddWithValue("@durum", cmb_durum7.Text);
                        komut9.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut9.Parameters.AddWithValue("@idis", isid7);
                        komut9.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (true)
                    {
                        con.Open();
                        SqlCommand komut9 = new SqlCommand("insert into tbl_is(is_yapilacakis, is_yapilacakis_aciklama, is_durum, is_fk_kartno) values(@yapilacakis, @aciklamaa, @durum, @fkkartno)", con);//eğer eski işlere yenisi yazılıyorsa düzenlemek yerine ekleme işlemi yapılıyor.,
                        komut9.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis7.Text);
                        komut9.Parameters.AddWithValue("@aciklamaa", txt_aciklama7.Text);
                        komut9.Parameters.AddWithValue("@durum", cmb_durum7.Text);
                        komut9.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        
                        komut9.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }           
                MessageBox.Show("Proje Bilgileri Güncellendi.");
                IsleriGoruntule igg = new IsleriGoruntule();
                igg.Show();
                this.Hide();
            }
            catch (Exception Ex) 
            {

                MessageBox.Show("hatan burda"+ Environment.NewLine + Ex.ToString());
            }
            
        
    
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btn_isitamamla_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_projeadi.Text == "" || txt_notlar.Text == "" || txt_isinaciklamasi.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanların dolu olduğundan emin olun.");
                }
                else
                {
                    Random ra = new Random();
                    DateTime rDate = new DateTime(ra.Next(2021, 2021), ra.Next(2, 4), ra.Next(1, 28));

                    lbl_tahminisure.Text = rDate.ToString();
                    con.Open();
                    SqlCommand komut = new SqlCommand("insert into tbl_proje(proje_projeadi,proje_tahminisure,proje_aciklama,proje_notlar,proje_fk_uyeid,proje_uzman,proje_tarih) values(@projead,@tahminisure,@aciklama,@notlar,@fkuyeid,@uzman,@tarih)", con);//bilgileri proje tablosuna ekliyoruz..

                    komut.Parameters.AddWithValue("@projead", txt_projeadi.Text);
                    komut.Parameters.AddWithValue("@tahminisure", lbl_tahminisure.Text);
                    komut.Parameters.AddWithValue("@aciklama", txt_isinaciklamasi.Text);
                    komut.Parameters.AddWithValue("@notlar", txt_notlar.Text);
                    komut.Parameters.AddWithValue("@fkuyeid", txt_uyeidis.Text);
                    komut.Parameters.AddWithValue("@uzman", txt_teknikuzman.Text);
                    komut.Parameters.AddWithValue("@tarih", txt_tarih.Text);
                    komut.ExecuteNonQuery();
                    con.Close();



                    con.Open();
                     string sonkartno = "SELECT TOP 1 proje_kartno FROM tbl_proje ORDER BY proje_kartno DESC";
                     SqlCommand komut3 = new SqlCommand(sonkartno, con);
                     SqlDataAdapter d = new SqlDataAdapter(komut3);
                     SqlDataReader r = komut3.ExecuteReader();
                     if (r.Read())
                     {
                         txt_kartno.Text = r["proje_kartno"].ToString();
                     }

                     con.Close();

                    if (txt_yapilacakis1.Text == "" || txt_aciklama1.Text == "" || cmb_durum1.Text == "")
                    {
                        if (txt_yapilacakis1.Text == "" && txt_aciklama1.Text == "" && cmb_durum1.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("1.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                        }

                    }
                    else if (txt_yapilacakis1.Text != "" && txt_aciklama1.Text != "" && cmb_durum1.Text != "")
                    {
                        con.Open();
                        SqlCommand komut2 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//bilgileri iş tablosuna ekliyoruz..
                        //
                        komut2.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis1.Text);
                        komut2.Parameters.AddWithValue("@aciklamaa", txt_aciklama1.Text);
                        komut2.Parameters.AddWithValue("@durum", cmb_durum1.Text);
                        komut2.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut2.ExecuteNonQuery();
                        con.Close();
                    }

                    //
                    if (txt_yapilacakis2.Text == "" || txt_aciklama2.Text == "" || cmb_durum2.Text == "")
                    {
                        if (txt_yapilacakis2.Text == "" && txt_aciklama2.Text == "" && cmb_durum2.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("2.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                        }

                    }
                    else if (txt_yapilacakis2.Text != "" && txt_aciklama2.Text != "" && cmb_durum2.Text != "")
                    {
                        con.Open();
                        SqlCommand komut4 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//bilgileri iş tablosuna ekliyoruz.,
                        komut4.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis2.Text);
                        komut4.Parameters.AddWithValue("@aciklamaa", txt_aciklama2.Text);
                        komut4.Parameters.AddWithValue("@durum", cmb_durum2.Text);
                        komut4.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut4.ExecuteNonQuery();
                        con.Close();
                    }
                    //
                    if (txt_yapilacakis3.Text == "" || txt_aciklama3.Text == "" || cmb_durum3.Text == "")
                    {
                        if (txt_yapilacakis3.Text == "" && txt_aciklama3.Text == "" && cmb_durum3.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("3.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                        }

                    }
                    else if (txt_yapilacakis3.Text != "" && txt_aciklama3.Text != "" && cmb_durum3.Text != "")
                    {
                        con.Open();
                        SqlCommand komut5 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//bilgileri iş tablosuna ekliyoruz.,,
                        komut5.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis3.Text);
                        komut5.Parameters.AddWithValue("@aciklamaa", txt_aciklama3.Text);
                        komut5.Parameters.AddWithValue("@durum", cmb_durum3.Text);
                        komut5.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut5.ExecuteNonQuery();
                        con.Close();
                    }
                    //
                    if (txt_yapilacakis4.Text == "" || txt_aciklama4.Text == "" || cmb_durum4.Text == "")
                    {
                        if (txt_yapilacakis4.Text == "" && txt_aciklama4.Text == "" && cmb_durum4.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("4.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                        }

                    }
                    else if (txt_yapilacakis4.Text != "" && txt_aciklama4.Text != "" && cmb_durum4.Text != "")
                    {
                        con.Open();
                        SqlCommand komut6 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//bilgileri iş tablosuna ekliyoruz.,,,
                        komut6.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis4.Text);
                        komut6.Parameters.AddWithValue("@aciklamaa", txt_aciklama4.Text);
                        komut6.Parameters.AddWithValue("@durum", cmb_durum4.Text);
                        komut6.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut6.ExecuteNonQuery();
                        con.Close();
                    }
                    //
                    if (txt_yapilacakis5.Text == "" || txt_aciklama5.Text == "" || cmb_durum5.Text == "")
                    {
                        if (txt_yapilacakis5.Text == "" && txt_aciklama5.Text == "" && cmb_durum5.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("5.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                        }

                    }
                    else if (txt_yapilacakis5.Text != "" && txt_aciklama5.Text != "" && cmb_durum5.Text != "")
                    {
                        con.Open();
                        SqlCommand komut7 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//bilgileri iş tablosuna ekliyoruz.,,,,
                        komut7.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis5.Text);
                        komut7.Parameters.AddWithValue("@aciklamaa", txt_aciklama5.Text);
                        komut7.Parameters.AddWithValue("@durum", cmb_durum5.Text);
                        komut7.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut7.ExecuteNonQuery();
                        con.Close();
                    }
                    //
                    if (txt_yapilacakis6.Text == "" || txt_aciklama6.Text == "" || cmb_durum6.Text == "")
                    {
                        if (txt_yapilacakis6.Text == "" && txt_aciklama6.Text == "" && cmb_durum6.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("6.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                        }

                    }
                    else if (txt_yapilacakis6.Text != "" && txt_aciklama6.Text != "" && cmb_durum6.Text != "")
                    {
                        con.Open();
                        SqlCommand komut8 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con);//bilgileri iş tablosuna ekliyoruz.,,,,,,,,,
                        komut8.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis6.Text);
                        komut8.Parameters.AddWithValue("@aciklamaa", txt_aciklama6.Text);
                        komut8.Parameters.AddWithValue("@durum", cmb_durum6.Text);
                        komut8.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut8.ExecuteNonQuery();
                        con.Close();
                    }
                    //
                    if (txt_yapilacakis7.Text == "" || txt_aciklama7.Text == "" || cmb_durum7.Text == "")
                    {
                        if (txt_yapilacakis7.Text == "" && txt_aciklama7.Text == "" && cmb_durum7.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("7.Satır boş bırakılan bölümlerden dolayı işleme alınmamıştır.");
                        }

                    }
                    else if (txt_yapilacakis7.Text != "" && txt_aciklama7.Text != "" && cmb_durum7.Text != "")
                    {
                        con.Open();
                        SqlCommand komut9 = new SqlCommand("insert into tbl_is(is_yapilacakis,is_yapilacakis_aciklama,is_durum,is_fk_kartno) values (@yapilacakis,@aciklamaa,@durum,@fkkartno)", con); //bilgileri iş tablosuna ekliyoruz.,,,,,,,,,,,,,,
                        komut9.Parameters.AddWithValue("@yapilacakis", txt_yapilacakis7.Text);
                        komut9.Parameters.AddWithValue("@aciklamaa", txt_aciklama7.Text);
                        komut9.Parameters.AddWithValue("@durum", cmb_durum7.Text);
                        komut9.Parameters.AddWithValue("@fkkartno", txt_kartno.Text);
                        komut9.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Proje kaydı tamamlandı");
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                    IsleriGoruntule tb2 = new IsleriGoruntule();
                    tb2.Show();
                    this.Hide();


                }
            }


            catch (Exception)
            {

                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                con.Close();

            }

                
        }
    }
}
