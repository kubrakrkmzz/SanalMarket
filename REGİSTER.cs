using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEEK
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            cbGender.SelectedIndex = 0;

        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {

            lblMessage.Text = "";
            string name = tbName.Text.Trim();
            string surname = tbSurname.Text.Trim();
            string adress = tbAdress.Text.Trim();
            string phoneNumber = mtbPhoneNumber.Text.Trim();
            string email = tbEmail1.Text.Trim();
            string password = tbPassword1.Text.Trim();


            //validation=onaylama

            if (name == "")
            {
                lblMessage.Text = "Please enter your name.";
                return;
            }

            if (surname == "")
            {
                lblMessage.Text = "Please enter your surname.";
                return;
            }

            if (adress == "")
            {
                lblMessage.Text = "Please enter your adress.";
                return;
            }

            if (phoneNumber == "")
            {
                lblMessage.Text = "Please enter your phone number.";
                return;
            }

            if (email == "")
            {
                lblMessage.Text = "Please enter your email.";
                return;
            }


            if (email.IndexOf("@") < 0)
            {
                lblMessage.Text = "Please enter a correct email.";
                return;
            }

            if (password == "")
            {
                lblMessage.Text = "Please enter your password.";
                return;
            }
           
        }
    }
}
