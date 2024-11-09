
namespace Tejuu_Assignment_No2
{
    partial class frm_Course_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_Course_List = new System.Windows.Forms.DataGridView();
            this.student_Management_System_DBDataSet3 = new Tejuu_Assignment_No2.Student_Management_System_DBDataSet3();
            this.courseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_DetailsTableAdapter = new Tejuu_Assignment_No2.Student_Management_System_DBDataSet3TableAdapters.course_DetailsTableAdapter();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(474, 60);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(546, 103);
            this.lbl_Header.TabIndex = 4;
            this.lbl_Header.Text = "Course List ";
            // 
            // dgv_Course_List
            // 
            this.dgv_Course_List.AllowUserToAddRows = false;
            this.dgv_Course_List.AllowUserToDeleteRows = false;
            this.dgv_Course_List.AutoGenerateColumns = false;
            this.dgv_Course_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Course_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Course_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_Course_List.DataSource = this.courseDetailsBindingSource;
            this.dgv_Course_List.Location = new System.Drawing.Point(66, 244);
            this.dgv_Course_List.Name = "dgv_Course_List";
            this.dgv_Course_List.ReadOnly = true;
            this.dgv_Course_List.RowHeadersWidth = 51;
            this.dgv_Course_List.RowTemplate.Height = 24;
            this.dgv_Course_List.Size = new System.Drawing.Size(1432, 636);
            this.dgv_Course_List.TabIndex = 5;
            // 
            // student_Management_System_DBDataSet3
            // 
            this.student_Management_System_DBDataSet3.DataSetName = "Student_Management_System_DBDataSet3";
            this.student_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDetailsBindingSource
            // 
            this.courseDetailsBindingSource.DataMember = "course_Details";
            this.courseDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet3;
            // 
            // course_DetailsTableAdapter
            // 
            this.course_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 1095);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Course_List);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Course_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Course_List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Course_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_Course_List;
        private Student_Management_System_DBDataSet3 student_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource courseDetailsBindingSource;
        private Student_Management_System_DBDataSet3TableAdapters.course_DetailsTableAdapter course_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}