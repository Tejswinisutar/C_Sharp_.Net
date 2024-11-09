
namespace Assignment_No6
{
    partial class frm_Header
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
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.cmb_Dept = new System.Windows.Forms.ComboBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Known_Languages = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.gb_Known_Languages = new System.Windows.Forms.GroupBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.lbl_Name_Error = new System.Windows.Forms.Label();
            this.lbl_Dept_Error = new System.Windows.Forms.Label();
            this.lbl_Gender_Error = new System.Windows.Forms.Label();
            this.lbl_Hobby_Error = new System.Windows.Forms.Label();
            this.lbl_Lang_Error = new System.Windows.Forms.Label();
            this.lbl_Out = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Languages.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.White;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(430, 573);
            this.gb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Size = new System.Drawing.Size(437, 99);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(241, 44);
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
            this.rb_Male.Location = new System.Drawing.Point(48, 44);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(88, 30);
            this.rb_Male.TabIndex = 2;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // cmb_Dept
            // 
            this.cmb_Dept.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dept.FormattingEnabled = true;
            this.cmb_Dept.Items.AddRange(new object[] {
            " HRD",
            " R&D",
            "Testing",
            "Management"});
            this.cmb_Dept.Location = new System.Drawing.Point(456, 386);
            this.cmb_Dept.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Dept.Name = "cmb_Dept";
            this.cmb_Dept.Size = new System.Drawing.Size(411, 46);
            this.cmb_Dept.TabIndex = 2;
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(401, 179);
            this.tb_Employee_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(411, 45);
            this.tb_Employee_Name.TabIndex = 1;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Gender.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(30, 591);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(148, 44);
            this.lbl_Gender.TabIndex = 45;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.Location = new System.Drawing.Point(12, 386);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(418, 44);
            this.lbl_Employee_Department.TabIndex = 44;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.Location = new System.Drawing.Point(12, 180);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(308, 44);
            this.lbl_Employee_Name.TabIndex = 43;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(446, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(834, 113);
            this.lbl_Header.TabIndex = 42;
            this.lbl_Header.Text = "Employee Details";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Output.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(44, 933);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(118, 35);
            this.lbl_Output.TabIndex = 53;
            this.lbl_Output.Text = "Output";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(954, 817);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(199, 70);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(528, 817);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(219, 70);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click_1);
            // 
            // lbl_Known_Languages
            // 
            this.lbl_Known_Languages.AutoSize = true;
            this.lbl_Known_Languages.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Known_Languages.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Known_Languages.Location = new System.Drawing.Point(875, 180);
            this.lbl_Known_Languages.Name = "lbl_Known_Languages";
            this.lbl_Known_Languages.Size = new System.Drawing.Size(349, 44);
            this.lbl_Known_Languages.TabIndex = 55;
            this.lbl_Known_Languages.Text = "Known Languages";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.Location = new System.Drawing.Point(1005, 475);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(165, 44);
            this.lbl_Hobbies.TabIndex = 56;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // gb_Known_Languages
            // 
            this.gb_Known_Languages.BackColor = System.Drawing.Color.White;
            this.gb_Known_Languages.Controls.Add(this.cb_English);
            this.gb_Known_Languages.Controls.Add(this.cb_French);
            this.gb_Known_Languages.Controls.Add(this.cb_Hindi);
            this.gb_Known_Languages.Controls.Add(this.cb_Marathi);
            this.gb_Known_Languages.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Known_Languages.Location = new System.Drawing.Point(1242, 201);
            this.gb_Known_Languages.Name = "gb_Known_Languages";
            this.gb_Known_Languages.Size = new System.Drawing.Size(469, 176);
            this.gb_Known_Languages.TabIndex = 4;
            this.gb_Known_Languages.TabStop = false;
            this.gb_Known_Languages.Text = "Known Languages";
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Location = new System.Drawing.Point(58, 114);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(121, 30);
            this.cb_English.TabIndex = 3;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Location = new System.Drawing.Point(284, 114);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(113, 30);
            this.cb_French.TabIndex = 2;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Location = new System.Drawing.Point(284, 47);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(100, 30);
            this.cb_Hindi.TabIndex = 1;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Location = new System.Drawing.Point(53, 47);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(126, 30);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Reading",
            "Driving",
            "Teaching",
            "Gaming",
            "Cycling",
            "Tracking",
            "Swimming",
            "Dancing",
            "Listening Movie"});
            this.clb_Hobbies.Location = new System.Drawing.Point(1242, 457);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(427, 247);
            this.clb_Hobbies.TabIndex = 5;
            this.clb_Hobbies.SelectedIndexChanged += new System.EventHandler(this.clb_Hobbies_SelectedIndexChanged);
            // 
            // lbl_Name_Error
            // 
            this.lbl_Name_Error.AutoSize = true;
            this.lbl_Name_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name_Error.Location = new System.Drawing.Point(668, 256);
            this.lbl_Name_Error.Name = "lbl_Name_Error";
            this.lbl_Name_Error.Size = new System.Drawing.Size(118, 22);
            this.lbl_Name_Error.TabIndex = 59;
            this.lbl_Name_Error.Text = "Name Error";
            this.lbl_Name_Error.Visible = false;
            // 
            // lbl_Dept_Error
            // 
            this.lbl_Dept_Error.AutoSize = true;
            this.lbl_Dept_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Dept_Error.Location = new System.Drawing.Point(701, 457);
            this.lbl_Dept_Error.Name = "lbl_Dept_Error";
            this.lbl_Dept_Error.Size = new System.Drawing.Size(111, 22);
            this.lbl_Dept_Error.TabIndex = 60;
            this.lbl_Dept_Error.Text = "Dept Error";
            this.lbl_Dept_Error.Visible = false;
            // 
            // lbl_Gender_Error
            // 
            this.lbl_Gender_Error.AutoSize = true;
            this.lbl_Gender_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Gender_Error.Location = new System.Drawing.Point(701, 700);
            this.lbl_Gender_Error.Name = "lbl_Gender_Error";
            this.lbl_Gender_Error.Size = new System.Drawing.Size(132, 22);
            this.lbl_Gender_Error.TabIndex = 61;
            this.lbl_Gender_Error.Text = "Gender Error";
            this.lbl_Gender_Error.Visible = false;
            // 
            // lbl_Hobby_Error
            // 
            this.lbl_Hobby_Error.AutoSize = true;
            this.lbl_Hobby_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobby_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hobby_Error.Location = new System.Drawing.Point(1533, 725);
            this.lbl_Hobby_Error.Name = "lbl_Hobby_Error";
            this.lbl_Hobby_Error.Size = new System.Drawing.Size(125, 22);
            this.lbl_Hobby_Error.TabIndex = 62;
            this.lbl_Hobby_Error.Text = "Hobby Error";
            this.lbl_Hobby_Error.Visible = false;
            // 
            // lbl_Lang_Error
            // 
            this.lbl_Lang_Error.AutoSize = true;
            this.lbl_Lang_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lang_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Lang_Error.Location = new System.Drawing.Point(1543, 403);
            this.lbl_Lang_Error.Name = "lbl_Lang_Error";
            this.lbl_Lang_Error.Size = new System.Drawing.Size(115, 22);
            this.lbl_Lang_Error.TabIndex = 63;
            this.lbl_Lang_Error.Text = "Lang Error";
            this.lbl_Lang_Error.Visible = false;
            // 
            // lbl_Out
            // 
            this.lbl_Out.AutoSize = true;
            this.lbl_Out.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Out.Location = new System.Drawing.Point(3, 4);
            this.lbl_Out.Name = "lbl_Out";
            this.lbl_Out.Size = new System.Drawing.Size(94, 30);
            this.lbl_Out.TabIndex = 64;
            this.lbl_Out.Text = "output";
            this.lbl_Out.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Out);
            this.panel1.Location = new System.Drawing.Point(187, 933);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 43);
            this.panel1.TabIndex = 65;
            // 
            // frm_Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 1004);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Lang_Error);
            this.Controls.Add(this.lbl_Hobby_Error);
            this.Controls.Add(this.lbl_Gender_Error);
            this.Controls.Add(this.lbl_Dept_Error);
            this.Controls.Add(this.lbl_Name_Error);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.gb_Known_Languages);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Known_Languages);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Dept);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Header";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Languages.ResumeLayout(false);
            this.gb_Known_Languages.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.ComboBox cmb_Dept;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Known_Languages;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.GroupBox gb_Known_Languages;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.Label lbl_Name_Error;
        private System.Windows.Forms.Label lbl_Dept_Error;
        private System.Windows.Forms.Label lbl_Gender_Error;
        private System.Windows.Forms.Label lbl_Hobby_Error;
        private System.Windows.Forms.Label lbl_Lang_Error;
        private System.Windows.Forms.Label lbl_Out;
        private System.Windows.Forms.Panel panel1;
    }
}

