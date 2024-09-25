namespace Bai4
{
    partial class Form_QuanLyThongTinTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_stk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SoTienTrongTK = new System.Windows.Forms.TextBox();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.listView_Infor = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tài khoản";
            // 
            // textBox_stk
            // 
            this.textBox_stk.Location = new System.Drawing.Point(240, 94);
            this.textBox_stk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_stk.Name = "textBox_stk";
            this.textBox_stk.Size = new System.Drawing.Size(853, 26);
            this.textBox_stk.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Location = new System.Drawing.Point(240, 134);
            this.textBox_Ten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(853, 26);
            this.textBox_Ten.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ khách hàng";
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(240, 174);
            this.textBox_DiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(853, 26);
            this.textBox_DiaChi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số tiền trong tài khoản";
            // 
            // textBox_SoTienTrongTK
            // 
            this.textBox_SoTienTrongTK.Location = new System.Drawing.Point(240, 214);
            this.textBox_SoTienTrongTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_SoTienTrongTK.Name = "textBox_SoTienTrongTK";
            this.textBox_SoTienTrongTK.Size = new System.Drawing.Size(853, 26);
            this.textBox_SoTienTrongTK.TabIndex = 2;
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(878, 254);
            this.button_Del.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(104, 35);
            this.button_Del.TabIndex = 3;
            this.button_Del.Text = "Xoá";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(990, 254);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(105, 35);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Thoát";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(714, 254);
            this.button_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(154, 35);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Thêm / Cập nhật";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // listView_Infor
            // 
            this.listView_Infor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Infor.FullRowSelect = true;
            this.listView_Infor.HideSelection = false;
            this.listView_Infor.Location = new System.Drawing.Point(23, 299);
            this.listView_Infor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_Infor.Name = "listView_Infor";
            this.listView_Infor.Size = new System.Drawing.Size(1142, 333);
            this.listView_Infor.TabIndex = 4;
            this.listView_Infor.UseCompatibleStateImageBehavior = false;
            this.listView_Infor.View = System.Windows.Forms.View.Details;
            this.listView_Infor.SelectedIndexChanged += new System.EventHandler(this.listView_Infor_SelectedIndexChanged_1);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã tài khoản";
            this.columnHeader1.Width = 227;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.Width = 332;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 310;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số tiền";
            this.columnHeader4.Width = 178;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 645);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng tiền";
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.Location = new System.Drawing.Point(790, 643);
            this.textBox_TongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.Size = new System.Drawing.Size(370, 26);
            this.textBox_TongTien.TabIndex = 2;
            // 
            // Form_QuanLyThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.listView_Infor);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.textBox_SoTienTrongTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_TongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_stk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_QuanLyThongTinTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.Form_QuanLyThongTinTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_stk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SoTienTrongTK;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.ListView listView_Infor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

