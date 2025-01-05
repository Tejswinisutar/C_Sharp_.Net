
namespace Assignment_No9
{
    partial class UC_User_Management
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Update_User = new System.Windows.Forms.Button();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.lbl_User_Management = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update_User
            // 
            this.btn_Update_User.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_User.ForeColor = System.Drawing.Color.Red;
            this.btn_Update_User.Location = new System.Drawing.Point(558, 117);
            this.btn_Update_User.Name = "btn_Update_User";
            this.btn_Update_User.Size = new System.Drawing.Size(287, 60);
            this.btn_Update_User.TabIndex = 2;
            this.btn_Update_User.Text = "Update User";
            this.btn_Update_User.UseVisualStyleBackColor = true;
            this.btn_Update_User.Click += new System.EventHandler(this.btn_Update_User_Click);
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete_User.Location = new System.Drawing.Point(1020, 117);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(287, 60);
            this.btn_Delete_User.TabIndex = 3;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = true;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_User.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_User.Location = new System.Drawing.Point(83, 117);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(287, 60);
            this.btn_Add_User.TabIndex = 1;
            this.btn_Add_User.Text = "Add User";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // lbl_User_Management
            // 
            this.lbl_User_Management.AutoSize = true;
            this.lbl_User_Management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_User_Management.Font = new System.Drawing.Font("Modern No. 20", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Management.ForeColor = System.Drawing.Color.Black;
            this.lbl_User_Management.Location = new System.Drawing.Point(453, 20);
            this.lbl_User_Management.Name = "lbl_User_Management";
            this.lbl_User_Management.Size = new System.Drawing.Size(456, 60);
            this.lbl_User_Management.TabIndex = 6;
            this.lbl_User_Management.Text = "User Management";
            // 
            // UC_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_User_Management);
            this.Controls.Add(this.btn_Add_User);
            this.Controls.Add(this.btn_Delete_User);
            this.Controls.Add(this.btn_Update_User);
            this.Name = "UC_User_Management";
            this.Size = new System.Drawing.Size(1368, 197);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update_User;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.Label lbl_User_Management;
    }
}
