
namespace Assignment_No7
{
    partial class frm_Show_Image
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
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Image_list = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(413, 25);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(550, 103);
            this.lbl_Header.TabIndex = 43;
            this.lbl_Header.Text = "Show Image";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.Location = new System.Drawing.Point(259, 175);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(113, 38);
            this.lbl_Image.TabIndex = 44;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Image_list
            // 
            this.lbl_Image_list.AutoSize = true;
            this.lbl_Image_list.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_list.Location = new System.Drawing.Point(888, 175);
            this.lbl_Image_list.Name = "lbl_Image_list";
            this.lbl_Image_list.Size = new System.Drawing.Size(190, 38);
            this.lbl_Image_list.TabIndex = 45;
            this.lbl_Image_list.Text = "Image List";
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(36, 238);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(559, 487);
            this.pb_Image.TabIndex = 46;
            this.pb_Image.TabStop = false;
            this.pb_Image.Click += new System.EventHandler(this.pb_Image_Click);
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(675, 238);
            this.dgv_Image_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.RowHeadersWidth = 51;
            this.dgv_Image_List.Size = new System.Drawing.Size(605, 487);
            this.dgv_Image_List.TabIndex = 47;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(179, 775);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(207, 66);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_Image.Location = new System.Drawing.Point(847, 769);
            this.btn_Add_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(288, 71);
            this.btn_Add_Image.TabIndex = 2;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = true;
            // 
            // frm_Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 942);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.lbl_Image_list);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Header);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Show_Image";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Image_list;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.DataGridView dgv_Image_List;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add_Image;
    }
}