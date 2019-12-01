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
    public partial class BEEK : Form
    {
        Register r = null;

        public BEEK()
        {
            InitializeComponent();

        }

   

        private void btnLogIn_Click(object sender, EventArgs e)
        {
           
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                r = new Register();
            }
            r.Show();

        }

        private void rünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void indirimÇekleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islemler islem = new Islemler ();
            islem.Show();
        }

        private void BEEK_Load(object sender, EventArgs e)
        {

        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn1_Click(object sender, EventArgs e)
        {
            FrmUrunler frmurunler = new FrmUrunler();
            frmurunler.Show();                                                            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
