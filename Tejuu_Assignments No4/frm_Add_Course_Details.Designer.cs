
namespace Tejuu_Assignment_No2
{
    partial class frm_Add_Course_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.tb_Course_Id = new System.Windows.Forms.TextBox();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.lbl_Course_Id = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(374, 89);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(842, 103);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "Add Course Details";
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(906, 524);
            this.tb_Course_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Course_Name.MaxLength = 20;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(483, 55);
            this.tb_Course_Name.TabIndex = 2;
            // 
            // tb_Course_Id
            // 
            this.tb_Course_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Id.Location = new System.Drawing.Point(906, 319);
            this.tb_Course_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Course_Id.MaxLength = 4;
            this.tb_Course_Id.Name = "tb_Course_Id";
            this.tb_Course_Id.Size = new System.Drawing.Size(483, 55);
            this.tb_Course_Id.TabIndex = 1;
            this.tb_Course_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.Location = new System.Drawing.Point(240, 528);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(295, 51);
            this.lbl_Course_Name.TabIndex = 17;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // lbl_Course_Id
            // 
            this.lbl_Course_Id.AutoSize = true;
            this.lbl_Course_Id.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Course_Id.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Id.Location = new System.Drawing.Point(240, 319);
            this.lbl_Course_Id.Name = "lbl_Course_Id";
            this.lbl_Course_Id.Size = new System.Drawing.Size(223, 51);
            this.lbl_Course_Id.TabIndex = 16;
            this.lbl_Course_Id.Text = "Course Id";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(881, 784);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(224, 92);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(417, 776);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(257, 100);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // frm_Add_Course_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 1095);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_Id);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_Id);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Add_Course_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Course_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Course_Details_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_Id;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Label lbl_Course_Id;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
    }
}