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
    public partial class frm_Main_Form1 : Form
    {
        public frm_Main_Form1()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.MdiParent = this;
            obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_by_Roll_No obj = new frm_Search_Student_by_Roll_No();
            obj.MdiParent = this;
            obj.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.MdiParent = this;
            obj.Show();
        }

        private void upadeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to Logout", "Warning", MessageBoxButtons.YesNo);
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Form1_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared__Content.Uname;
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
