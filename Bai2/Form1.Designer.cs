namespace Bai2
{
    partial class Form_QuanLySinhVien
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_StudentId = new System.Windows.Forms.Label();
            this.groupBox_StudentInfor = new System.Windows.Forms.GroupBox();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.comboBox_Faculty = new System.Windows.Forms.ComboBox();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.textBox_AverageScore = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_StudentId = new System.Windows.Forms.TextBox();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_AverageScore = new System.Windows.Forms.Label();
            this.label_StudentGender = new System.Windows.Forms.Label();
            this.label_StudentName = new System.Windows.Forms.Label();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_SumMale = new System.Windows.Forms.Label();
            this.label_SumFemale = new System.Windows.Forms.Label();
            this.textBox_SumFemale = new System.Windows.Forms.TextBox();
            this.textBox_SumMale = new System.Windows.Forms.TextBox();
            this.groupBox_StudentInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(257, 19);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(288, 24);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Quản Lý Thông Tin Sinh Viên";
            this.label_Title.Click += new System.EventHandler(this.label_Title_Click);
            // 
            // label_StudentId
            // 
            this.label_StudentId.AutoSize = true;
            this.label_StudentId.Location = new System.Drawing.Point(27, 36);
            this.label_StudentId.Name = "label_StudentId";
            this.label_StudentId.Size = new System.Drawing.Size(70, 13);
            this.label_StudentId.TabIndex = 1;
            this.label_StudentId.Text = "Mã Sinh Viên";
            this.label_StudentId.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_StudentInfor
            // 
            this.groupBox_StudentInfor.Controls.Add(this.button_Del);
            this.groupBox_StudentInfor.Controls.Add(this.button_Update);
            this.groupBox_StudentInfor.Controls.Add(this.comboBox_Faculty);
            this.groupBox_StudentInfor.Controls.Add(this.radioButton_Female);
            this.groupBox_StudentInfor.Controls.Add(this.radioButton_Male);
            this.groupBox_StudentInfor.Controls.Add(this.textBox_AverageScore);
            this.groupBox_StudentInfor.Controls.Add(this.textBox_Name);
            this.groupBox_StudentInfor.Controls.Add(this.textBox_StudentId);
            this.groupBox_StudentInfor.Controls.Add(this.label_Major);
            this.groupBox_StudentInfor.Controls.Add(this.label_AverageScore);
            this.groupBox_StudentInfor.Controls.Add(this.label_StudentGender);
            this.groupBox_StudentInfor.Controls.Add(this.label_StudentName);
            this.groupBox_StudentInfor.Controls.Add(this.label_StudentId);
            this.groupBox_StudentInfor.Location = new System.Drawing.Point(12, 75);
            this.groupBox_StudentInfor.Name = "groupBox_StudentInfor";
            this.groupBox_StudentInfor.Size = new System.Drawing.Size(301, 254);
            this.groupBox_StudentInfor.TabIndex = 2;
            this.groupBox_StudentInfor.TabStop = false;
            this.groupBox_StudentInfor.Text = "Thông Tin Sinh Viên";
            this.groupBox_StudentInfor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(205, 186);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(75, 23);
            this.button_Del.TabIndex = 6;
            this.button_Del.Text = "Xoá";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(112, 186);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Thêm / Sửa";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // comboBox_Faculty
            // 
            this.comboBox_Faculty.FormattingEnabled = true;
            this.comboBox_Faculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.comboBox_Faculty.Location = new System.Drawing.Point(111, 147);
            this.comboBox_Faculty.Name = "comboBox_Faculty";
            this.comboBox_Faculty.Size = new System.Drawing.Size(184, 21);
            this.comboBox_Faculty.TabIndex = 5;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Checked = true;
            this.radioButton_Female.Location = new System.Drawing.Point(175, 93);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(39, 17);
            this.radioButton_Female.TabIndex = 4;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Nữ";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(112, 93);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Male.TabIndex = 4;
            this.radioButton_Male.Text = "Nam";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // textBox_AverageScore
            // 
            this.textBox_AverageScore.Location = new System.Drawing.Point(112, 116);
            this.textBox_AverageScore.Name = "textBox_AverageScore";
            this.textBox_AverageScore.Size = new System.Drawing.Size(71, 20);
            this.textBox_AverageScore.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(112, 60);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(183, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // textBox_StudentId
            // 
            this.textBox_StudentId.Location = new System.Drawing.Point(112, 29);
            this.textBox_StudentId.Name = "textBox_StudentId";
            this.textBox_StudentId.Size = new System.Drawing.Size(127, 20);
            this.textBox_StudentId.TabIndex = 3;
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(27, 155);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(78, 13);
            this.label_Major.TabIndex = 1;
            this.label_Major.Text = "Chuyên Ngành";
            this.label_Major.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_AverageScore
            // 
            this.label_AverageScore.AutoSize = true;
            this.label_AverageScore.Location = new System.Drawing.Point(27, 123);
            this.label_AverageScore.Name = "label_AverageScore";
            this.label_AverageScore.Size = new System.Drawing.Size(48, 13);
            this.label_AverageScore.TabIndex = 1;
            this.label_AverageScore.Text = "Điểm TB";
            this.label_AverageScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_StudentGender
            // 
            this.label_StudentGender.AutoSize = true;
            this.label_StudentGender.Location = new System.Drawing.Point(27, 95);
            this.label_StudentGender.Name = "label_StudentGender";
            this.label_StudentGender.Size = new System.Drawing.Size(51, 13);
            this.label_StudentGender.TabIndex = 1;
            this.label_StudentGender.Text = "Giới Tính";
            this.label_StudentGender.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_StudentName
            // 
            this.label_StudentName.AutoSize = true;
            this.label_StudentName.Location = new System.Drawing.Point(27, 67);
            this.label_StudentName.Name = "label_StudentName";
            this.label_StudentName.Size = new System.Drawing.Size(43, 13);
            this.label_StudentName.TabIndex = 1;
            this.label_StudentName.Text = "Họ Tên";
            this.label_StudentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.AllowUserToAddRows = false;
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_Student.Location = new System.Drawing.Point(319, 75);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Student.Size = new System.Drawing.Size(524, 272);
            this.dataGridView_Student.TabIndex = 2;
            this.dataGridView_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Student_CellClick);
            this.dataGridView_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Student_CellContentClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ Tên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giới Tính";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ĐTB";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Khoa";
            this.Column4.Name = "Column4";
            // 
            // label_SumMale
            // 
            this.label_SumMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SumMale.Location = new System.Drawing.Point(545, 362);
            this.label_SumMale.Name = "label_SumMale";
            this.label_SumMale.Size = new System.Drawing.Size(76, 13);
            this.label_SumMale.TabIndex = 1;
            this.label_SumMale.Text = "Tổng SV Nam";
            this.label_SumMale.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_SumFemale
            // 
            this.label_SumFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SumFemale.Location = new System.Drawing.Point(726, 362);
            this.label_SumFemale.Name = "label_SumFemale";
            this.label_SumFemale.Size = new System.Drawing.Size(24, 13);
            this.label_SumFemale.TabIndex = 1;
            this.label_SumFemale.Text = "Nữ";
            this.label_SumFemale.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_SumFemale
            // 
            this.textBox_SumFemale.Location = new System.Drawing.Point(756, 359);
            this.textBox_SumFemale.Name = "textBox_SumFemale";
            this.textBox_SumFemale.Size = new System.Drawing.Size(83, 20);
            this.textBox_SumFemale.TabIndex = 3;
            // 
            // textBox_SumMale
            // 
            this.textBox_SumMale.Location = new System.Drawing.Point(627, 359);
            this.textBox_SumMale.Name = "textBox_SumMale";
            this.textBox_SumMale.Size = new System.Drawing.Size(83, 20);
            this.textBox_SumMale.TabIndex = 3;
            // 
            // Form_QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 391);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.groupBox_StudentInfor);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.textBox_SumMale);
            this.Controls.Add(this.textBox_SumFemale);
            this.Controls.Add(this.label_SumFemale);
            this.Controls.Add(this.label_SumMale);
            this.Name = "Form_QuanLySinhVien";
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form_QuanLySinhVien_Load);
            this.groupBox_StudentInfor.ResumeLayout(false);
            this.groupBox_StudentInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_StudentId;
        private System.Windows.Forms.GroupBox groupBox_StudentInfor;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Label label_AverageScore;
        private System.Windows.Forms.Label label_StudentGender;
        private System.Windows.Forms.Label label_StudentName;
        private System.Windows.Forms.TextBox textBox_StudentId;
        private System.Windows.Forms.TextBox textBox_AverageScore;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.ComboBox comboBox_Faculty;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label_SumMale;
        private System.Windows.Forms.Label label_SumFemale;
        private System.Windows.Forms.TextBox textBox_SumFemale;
        private System.Windows.Forms.TextBox textBox_SumMale;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

