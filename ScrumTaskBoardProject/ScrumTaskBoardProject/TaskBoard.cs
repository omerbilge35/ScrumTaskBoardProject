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
using System.Collections;

namespace ScrumTaskBoardProject
{
    public partial class TaskBoard : MetroFramework.Forms.MetroForm
    {
        public TaskBoard()
        {
            InitializeComponent();
            Yapilacak.AllowDrop = true;
            Yapiliyor.AllowDrop = true;
            Duzenleme.AllowDrop = true;
            Kontrol.AllowDrop = true;
            Bitti.AllowDrop = true;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R5P3ANL\\SQLEXPRESS;Initial Catalog=ScrumTaskBoardProject2;Integrated Security=True");
        int isgetirdongu = 0;

        public static Button buton1;
            public static Button buton2;
        string veri1, veri2, veri3, veri4, veri5, veri6, veri7;
        private void btn_teknikkartgeri_Click(object sender, EventArgs e)
        {
            TeknikKart tg = new TeknikKart();
            tg.Show();
            this.Hide();
        }

        private void btn_islerigosteregerigit_Click(object sender, EventArgs e)
        {
            IsleriGoruntule igb = new IsleriGoruntule();
            igb.Show();
            this.Hide();
        }

        private void TaskBoard_Load(object sender, EventArgs e)
        {
            if (IsleriGoruntule.taskbuton == true)
            {
                txt_isleritaskboardaat.Text = IsleriGoruntule.a;
                con.Open();
                string giris = "Select * from tbl_is where is_fk_kartno=@fkkartno"; //kartno ya göre iş tablosundaki verilere ulaşıyoruz.

                SqlCommand komut = new SqlCommand(giris, con);
                komut.Parameters.AddWithValue("@fkkartno", txt_isleritaskboardaat.Text); //kartno değişkenini textboxtan çekiyoruz.
                SqlDataAdapter d = new SqlDataAdapter(komut);
                SqlDataReader r = komut.ExecuteReader();
                while (r.Read()) //while’i tüm öğeleri seçmek için kullandık.
                {
                    if (isgetirdongu == 0)
                    {
                        txt_taskboardisid1.Text = r["is_id"].ToString();
                        isgetirdongu++;
                    }
                    else if (isgetirdongu == 1)
                    {
                        txt_taskboardisid2.Text = r["is_id"].ToString();
                        isgetirdongu++;
                    }
                    else if (isgetirdongu == 2)
                    {
                        txt_taskboardisid3.Text = r["is_id"].ToString();
                        isgetirdongu++;
                    }

                    else if (isgetirdongu == 3)
                    {
                        txt_taskboardisid4.Text = r["is_id"].ToString();
                        isgetirdongu++;
                    }
                    else if (isgetirdongu == 4)
                    {
                        txt_taskboardisid5.Text = r["is_id"].ToString();
                        isgetirdongu++;
                    }
                    else if (isgetirdongu == 5)
                    {
                        txt_taskboardisid6.Text = r["is_id"].ToString();
                        isgetirdongu++;
                    }
                    else if (isgetirdongu == 6)
                    {
                        txt_taskboardisid7.Text = r["is_id"].ToString();
                        isgetirdongu++;
                    }


                    if (Convert.ToString(r["is_durum"]) == "Yapilacak")
                    {
                        Yapilacak.Items.Add(r["is_yapilacakis"]); //verileri listboxa ekliyoruz .
                    }
                    else if (Convert.ToString(r["is_durum"]) == "Yapiliyor")
                    {
                        Yapiliyor.Items.Add(r["is_yapilacakis"]); //verileri listboxa ekliyoruz .
                    }
                    else if (Convert.ToString(r["is_durum"]) == "Duzenleme")
                    {
                        Duzenleme.Items.Add(r["is_yapilacakis"]); //verileri listboxa ekliyoruz .
                    }
                    else if (Convert.ToString(r["is_durum"]) == "Kontrol")
                    {
                        Kontrol.Items.Add(r["is_yapilacakis"]); //verileri listboxa ekliyoruz .
                    }
                    else if (Convert.ToString(r["is_durum"]) == "Bitti")
                    {
                        Bitti.Items.Add(r["is_yapilacakis"]); //verileri listboxa ekliyoruz .
                    }

                }
                con.Close(); // en son bağlantıyı kapatıyoruz.
            }

            
            buton1 = btn_islerigosteregerigit;
            buton2 = btn_teknikkartgeri;

            
        }

        private void btn_taskboardkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_taskboardisid1.Text != "")
                {
                    con.Open();
                    SqlCommand verioku = new SqlCommand("select is_yapilacakis from tbl_is where is_id=@isid", con); //iş idsine göre iş tablosundaki yapılacak iş verilerine ulaşıyoruz.
                    verioku.Parameters.AddWithValue("@isid", txt_taskboardisid1.Text); //iş id değişkenini textboxtan çekiyoruz.

                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        veri1 = oku["is_yapilacakis"].ToString(); //iş tablosundaki ilk kayıdın idsini veri1 değişkenine atıyoruz
                    }
                    con.Close();
                    string[] veriler1 = new string[Yapilacak.Items.Count];
                    for (int i = 0; i < Yapilacak.Items.Count; i++)
                    {
                        veriler1[i] = Yapilacak.Items[i].ToString();
                        if (veriler1[i] == veri1)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapilacak' where is_id=@isid", con);// iş tablosundaki veriyi, veri1 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid1.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler2 = new string[Yapiliyor.Items.Count];
                    for (int i = 0; i < Yapiliyor.Items.Count; i++)
                    {
                        veriler2[i] = Yapiliyor.Items[i].ToString();
                        if (veriler2[i] == veri1)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapiliyor' where is_id=@isid", con); // iş tablosundaki veriyi, veri1 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid1.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler3 = new string[Duzenleme.Items.Count];
                    for (int i = 0; i < Duzenleme.Items.Count; i++)
                    {
                        veriler3[i] = Duzenleme.Items[i].ToString();
                        if (veriler3[i] == veri1)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Duzenleme' where is_id=@isid", con);// iş tablosundaki veriyi, veri1 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid1.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler4 = new string[Kontrol.Items.Count];
                    for (int i = 0; i < Kontrol.Items.Count; i++)
                    {
                        veriler4[i] = Kontrol.Items[i].ToString();
                        if (veriler4[i] == veri1)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Kontrol' where is_id=@isid", con);// iş tablosundaki veriyi, veri1 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid1.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler5 = new string[Bitti.Items.Count];
                    for (int i = 0; i < Bitti.Items.Count; i++)
                    {
                        veriler5[i] = Bitti.Items[i].ToString();
                        if (veriler5[i] == veri1)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Bitti' where is_id=@isid", con);// iş tablosundaki veriyi, veri1 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid1.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                ///////////veri2
                if (txt_taskboardisid2.Text != "")
                {
                    con.Open();
                    SqlCommand verioku = new SqlCommand("select is_yapilacakis from tbl_is where is_id=@isid", con);// iş tablosundaki veriyi, veri2 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                    verioku.Parameters.AddWithValue("@isid", txt_taskboardisid2.Text);

                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        veri2 = oku["is_yapilacakis"].ToString();
                    }
                    con.Close();
                    string[] veriler1 = new string[Yapilacak.Items.Count];
                    for (int i = 0; i < Yapilacak.Items.Count; i++)
                    {
                        veriler1[i] = Yapilacak.Items[i].ToString();
                        if (veriler1[i] == veri2)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapilacak' where is_id=@isid", con);// iş tablosundaki veriyi, veri2 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid2.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler2 = new string[Yapiliyor.Items.Count];
                    for (int i = 0; i < Yapiliyor.Items.Count; i++)
                    {
                        veriler2[i] = Yapiliyor.Items[i].ToString();
                        if (veriler2[i] == veri2)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapiliyor' where is_id=@isid", con);// iş tablosundaki veriyi, veri2 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid2.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler3 = new string[Duzenleme.Items.Count];
                    for (int i = 0; i < Duzenleme.Items.Count; i++)
                    {
                        veriler3[i] = Duzenleme.Items[i].ToString();
                        if (veriler3[i] == veri2)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Duzenleme' where is_id=@isid", con);// iş tablosundaki veriyi, veri2 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid2.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler4 = new string[Kontrol.Items.Count];
                    for (int i = 0; i < Kontrol.Items.Count; i++)
                    {
                        veriler4[i] = Kontrol.Items[i].ToString();
                        if (veriler4[i] == veri2)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Kontrol' where is_id=@isid", con);// iş tablosundaki veriyi, veri2 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid2.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler5 = new string[Bitti.Items.Count];
                    for (int i = 0; i < Bitti.Items.Count; i++)
                    {
                        veriler5[i] = Bitti.Items[i].ToString();
                        if (veriler5[i] == veri2)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Bitti' where is_id=@isid", con);// iş tablosundaki veriyi, veri2 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid2.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                ///veri3
                if (txt_taskboardisid3.Text != "")
                {
                    con.Open();
                    SqlCommand verioku = new SqlCommand("select is_yapilacakis from tbl_is where is_id=@isid", con);// iş tablosundaki veriyi, veri3 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                    verioku.Parameters.AddWithValue("@isid", txt_taskboardisid3.Text);

                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        veri3 = oku["is_yapilacakis"].ToString();
                    }
                    con.Close();
                    string[] veriler1 = new string[Yapilacak.Items.Count];
                    for (int i = 0; i < Yapilacak.Items.Count; i++)
                    {
                        veriler1[i] = Yapilacak.Items[i].ToString();
                        if (veriler1[i] == veri3)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapilacak' where is_id=@isid", con);// iş tablosundaki veriyi, veri3 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid3.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler2 = new string[Yapiliyor.Items.Count];
                    for (int i = 0; i < Yapiliyor.Items.Count; i++)
                    {
                        veriler2[i] = Yapiliyor.Items[i].ToString();
                        if (veriler2[i] == veri3)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapiliyor' where is_id=@isid", con);// iş tablosundaki veriyi, veri3 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid3.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler3 = new string[Duzenleme.Items.Count];
                    for (int i = 0; i < Duzenleme.Items.Count; i++)
                    {
                        veriler3[i] = Duzenleme.Items[i].ToString();
                        if (veriler3[i] == veri3)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Duzenleme' where is_id=@isid", con);// iş tablosundaki veriyi, veri3 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid3.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler4 = new string[Kontrol.Items.Count];
                    for (int i = 0; i < Kontrol.Items.Count; i++)
                    {
                        veriler4[i] = Kontrol.Items[i].ToString();
                        if (veriler4[i] == veri3)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Kontrol' where is_id=@isid", con);// iş tablosundaki veriyi, veri3 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid3.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler5 = new string[Bitti.Items.Count];
                    for (int i = 0; i < Bitti.Items.Count; i++)
                    {
                        veriler5[i] = Bitti.Items[i].ToString();
                        if (veriler5[i] == veri3)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Bitti' where is_id=@isid", con);// iş tablosundaki veriyi, veri3 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid3.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                ///veri4
                if (txt_taskboardisid4.Text != "")
                {
                    con.Open();
                    SqlCommand verioku = new SqlCommand("select is_yapilacakis from tbl_is where is_id=@isid", con);// iş tablosundaki veriyi, veri4 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                    verioku.Parameters.AddWithValue("@isid", txt_taskboardisid4.Text);

                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        veri4 = oku["is_yapilacakis"].ToString();
                    }
                    con.Close();
                    string[] veriler1 = new string[Yapilacak.Items.Count];
                    for (int i = 0; i < Yapilacak.Items.Count; i++)
                    {
                        veriler1[i] = Yapilacak.Items[i].ToString();
                        if (veriler1[i] == veri4)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapilacak' where is_id=@isid", con);// iş tablosundaki veriyi, veri4 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid4.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler2 = new string[Yapiliyor.Items.Count];
                    for (int i = 0; i < Yapiliyor.Items.Count; i++)
                    {
                        veriler2[i] = Yapiliyor.Items[i].ToString();
                        if (veriler2[i] == veri4)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapiliyor' where is_id=@isid", con);// iş tablosundaki veriyi, veri4 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid4.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler3 = new string[Duzenleme.Items.Count];
                    for (int i = 0; i < Duzenleme.Items.Count; i++)
                    {
                        veriler3[i] = Duzenleme.Items[i].ToString();
                        if (veriler3[i] == veri4)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Duzenleme' where is_id=@isid", con);// iş tablosundaki veriyi, veri4 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid4.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler4 = new string[Kontrol.Items.Count];
                    for (int i = 0; i < Kontrol.Items.Count; i++)
                    {
                        veriler4[i] = Kontrol.Items[i].ToString();
                        if (veriler4[i] == veri4)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Kontrol' where is_id=@isid", con);// iş tablosundaki veriyi, veri4 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid4.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler5 = new string[Bitti.Items.Count];
                    for (int i = 0; i < Bitti.Items.Count; i++)
                    {
                        veriler5[i] = Bitti.Items[i].ToString();
                        if (veriler5[i] == veri4)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Bitti' where is_id=@isid", con);// iş tablosundaki veriyi, veri4 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid4.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                //veri5
                if (txt_taskboardisid5.Text != "")
                {
                    con.Open();
                    SqlCommand verioku = new SqlCommand("select is_yapilacakis from tbl_is where is_id=@isid", con);// iş tablosundaki veriyi, veri5 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                    verioku.Parameters.AddWithValue("@isid", txt_taskboardisid5.Text);

                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        veri5 = oku["is_yapilacakis"].ToString();
                    }
                    con.Close();
                    string[] veriler1 = new string[Yapilacak.Items.Count];
                    for (int i = 0; i < Yapilacak.Items.Count; i++)
                    {
                        veriler1[i] = Yapilacak.Items[i].ToString();
                        if (veriler1[i] == veri5)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapilacak' where is_id=@isid", con); // iş tablosundaki veriyi, veri5 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid5.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler2 = new string[Yapiliyor.Items.Count];
                    for (int i = 0; i < Yapiliyor.Items.Count; i++)
                    {
                        veriler2[i] = Yapiliyor.Items[i].ToString();
                        if (veriler2[i] == veri5)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapiliyor' where is_id=@isid", con);// iş tablosundaki veriyi, veri5 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid5.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler3 = new string[Duzenleme.Items.Count];
                    for (int i = 0; i < Duzenleme.Items.Count; i++)
                    {
                        veriler3[i] = Duzenleme.Items[i].ToString();
                        if (veriler3[i] == veri5)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Duzenleme' where is_id=@isid", con);// iş tablosundaki veriyi, veri5 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid5.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler4 = new string[Kontrol.Items.Count];
                    for (int i = 0; i < Kontrol.Items.Count; i++)
                    {
                        veriler4[i] = Kontrol.Items[i].ToString();
                        if (veriler4[i] == veri5)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Kontrol' where is_id=@isid", con);// iş tablosundaki veriyi, veri5 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid5.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler5 = new string[Bitti.Items.Count];
                    for (int i = 0; i < Bitti.Items.Count; i++)
                    {
                        veriler5[i] = Bitti.Items[i].ToString();
                        if (veriler5[i] == veri5)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Bitti' where is_id=@isid", con);// iş tablosundaki veriyi, veri5 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid5.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                //veri6
                if (txt_taskboardisid6.Text != "")
                {
                    con.Open();
                    SqlCommand verioku = new SqlCommand("select is_yapilacakis from tbl_is where is_id=@isid", con);// iş tablosundaki veriyi, veri6 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                    verioku.Parameters.AddWithValue("@isid", txt_taskboardisid6.Text);

                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        veri6 = oku["is_yapilacakis"].ToString();
                    }
                    con.Close();
                    string[] veriler1 = new string[Yapilacak.Items.Count];
                    for (int i = 0; i < Yapilacak.Items.Count; i++)
                    {
                        veriler1[i] = Yapilacak.Items[i].ToString();
                        if (veriler1[i] == veri6)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapilacak' where is_id=@isid", con);// iş tablosundaki veriyi, veri6 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid6.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler2 = new string[Yapiliyor.Items.Count];
                    for (int i = 0; i < Yapiliyor.Items.Count; i++)
                    {
                        veriler2[i] = Yapiliyor.Items[i].ToString();
                        if (veriler2[i] == veri6)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapiliyor' where is_id=@isid", con);// iş tablosundaki veriyi, veri6 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid6.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler3 = new string[Duzenleme.Items.Count];
                    for (int i = 0; i < Duzenleme.Items.Count; i++)
                    {
                        veriler3[i] = Duzenleme.Items[i].ToString();
                        if (veriler3[i] == veri6)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Duzenleme' where is_id=@isid", con);// iş tablosundaki veriyi, veri6 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid6.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler4 = new string[Kontrol.Items.Count];
                    for (int i = 0; i < Kontrol.Items.Count; i++)
                    {
                        veriler4[i] = Kontrol.Items[i].ToString();
                        if (veriler4[i] == veri6)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Kontrol' where is_id=@isid", con);// iş tablosundaki veriyi, veri6 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid6.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler5 = new string[Bitti.Items.Count];
                    for (int i = 0; i < Bitti.Items.Count; i++)
                    {
                        veriler5[i] = Bitti.Items[i].ToString();
                        if (veriler5[i] == veri6)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Bitti' where is_id=@isid", con);// iş tablosundaki veriyi, veri6 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid6.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                //veri7
                if (txt_taskboardisid7.Text != "")
                {
                    con.Open();
                    SqlCommand verioku = new SqlCommand("select is_yapilacakis from tbl_is where is_id=@isid", con);// iş tablosundaki veriyi, veri7 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                    verioku.Parameters.AddWithValue("@isid", txt_taskboardisid7.Text);

                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        veri7 = oku["is_yapilacakis"].ToString();
                    }
                    con.Close();
                    string[] veriler1 = new string[Yapilacak.Items.Count];
                    for (int i = 0; i < Yapilacak.Items.Count; i++)
                    {
                        veriler1[i] = Yapilacak.Items[i].ToString();
                        if (veriler1[i] == veri7)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapilacak' where is_id=@isid", con);// iş tablosundaki veriyi, veri7 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid7.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler2 = new string[Yapiliyor.Items.Count];
                    for (int i = 0; i < Yapiliyor.Items.Count; i++)
                    {
                        veriler2[i] = Yapiliyor.Items[i].ToString();
                        if (veriler2[i] == veri7)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Yapiliyor' where is_id=@isid", con);// iş tablosundaki veriyi, veri7 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid7.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    ///////
                    string[] veriler3 = new string[Duzenleme.Items.Count];
                    for (int i = 0; i < Duzenleme.Items.Count; i++)
                    {
                        veriler3[i] = Duzenleme.Items[i].ToString();
                        if (veriler3[i] == veri7)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Duzenleme' where is_id=@isid", con);// iş tablosundaki veriyi, veri7 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid7.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler4 = new string[Kontrol.Items.Count];
                    for (int i = 0; i < Kontrol.Items.Count; i++)
                    {
                        veriler4[i] = Kontrol.Items[i].ToString();
                        if (veriler4[i] == veri7)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Kontrol' where is_id=@isid", con);// iş tablosundaki veriyi, veri7 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid7.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    string[] veriler5 = new string[Bitti.Items.Count];
                    for (int i = 0; i < Bitti.Items.Count; i++)
                    {
                        veriler5[i] = Bitti.Items[i].ToString();
                        if (veriler5[i] == veri7)
                        {
                            con.Open();
                            SqlCommand verikontrol = new SqlCommand("update tbl_is set is_durum='Bitti' where is_id=@isid", con);// iş tablosundaki veriyi, veri7 sayesinde hangi listbox(yapilacak,kontrol,bitti vb) içindeyse durumunu o listboxun adı ile güncelliyoruz.
                            verikontrol.Parameters.AddWithValue("@isid", txt_taskboardisid7.Text);
                            verikontrol.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                MessageBox.Show("Değişiklikleriniz başarıyla kaydedilmiştir.");
                IsleriGoruntule isggit = new IsleriGoruntule();
                isggit.Show();
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Değişiklikleri kaydederken bir sorunla karşılaşıldı.");
            }
           
        }




        private void Yapilacak_MouseDown(object sender, MouseEventArgs e)
        {
            if (Yapilacak.SelectedItem != null)
            {
                Yapiliyor.DoDragDrop(Yapilacak.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Yapilacak.SelectedItem != null)
            {
                Bitti.DoDragDrop(Yapilacak.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Yapilacak.SelectedItem != null)
            {
                Duzenleme.DoDragDrop(Yapilacak.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Yapilacak.SelectedItem != null)
            {
                Kontrol.DoDragDrop(Yapilacak.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            
            
            
            
        }

        private void Yapiliyor_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Yapiliyor_DragDrop(object sender, DragEventArgs e)
        {
            Yapiliyor.Items.Add(e.Data.GetData(DataFormats.Text));
            Yapilacak.Items.Remove(e.Data.GetData(DataFormats.Text));
            Kontrol.Items.Remove(e.Data.GetData(DataFormats.Text));
            Duzenleme.Items.Remove(e.Data.GetData(DataFormats.Text));
            Bitti.Items.Remove(e.Data.GetData(DataFormats.Text));

            ArrayList eleman = new ArrayList(); //sonsuz dizimizi yaratıyoruz

            foreach (string item in Yapiliyor.Items) //listBox1 deki itemları tek tek dolaş ve bunların adına item de.
            {
                if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                {
                    eleman.Add(item); //sonsuz diziye itemları ekle

                }
            }
            Yapiliyor.Items.Clear(); //listBox'ı temizle
            Yapiliyor.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle

        }

        private void Yapiliyor_MouseDown(object sender, MouseEventArgs e)
        {
            if (Yapiliyor.SelectedItem != null)
            {
                Yapilacak.DoDragDrop(Yapiliyor.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Yapiliyor.SelectedItem != null)
            {
                Duzenleme.DoDragDrop(Yapiliyor.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Yapiliyor.SelectedItem != null)
            {
                Bitti.DoDragDrop(Yapiliyor.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Yapiliyor.SelectedItem != null)
            {
                Kontrol.DoDragDrop(Yapiliyor.SelectedItem.ToString(), DragDropEffects.Copy);
            }





        }

        private void Duzenleme_MouseDown(object sender, MouseEventArgs e)
        {
            if (Duzenleme.SelectedItem != null)
            {
                Yapiliyor.DoDragDrop(Duzenleme.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Duzenleme.SelectedItem != null)
            {
                Yapilacak.DoDragDrop(Duzenleme.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Duzenleme.SelectedItem != null)
            {
                Kontrol.DoDragDrop(Duzenleme.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Duzenleme.SelectedItem != null)
            {
                Bitti.DoDragDrop(Duzenleme.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            
            
            
            
        }

        private void Kontrol_MouseDown(object sender, MouseEventArgs e)
        {
            if (Kontrol.SelectedItem != null)
            {
                Yapiliyor.DoDragDrop(Kontrol.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Kontrol.SelectedItem != null)
            {
                Yapilacak.DoDragDrop(Kontrol.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Kontrol.SelectedItem != null)
            {
                Duzenleme.DoDragDrop(Kontrol.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Kontrol.SelectedItem != null)
            {
                Bitti.DoDragDrop(Kontrol.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            
            
            
            
        }

        private void Bitti_MouseDown(object sender, MouseEventArgs e)
        {
            if (Bitti.SelectedItem != null)
            {
                Yapiliyor.DoDragDrop(Bitti.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Bitti.SelectedItem != null)
            {
                Yapilacak.DoDragDrop(Bitti.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Bitti.SelectedItem != null)
            {
                Kontrol.DoDragDrop(Bitti.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            else if (Bitti.SelectedItem != null)
            {
                Duzenleme.DoDragDrop(Bitti.SelectedItem.ToString(), DragDropEffects.Copy);
            }                                          
        }

        private void Yapilacak_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Duzenleme_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Yapilacak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kontrol_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Bitti_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Yapilacak_DragDrop(object sender, DragEventArgs e)
        {
            Yapilacak.Items.Add(e.Data.GetData(DataFormats.Text));           
            Yapiliyor.Items.Remove(e.Data.GetData(DataFormats.Text));
            Duzenleme.Items.Remove(e.Data.GetData(DataFormats.Text));
            Bitti.Items.Remove(e.Data.GetData(DataFormats.Text));
            Kontrol.Items.Remove(e.Data.GetData(DataFormats.Text));
            ArrayList eleman = new ArrayList(); //sonsuz dizimizi yaratıyoruz
            
                foreach (string item in Yapilacak.Items) //listBox1 deki itemları tek tek dolaş ve bunların adına item de.
                {
                    if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                    {
                        eleman.Add(item); //sonsuz diziye itemları ekle

                    }
                }
            Yapilacak.Items.Clear(); //listBox'ı temizle
            Yapilacak.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle
            
        }

        private void Duzenleme_DragDrop(object sender, DragEventArgs e)
        {
            Duzenleme.Items.Add(e.Data.GetData(DataFormats.Text));
            Yapiliyor.Items.Remove(e.Data.GetData(DataFormats.Text));
            Yapilacak.Items.Remove(e.Data.GetData(DataFormats.Text));
            Bitti.Items.Remove(e.Data.GetData(DataFormats.Text));
            Kontrol.Items.Remove(e.Data.GetData(DataFormats.Text));
            ArrayList eleman = new ArrayList(); //sonsuz dizimizi yaratıyoruz

            foreach (string item in Duzenleme.Items) //listBox1 deki itemları tek tek dolaş ve bunların adına item de.
            {
                if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                {
                    eleman.Add(item); //sonsuz diziye itemları ekle

                }
            }
            Duzenleme.Items.Clear(); //listBox'ı temizle
            Duzenleme.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle
        }

        private void Kontrol_DragDrop(object sender, DragEventArgs e)
        {
            Kontrol.Items.Add(e.Data.GetData(DataFormats.Text));
            Yapiliyor.Items.Remove(e.Data.GetData(DataFormats.Text));
            Bitti.Items.Remove(e.Data.GetData(DataFormats.Text));
            Duzenleme.Items.Remove(e.Data.GetData(DataFormats.Text));
            Yapilacak.Items.Remove(e.Data.GetData(DataFormats.Text));

            ArrayList eleman = new ArrayList(); //sonsuz dizimizi yaratıyoruz

            foreach (string item in Kontrol.Items) //listBox1 deki itemları tek tek dolaş ve bunların adına item de.
            {
                if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                {
                    eleman.Add(item); //sonsuz diziye itemları ekle

                }
            }
            Kontrol.Items.Clear(); //listBox'ı temizle
            Kontrol.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle
        }

        private void Bitti_DragDrop(object sender, DragEventArgs e)
        {
            Bitti.Items.Add(e.Data.GetData(DataFormats.Text));
            Yapiliyor.Items.Remove(e.Data.GetData(DataFormats.Text));
            Yapilacak.Items.Remove(e.Data.GetData(DataFormats.Text));
            Kontrol.Items.Remove(e.Data.GetData(DataFormats.Text));
            Duzenleme.Items.Remove(e.Data.GetData(DataFormats.Text));

            ArrayList eleman = new ArrayList(); //sonsuz dizimizi yaratıyoruz

            foreach (string item in Bitti.Items) //listBox1 deki itemları tek tek dolaş ve bunların adına item de.
            {
                if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                {
                    eleman.Add(item); //sonsuz diziye itemları ekle

                }
            }
            Bitti.Items.Clear(); //listBox'ı temizle
            Bitti.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle
        }
    }
}
