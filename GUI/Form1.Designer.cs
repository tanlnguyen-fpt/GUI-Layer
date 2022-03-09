
namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStudentInfomation = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbClassID = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.gbStudentInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudentInfomation
            // 
            this.gbStudentInfomation.Controls.Add(this.btnDelete);
            this.gbStudentInfomation.Controls.Add(this.btnUpdate);
            this.gbStudentInfomation.Controls.Add(this.btnInsert);
            this.gbStudentInfomation.Controls.Add(this.txtClassID);
            this.gbStudentInfomation.Controls.Add(this.txtFullName);
            this.gbStudentInfomation.Controls.Add(this.lbClassID);
            this.gbStudentInfomation.Controls.Add(this.lbFullName);
            this.gbStudentInfomation.Controls.Add(this.txtStudentID);
            this.gbStudentInfomation.Controls.Add(this.lbStudentID);
            this.gbStudentInfomation.Location = new System.Drawing.Point(376, 40);
            this.gbStudentInfomation.Name = "gbStudentInfomation";
            this.gbStudentInfomation.Size = new System.Drawing.Size(264, 232);
            this.gbStudentInfomation.TabIndex = 1;
            this.gbStudentInfomation.TabStop = false;
            this.gbStudentInfomation.Text = "Student Infomation";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(183, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(83, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(0, 157);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(69, 37);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(89, 104);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(144, 23);
            this.txtClassID.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(89, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(144, 23);
            this.txtFullName.TabIndex = 1;
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Location = new System.Drawing.Point(7, 108);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(48, 15);
            this.lbClassID.TabIndex = 0;
            this.lbClassID.Text = "Class ID";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(7, 66);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(61, 15);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Full Name";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(89, 23);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(144, 23);
            this.txtStudentID.TabIndex = 1;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(7, 27);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(62, 15);
            this.lbStudentID.TabIndex = 0;
            this.lbStudentID.Text = "Student ID";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(8, 40);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 25;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(344, 232);
            this.dgvStudent.TabIndex = 2;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 292);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.gbStudentInfomation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbStudentInfomation.ResumeLayout(false);
            this.gbStudentInfomation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbStudentInfomation;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}

