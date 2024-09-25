namespace ASM
{
    partial class ManaClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTeacherId = new System.Windows.Forms.Label();
            this.lbClassname = new System.Windows.Forms.Label();
            this.lbSubjectId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.cbbSubjectId = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lbgh = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lbClassId = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.cbbTeacherId = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btRefesh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.lbTeacherId);
            this.groupBox1.Controls.Add(this.lbClassname);
            this.groupBox1.Controls.Add(this.lbSubjectId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btInsert);
            this.groupBox1.Controls.Add(this.cbbSubjectId);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lbgh);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.lbClassId);
            this.groupBox1.Controls.Add(this.txtClassId);
            this.groupBox1.Controls.Add(this.cbbTeacherId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(632, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 391);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detailed information";
            // 
            // lbTeacherId
            // 
            this.lbTeacherId.AutoSize = true;
            this.lbTeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTeacherId.Location = new System.Drawing.Point(99, 201);
            this.lbTeacherId.Name = "lbTeacherId";
            this.lbTeacherId.Size = new System.Drawing.Size(72, 16);
            this.lbTeacherId.TabIndex = 71;
            this.lbTeacherId.Text = "Teacher Id";
            // 
            // lbClassname
            // 
            this.lbClassname.AutoSize = true;
            this.lbClassname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbClassname.Location = new System.Drawing.Point(99, 141);
            this.lbClassname.Name = "lbClassname";
            this.lbClassname.Size = new System.Drawing.Size(78, 16);
            this.lbClassname.TabIndex = 70;
            this.lbClassname.Text = "ClassName";
            // 
            // lbSubjectId
            // 
            this.lbSubjectId.AutoSize = true;
            this.lbSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubjectId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSubjectId.Location = new System.Drawing.Point(99, 282);
            this.lbSubjectId.Name = "lbSubjectId";
            this.lbSubjectId.Size = new System.Drawing.Size(70, 16);
            this.lbSubjectId.TabIndex = 69;
            this.lbSubjectId.Text = "SubjectsId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Subject ID";
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.DarkMagenta;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btInsert.Location = new System.Drawing.Point(54, 326);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(210, 44);
            this.btInsert.TabIndex = 46;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // cbbSubjectId
            // 
            this.cbbSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubjectId.FormattingEnabled = true;
            this.cbbSubjectId.Location = new System.Drawing.Point(102, 244);
            this.cbbSubjectId.Name = "cbbSubjectId";
            this.cbbSubjectId.Size = new System.Drawing.Size(99, 24);
            this.cbbSubjectId.TabIndex = 67;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 19);
            this.label19.TabIndex = 53;
            this.label19.Text = "Teacher ID";
            // 
            // lbgh
            // 
            this.lbgh.AutoSize = true;
            this.lbgh.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgh.Location = new System.Drawing.Point(6, 119);
            this.lbgh.Name = "lbgh";
            this.lbgh.Size = new System.Drawing.Size(90, 19);
            this.lbgh.TabIndex = 43;
            this.lbgh.Text = "Class Name";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(6, 58);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(64, 19);
            this.lab.TabIndex = 42;
            this.lab.Text = "Class ID";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(102, 115);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(162, 23);
            this.txtClassName.TabIndex = 64;
            // 
            // lbClassId
            // 
            this.lbClassId.AutoSize = true;
            this.lbClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbClassId.Location = new System.Drawing.Point(99, 82);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(55, 16);
            this.lbClassId.TabIndex = 60;
            this.lbClassId.Text = "Class Id";
            // 
            // txtClassId
            // 
            this.txtClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassId.Location = new System.Drawing.Point(102, 56);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(85, 23);
            this.txtClassId.TabIndex = 62;
            // 
            // cbbTeacherId
            // 
            this.cbbTeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTeacherId.FormattingEnabled = true;
            this.cbbTeacherId.Location = new System.Drawing.Point(102, 174);
            this.cbbTeacherId.Name = "cbbTeacherId";
            this.cbbTeacherId.Size = new System.Drawing.Size(99, 24);
            this.cbbTeacherId.TabIndex = 63;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 34);
            this.btnHome.TabIndex = 59;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClass.Location = new System.Drawing.Point(12, 55);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(598, 298);
            this.dgvClass.TabIndex = 63;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ClassId";
            this.Column1.HeaderText = "Class ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ClassName";
            this.Column2.HeaderText = "Class Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TeacherId";
            this.Column3.HeaderText = "Teacher ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SubjectsId";
            this.Column4.HeaderText = "Subject ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Crimson;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDelete.Location = new System.Drawing.Point(403, 359);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 44);
            this.btDelete.TabIndex = 61;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btUpdate.Location = new System.Drawing.Point(221, 359);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(102, 44);
            this.btUpdate.TabIndex = 60;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            // 
            // btRefesh
            // 
            this.btRefesh.BackColor = System.Drawing.Color.DarkMagenta;
            this.btRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefesh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefesh.Location = new System.Drawing.Point(60, 359);
            this.btRefesh.Name = "btRefesh";
            this.btRefesh.Size = new System.Drawing.Size(102, 44);
            this.btRefesh.TabIndex = 62;
            this.btRefesh.Text = "Refesh";
            this.btRefesh.UseVisualStyleBackColor = false;
            // 
            // ManaClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btRefesh);
            this.Name = "ManaClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManaClass";
            this.Load += new System.EventHandler(this.ManaClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTeacherId;
        private System.Windows.Forms.Label lbClassname;
        private System.Windows.Forms.Label lbSubjectId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.ComboBox cbbSubjectId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbgh;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lbClassId;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.ComboBox cbbTeacherId;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btRefesh;
    }
}