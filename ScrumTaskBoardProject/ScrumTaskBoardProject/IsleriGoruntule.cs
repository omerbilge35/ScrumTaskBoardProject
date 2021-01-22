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
    public partial class IsleriGoruntule : MetroFramework.Forms.MetroForm
    {
        public IsleriGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R5P3ANL\\SQLEXPRESS;Initial Catalog=ScrumTaskBoardProject2;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut,komut2;

        static public string a, b, c, d, ee, f, g, h,j;

        private void btn_islerdenarayuzedon_Click_1(object sender, EventArgs e)
        {
            Arayuz ayu = new Arayuz();
            ayu.Show();
            this.Hide();
        }

        static public bool buton = false;
        static public bool taskbuton = false;
        
        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            buton = true;
            try

            {
                
                a = dataGridView1.CurrentRow.Cells["proje_kartno"].Value.ToString(); // verilere TeknikKart formunda ulaşabilmek için public static oluşturduğumuz değişkenlere aktarıyoruz.
                b = dataGridView1.CurrentRow.Cells["proje_projeadi"].Value.ToString();
                c = dataGridView1.CurrentRow.Cells["proje_tahminisure"].Value.ToString();
                ee = dataGridView1.CurrentRow.Cells["proje_aciklama"].Value.ToString();
                f = dataGridView1.CurrentRow.Cells["proje_notlar"].Value.ToString();
                g = dataGridView1.CurrentRow.Cells["proje_fk_uyeid"].Value.ToString();
                h = dataGridView1.CurrentRow.Cells["proje_uzman"].Value.ToString();
                j = dataGridView1.CurrentRow.Cells["proje_tarih"].Value.ToString(); 

                

                TeknikKart tkk = new TeknikKart();
                tkk.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir iş seçiniz!");
                
            }
            
        }

        private void btn_taskboardduzenle_Click(object sender, EventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells["proje_kartno"].Value.ToString();
            taskbuton = true;
            TaskBoard tbg = new TaskBoard();
            tbg.Show();
            this.Hide();
            TaskBoard.buton1.Visible = true;
        }
        void KayıtSil(int kartid)
        {
            con.Open();
            string tasksil = "DELETE FROM tbl_is WHERE is_fk_kartno=@fkkartno"; //iş tablosundaki verileri seçilen idye göre siliyoruz.
            komut2 = new SqlCommand(tasksil, con);
            komut2.Parameters.AddWithValue("@fkkartno", kartid);
            komut2.ExecuteNonQuery();
            con.Close();
            con.Open();
            string sql = "DELETE FROM tbl_proje WHERE proje_kartno=@kartno";
            komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@kartno", kartid);
            
            komut.ExecuteNonQuery();
            con.Close();
        }

        void griddoldur()
        {
            txt_kartnoajani.Text = Form1.u.Text;
            con.Open();
            string kayit = "SELECT * from tbl_proje where proje_fk_uyeid=@uyeid"; //üye idye göre proje tablosundaki verilere ulaşıyoruz.

            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@uyeid", txt_kartnoajani.Text);


            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void IsleriGoruntule_Load(object sender, EventArgs e)
        {

            griddoldur();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  
            {
                int kartid = Convert.ToInt32(drow.Cells["proje_kartno"].Value);
                KayıtSil(kartid);
            }
            griddoldur();
        }
    }
}
