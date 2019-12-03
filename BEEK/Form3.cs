using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BEEK
{
    public partial class Siparis : Form
    {
        SQLiteConnection baglanti;
        // SQLiteCommand komut;
        SQLiteDataAdapter da;

        public Siparis()
        {
            InitializeComponent();
        }

        void siparisgetir()
        {
            baglanti = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");
            baglanti.Open();
            da = new SQLiteDataAdapter("SELECT * FROM Siparisler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Siparis_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            siparisgetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");
            baglanti.Open();
            string sorgu = "SELECT*FROM Siparisler WHERE SiparisTarihi = '" + textBox1.Text + "'";
            da = new SQLiteDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

    }
}