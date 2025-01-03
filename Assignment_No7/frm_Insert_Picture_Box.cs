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

namespace Assignment_No7
{
    public partial class frm_Picture_Box : Form
    {
        public frm_Picture_Box()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Vishal;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        void Con_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Image_Id.Clear();
            tb_Image_Desricption.Clear();
            pb_Image.Image = null;
        }

        private void frm_Picture_Box_Load(object sender, EventArgs e)
        {

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Image_Id.Text != "" && tb_Image_Desricption.Text != "" && pb_Image.Image != null)
            {
                SqlCommand cmd = new SqlCommand("Insert Into Nature_Images Values (@ID, @Image, @Img_Details) ", con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Image_Id.Text;
                cmd.Parameters.Add("@Img_Details", SqlDbType.NVarChar).Value = tb_Image_Desricption.Text;

                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }

            Con_Close();
        }

        private void tb_Image_Desricption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
