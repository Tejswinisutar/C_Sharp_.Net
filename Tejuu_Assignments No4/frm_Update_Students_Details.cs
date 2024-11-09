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
    public partial class frm_Update_Students_Details : Form
    {
        public frm_Update_Students_Details()
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "01/06/2007";
        }

        void Enable_Controls()
        {
            tb_Roll_No.Enabled = false;
            tb_Name.Enabled = true;
            dtp_DOB.Enabled = true;
            tb_Mobile_No.Enabled = true;
            cmb_Course.Enabled = true;
        }

        void Disable_Controls()
        {
            tb_Roll_No.Enabled = true;
            tb_Name.Enabled = false;
            dtp_DOB.Enabled = false;
            tb_Mobile_No.Enabled = false;
            cmb_Course.Enabled = false;
        }



        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Update_Students_Details_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Update Student_Details Set Name = @Nm, Date_of_birth = @DOB, Mobile_No = @Mob_No, Course = @Course Where Roll_No = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Mob_No", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Student_Details where Roll_No = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    dtp_DOB.Text = (Dr["Date_of_birth"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Student Found With Given Roll No", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("1st Enter Roll No.", "Incomlete Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Con_Close();
        }

    }
}
