﻿
namespace Assignment_No5
{
    partial class frm_Emplyee_Details
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.ggb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.cmb_Employee_Dept = new System.Windows.Forms.ComboBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Out = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Panel();
            this.ggb_Shift_Time.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.lbl_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(779, 836);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(243, 71);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(365, 839);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(197, 69);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.Location = new System.Drawing.Point(505, 48);
            this.rb_Night.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(96, 30);
            this.rb_Night.TabIndex = 2;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.Location = new System.Drawing.Point(292, 48);
            this.rb_Evening.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(123, 30);
            this.rb_Evening.TabIndex = 1;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Morning.Location = new System.Drawing.Point(59, 48);
            this.rb_Morning.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(127, 30);
            this.rb_Morning.TabIndex = 0;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Output.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(12, 953);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(118, 35);
            this.lbl_Output.TabIndex = 40;
            this.lbl_Output.Text = "Output";
            // 
            // ggb_Shift_Time
            // 
            this.ggb_Shift_Time.BackColor = System.Drawing.Color.White;
            this.ggb_Shift_Time.Controls.Add(this.rb_Night);
            this.ggb_Shift_Time.Controls.Add(this.rb_Evening);
            this.ggb_Shift_Time.Controls.Add(this.rb_Morning);
            this.ggb_Shift_Time.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggb_Shift_Time.Location = new System.Drawing.Point(819, 644);
            this.ggb_Shift_Time.Margin = new System.Windows.Forms.Padding(4);
            this.ggb_Shift_Time.Name = "ggb_Shift_Time";
            this.ggb_Shift_Time.Padding = new System.Windows.Forms.Padding(4);
            this.ggb_Shift_Time.Size = new System.Drawing.Size(659, 111);
            this.ggb_Shift_Time.TabIndex = 4;
            this.ggb_Shift_Time.TabStop = false;
            this.ggb_Shift_Time.Text = "Shift Time";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(328, 43);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(114, 30);
            this.rb_Female.TabIndex = 3;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(99, 43);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(88, 30);
            this.rb_Male.TabIndex = 2;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.White;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(819, 458);
            this.gb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Size = new System.Drawing.Size(561, 110);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // cmb_Employee_Dept
            // 
            this.cmb_Employee_Dept.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_Employee_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Dept.FormattingEnabled = true;
            this.cmb_Employee_Dept.Items.AddRange(new object[] {
            " HRD",
            " R&D",
            "Testing",
            "Management"});
            this.cmb_Employee_Dept.Location = new System.Drawing.Point(819, 340);
            this.cmb_Employee_Dept.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Employee_Dept.Name = "cmb_Employee_Dept";
            this.cmb_Employee_Dept.Size = new System.Drawing.Size(591, 46);
            this.cmb_Employee_Dept.TabIndex = 2;
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(819, 218);
            this.tb_Employee_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(591, 45);
            this.tb_Employee_Name.TabIndex = 1;
            this.tb_Employee_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.Location = new System.Drawing.Point(107, 630);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(216, 44);
            this.lbl_Shift_Time.TabIndex = 33;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Gender.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(107, 487);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(148, 44);
            this.lbl_Gender.TabIndex = 32;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.Location = new System.Drawing.Point(107, 342);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(418, 44);
            this.lbl_Employee_Department.TabIndex = 31;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.Location = new System.Drawing.Point(107, 203);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(308, 44);
            this.lbl_Employee_Name.TabIndex = 30;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(387, 37);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(774, 103);
            this.lbl_Header.TabIndex = 29;
            this.lbl_Header.Text = "Employee Details";
            // 
            // lbl_Out
            // 
            this.lbl_Out.AutoSize = true;
            this.lbl_Out.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Out.Location = new System.Drawing.Point(3, 6);
            this.lbl_Out.Name = "lbl_Out";
            this.lbl_Out.Size = new System.Drawing.Size(88, 26);
            this.lbl_Out.TabIndex = 64;
            this.lbl_Out.Text = "Output";
            // 
            // lbl_Result
            // 
            this.lbl_Result.BackColor = System.Drawing.Color.White;
            this.lbl_Result.Controls.Add(this.lbl_Out);
            this.lbl_Result.Location = new System.Drawing.Point(168, 953);
            this.lbl_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(1408, 44);
            this.lbl_Result.TabIndex = 65;
            // 
            // frm_Emplyee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1038);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.ggb_Shift_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Employee_Dept);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Header);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Emplyee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emplyee_Details";
            this.Load += new System.EventHandler(this.frm_Emplyee_Details_Load);
            this.ggb_Shift_Time.ResumeLayout(false);
            this.ggb_Shift_Time.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.lbl_Result.ResumeLayout(false);
            this.lbl_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.GroupBox ggb_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.ComboBox cmb_Employee_Dept;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Out;
        private System.Windows.Forms.Panel lbl_Result;
    }
}

