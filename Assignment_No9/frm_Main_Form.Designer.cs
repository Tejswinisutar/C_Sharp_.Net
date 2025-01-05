
namespace Assignment_No9
{
    partial class frm_Main_Form
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
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.lbl_User_Management = new System.Windows.Forms.Label();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.btn_User_Name = new System.Windows.Forms.Button();
            this.btn_User_Management = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Head.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Head
            // 
            this.pnl_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnl_Head.Controls.Add(this.lbl_User_Management);
            this.pnl_Head.Location = new System.Drawing.Point(375, 1);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(1368, 190);
            this.pnl_Head.TabIndex = 0;
            // 
            // lbl_User_Management
            // 
            this.lbl_User_Management.AutoSize = true;
            this.lbl_User_Management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_User_Management.Font = new System.Drawing.Font("Modern No. 20", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Management.Location = new System.Drawing.Point(336, 42);
            this.lbl_User_Management.Name = "lbl_User_Management";
            this.lbl_User_Management.Size = new System.Drawing.Size(648, 87);
            this.lbl_User_Management.TabIndex = 0;
            this.lbl_User_Management.Text = "User Management";
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_Menu.Controls.Add(this.lbl_User_Name);
            this.pnl_Menu.Controls.Add(this.btn_User_Name);
            this.pnl_Menu.Controls.Add(this.btn_User_Management);
            this.pnl_Menu.Controls.Add(this.btn_Log_Out);
            this.pnl_Menu.Controls.Add(this.btn_Customer);
            this.pnl_Menu.Controls.Add(this.btn_Product);
            this.pnl_Menu.Controls.Add(this.btn_Staff);
            this.pnl_Menu.Location = new System.Drawing.Point(-2, 191);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(377, 880);
            this.pnl_Menu.TabIndex = 1;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.BackColor = System.Drawing.Color.White;
            this.lbl_User_Name.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.Location = new System.Drawing.Point(94, 652);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(195, 41);
            this.lbl_User_Name.TabIndex = 0;
            this.lbl_User_Name.Text = "User Name";
            // 
            // btn_User_Name
            // 
            this.btn_User_Name.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User_Name.ForeColor = System.Drawing.Color.Black;
            this.btn_User_Name.Location = new System.Drawing.Point(32, 622);
            this.btn_User_Name.Name = "btn_User_Name";
            this.btn_User_Name.Size = new System.Drawing.Size(315, 100);
            this.btn_User_Name.TabIndex = 5;
            this.btn_User_Name.UseVisualStyleBackColor = true;
            // 
            // btn_User_Management
            // 
            this.btn_User_Management.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User_Management.ForeColor = System.Drawing.Color.Black;
            this.btn_User_Management.Location = new System.Drawing.Point(32, 462);
            this.btn_User_Management.Name = "btn_User_Management";
            this.btn_User_Management.Size = new System.Drawing.Size(315, 100);
            this.btn_User_Management.TabIndex = 4;
            this.btn_User_Management.Text = "User Management";
            this.btn_User_Management.UseVisualStyleBackColor = true;
            this.btn_User_Management.Click += new System.EventHandler(this.btn_User_Management_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(32, 771);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(315, 82);
            this.btn_Log_Out.TabIndex = 6;
            this.btn_Log_Out.Text = "Log-Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            // 
            // btn_Customer
            // 
            this.btn_Customer.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Black;
            this.btn_Customer.Location = new System.Drawing.Point(32, 39);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(315, 84);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.Black;
            this.btn_Product.Location = new System.Drawing.Point(32, 180);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(315, 84);
            this.btn_Product.TabIndex = 2;
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = true;
            // 
            // btn_Staff
            // 
            this.btn_Staff.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.Black;
            this.btn_Staff.Location = new System.Drawing.Point(32, 322);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(315, 84);
            this.btn_Staff.TabIndex = 3;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = true;
            // 
            // pnl_Container
            // 
            this.pnl_Container.Location = new System.Drawing.Point(372, 191);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1371, 883);
            this.pnl_Container.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment_No9.Properties.Resources.pexels_pixabay_460537;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 1070);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Head);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main_Form";
            this.Load += new System.EventHandler(this.frm_Main_Form_Load);
            this.pnl_Head.ResumeLayout(false);
            this.pnl_Head.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Head;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_User_Management;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_User_Name;
        private System.Windows.Forms.Label lbl_User_Management;
        public System.Windows.Forms.Panel pnl_Container;
    }
}