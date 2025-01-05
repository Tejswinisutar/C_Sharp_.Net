using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_No9
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_Main_Form Obj = new frm_Main_Form();
            Obj.Show();
            this.Hide();

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            cmb_User_Role.SelectedIndex = 0;
            cmb_User_Name.Text = "Tejswini";

            tb_Password.Focus();

        }
    }
}
