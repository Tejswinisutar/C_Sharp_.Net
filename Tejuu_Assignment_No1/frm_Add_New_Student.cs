﻿using System;
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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Vishal;Initial Catalog=Student_Management_System_DB;Integrated Security=True");
        void con_open()
        {
            if (con.State != ConnectionState.Open)

            {
                con.Open();
            }

        }
        void con_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        void clear_Fields()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "02-12-2003";
            cmb_Course.SelectedIndex = -1;
        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //Clear_Fields();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con_open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "") 
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Insert Into Student_Details values (@RNo,@Nm,@MNo,@Dob,@Course)";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully...");
                clear_Fields();
            }
            
            else
            {
                MessageBox.Show("Incomplete Data");
            }
            con_Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to Logout", "Warning", MessageBoxButtons.YesNo);
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
