using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tejuu_Assignment_No2
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "t" && tb_Password.Text == "t")
            {
                MessageBox.Show("Login Succesful", "Welcome");

                frm_Add_New_Student ANS = new frm_Add_New_Student();
                ANS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed,Enter Correct Username Password", "Failure");
            }

            tb_Username.Clear();
            tb_Password.Clear();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

    }
}

