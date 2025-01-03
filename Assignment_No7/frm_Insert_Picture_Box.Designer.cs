
namespace Assignment_No7
{
    partial class frm_Picture_Box
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
            this.lbl_Image_Id = new System.Windows.Forms.Label();
            this.lbl_Image_Desricption = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_Image_Id = new System.Windows.Forms.TextBox();
            this.tb_Image_Desricption = new System.Windows.Forms.TextBox();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.btn_Search_Images = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Show_Images = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Image_Id
            // 
            this.lbl_Image_Id.AutoSize = true;
            this.lbl_Image_Id.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Id.Location = new System.Drawing.Point(46, 218);
            this.lbl_Image_Id.Name = "lbl_Image_Id";
            this.lbl_Image_Id.Size = new System.Drawing.Size(160, 38);
            this.lbl_Image_Id.TabIndex = 0;
            this.lbl_Image_Id.Text = "Image Id";
            // 
            // lbl_Image_Desricption
            // 
            this.lbl_Image_Desricption.AutoSize = true;
            this.lbl_Image_Desricption.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Desricption.Location = new System.Drawing.Point(46, 375);
            this.lbl_Image_Desricption.Name = "lbl_Image_Desricption";
            this.lbl_Image_Desricption.Size = new System.Drawing.Size(311, 38);
            this.lbl_Image_Desricption.TabIndex = 1;
            this.lbl_Image_Desricption.Text = "Image Desricption";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.Location = new System.Drawing.Point(1215, 205);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(113, 38);
            this.lbl_Image.TabIndex = 2;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(591, 32);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(574, 103);
            this.lbl_Header.TabIndex = 30;
            this.lbl_Header.Text = "Insert Image";
            // 
            // tb_Image_Id
            // 
            this.tb_Image_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Id.Location = new System.Drawing.Point(396, 214);
            this.tb_Image_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Image_Id.Name = "tb_Image_Id";
            this.tb_Image_Id.Size = new System.Drawing.Size(488, 45);
            this.tb_Image_Id.TabIndex = 1;
            // 
            // tb_Image_Desricption
            // 
            this.tb_Image_Desricption.Location = new System.Drawing.Point(396, 358);
            this.tb_Image_Desricption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Image_Desricption.Multiline = true;
            this.tb_Image_Desricption.Name = "tb_Image_Desricption";
            this.tb_Image_Desricption.Size = new System.Drawing.Size(488, 382);
            this.tb_Image_Desricption.TabIndex = 2;
            this.tb_Image_Desricption.TextChanged += new System.EventHandler(this.tb_Image_Desricption_TextChanged);
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(991, 264);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(564, 455);
            this.pb_Image.TabIndex = 33;
            this.pb_Image.TabStop = false;
            // 
            // btn_Search_Images
            // 
            this.btn_Search_Images.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Images.ForeColor = System.Drawing.Color.Red;
            this.btn_Search_Images.Location = new System.Drawing.Point(862, 877);
            this.btn_Search_Images.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search_Images.Name = "btn_Search_Images";
            this.btn_Search_Images.Size = new System.Drawing.Size(408, 82);
            this.btn_Search_Images.TabIndex = 5;
            this.btn_Search_Images.Text = "Search Images";
            this.btn_Search_Images.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(534, 886);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(197, 73);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(141, 881);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(216, 82);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Browse.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.Red;
            this.btn_Browse.Location = new System.Drawing.Point(1183, 743);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(202, 65);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Show_Images
            // 
            this.btn_Show_Images.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Images.ForeColor = System.Drawing.Color.Red;
            this.btn_Show_Images.Location = new System.Drawing.Point(1345, 877);
            this.btn_Show_Images.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Show_Images.Name = "btn_Show_Images";
            this.btn_Show_Images.Size = new System.Drawing.Size(404, 80);
            this.btn_Show_Images.TabIndex = 6;
            this.btn_Show_Images.Text = "Show Images";
            this.btn_Show_Images.UseVisualStyleBackColor = true;
            // 
            // frm_Picture_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 1005);
            this.Controls.Add(this.btn_Show_Images);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Search_Images);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.tb_Image_Desricption);
            this.Controls.Add(this.tb_Image_Id);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Image_Desricption);
            this.Controls.Add(this.lbl_Image_Id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Picture_Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Box";
            this.Load += new System.EventHandler(this.frm_Picture_Box_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Image_Id;
        private System.Windows.Forms.Label lbl_Image_Desricption;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_Image_Id;
        private System.Windows.Forms.TextBox tb_Image_Desricption;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_Search_Images;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Show_Images;
    }
}

