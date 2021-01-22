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
    public partial class Arayuz : MetroFramework.Forms.MetroForm
    {
        public Arayuz()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R5P3ANL\\SQLEXPRESS;Initial Catalog=ScrumTaskBoardProject2;Integrated Security=True");


        private void btn_yeniisolustur_Click_1(object sender, EventArgs e)
        {
            TeknikKart tk = new TeknikKart();
            tk.Show();
            this.Hide(); //yeni iş oluştur butonu ile birlikte teknik kart forumuna yönlendirdik.
        }

        private void btn_oncekiislerigoruntule_Click_1(object sender, EventArgs e)
        {
            IsleriGoruntule iss = new IsleriGoruntule();
            iss.Show();
            this.Hide(); //önceki işleri görüntüle butonu ile İşleri görüntüle formuna yönlendirdik.
        }

        private void btn_geriii_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide(); // geri butonu ile giriş yapılan ekrana yönlendirdik.
        }

        private void Arayuz_Load(object sender, EventArgs e)
        {

        }

        
    }
}
