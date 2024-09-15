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

namespace Tejuu_Assignment_No2
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Vishal;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Login_details where Username = @Unm And Password = @Pwd";

            Cmd.Parameters.Add("@Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Success", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared__Content.Uname = tb_Username.Text;

                frm_Main_Form1 Obj = new frm_Main_Form1();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "RE-ENTER DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lbl_Error.Text = "Incorrect Username Or Password!!!";
                lbl_Error.ForeColor = Color.OrangeRed;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            Con_Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}

