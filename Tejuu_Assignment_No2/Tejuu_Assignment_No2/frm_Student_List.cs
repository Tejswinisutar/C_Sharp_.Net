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
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_Student_by_Roll_No obj = new frm_Search_Student_by_Roll_No();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared__Content.Uname;
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet2.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_System_DBDataSet2.Student_Details);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
