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
    public partial class Islemler : Form
    {
        SQLiteConnection baglanti;
        SQLiteCommand komut;
        SQLiteDataAdapter da;


        public Islemler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");
            string sorgu = "DELETE FROM Urunler WHERE No=@No";
            komut = new SQLiteCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@No", Convert.ToInt32(textBox6.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            urungetir();

        }

        private void Islemler_Load(object sender, EventArgs e)
        {
            
        }
        void urungetir()
        {
            baglanti = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");
            baglanti.Open();
            da = new SQLiteDataAdapter("SELECT * FROM Urunler",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urungetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");
            string sorgu = "INSERT INTO Urunler(Ad,Adet,Fiyat,KategoriNo,Resim) VALUES(@Ad,@Adet,@Fiyat,@KategoriNo,@Resim)";
            komut = new SQLiteCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Adet", textBox2.Text);
            komut.Parameters.AddWithValue("@Fiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@KategoriNo", comboBox1.Text);
            komut.Parameters.AddWithValue("@Resim", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            urungetir();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");
            string sorgu = "Update Urunler SET Ad=@Ad,Adet=@Adet,Fiyat=@Fiyat,KategoriNo=@KategoriNo,Resim=@Resim WHERE No=@No"; 
            komut= new SQLiteCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@No", Convert.ToInt32(textBox6.Text));
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Adet", textBox2.Text);
            komut.Parameters.AddWithValue("@Fiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@KategoriNo", comboBox1.Text);
            komut.Parameters.AddWithValue("@Resim", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            urungetir();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");
            baglanti.Open();
            string sorgu = "SELECT*FROM Urunler WHERE Ad = '" + textBox7.Text + "'";

            da = new SQLiteDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }
    }
}
