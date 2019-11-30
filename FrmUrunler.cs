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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            int x = 30, y = 10, width = 150, height = 150, i = 1;            
            y += width + 10;

            SQLiteConnection con = new SQLiteConnection(@"data source= D:\beek\BEEK\BeekDB.db");//connection
            con.Open();
            string query = "SELECT * FROM Urunler"; //Sql sorgusu(ürünler listelenir)
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            //adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            while (dr.Read())
            {
                PictureBox picture = new PictureBox();
                picture.SetBounds(x, y, width, height);//location ve size belirleme
                this.Controls.Add(picture);
                picture.Image = Image.FromFile(dr["Resim"].ToString());
                picture.SizeMode = PictureBoxSizeMode.StretchImage;


                Label lbl = new Label();
                lbl.Top = y + 160;

                lbl.Left = x;
                lbl.Width = 100;
                lbl.Text = "Fiyat: " + dr["Fiyat"].ToString();
               
                this.Controls.Add(lbl);


                Label lbl2 = new Label ();
                lbl2.Text = "ADET: ";
                lbl2.Location = new Point(x,y+188);
                lbl2.Height = 35;
                lbl2.Width = 40;
               
                this.Controls.Add(lbl2);


                MaskedTextBox txt = new MaskedTextBox();
                Point yer = new Point(x+40, y+188);
                txt.Name ="txt" + i.ToString();
                txt.Location = yer;
                txt.Width = 35;
                txt.Height = 25;
                txt.Mask = "";
                this.Controls.Add(txt);
                i++;
                x += width + 10;

                
                    Button btn = new Button();
                    btn.Name ="btn"+ i.ToString();
                btn.Text = "SEPETE EKLE";
                    btn.Width = 90;
                    btn.Height =40;
                  btn.Location = new Point(x-167, y+227);
                this.Controls.Add(btn); 
                

            }


            con.Close();

        }
    }
}