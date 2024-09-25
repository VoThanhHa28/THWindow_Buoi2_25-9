namespace Buoi2
{
    partial class Form1
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
            this.label_Number1 = new System.Windows.Forms.Label();
            this.textBox_Number1 = new System.Windows.Forms.TextBox();
            this.textBox_Number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Sub = new System.Windows.Forms.Button();
            this.button_Mul = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Number1
            // 
            this.label_Number1.AutoSize = true;
            this.label_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number1.Location = new System.Drawing.Point(97, 49);
            this.label_Number1.Name = "label_Number1";
            this.label_Number1.Size = new System.Drawing.Size(73, 16);
            this.label_Number1.TabIndex = 0;
            this.label_Number1.Text = "Number 1";
            this.label_Number1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Number1
            // 
            this.textBox_Number1.Location = new System.Drawing.Point(176, 45);
            this.textBox_Number1.Name = "textBox_Number1";
            this.textBox_Number1.Size = new System.Drawing.Size(206, 20);
            this.textBox_Number1.TabIndex = 1;
            // 
            // textBox_Number2
            // 
            this.textBox_Number2.Location = new System.Drawing.Point(176, 83);
            this.textBox_Number2.Name = "textBox_Number2";
            this.textBox_Number2.Size = new System.Drawing.Size(206, 20);
            this.textBox_Number2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number 2";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(100, 127);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(59, 32);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Sub
            // 
            this.button_Sub.Location = new System.Drawing.Point(176, 126);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(59, 32);
            this.button_Sub.TabIndex = 5;
            this.button_Sub.Text = "-";
            this.button_Sub.UseVisualStyleBackColor = true;
            this.button_Sub.Click += new System.EventHandler(this.button_Sub_Click);
            // 
            // button_Mul
            // 
            this.button_Mul.Location = new System.Drawing.Point(250, 126);
            this.button_Mul.Name = "button_Mul";
            this.button_Mul.Size = new System.Drawing.Size(59, 32);
            this.button_Mul.TabIndex = 6;
            this.button_Mul.Text = "*";
            this.button_Mul.UseVisualStyleBackColor = true;
            this.button_Mul.Click += new System.EventHandler(this.button_Mul_Click);
            // 
            // button_Div
            // 
            this.button_Div.Location = new System.Drawing.Point(323, 126);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(59, 32);
            this.button_Div.TabIndex = 7;
            this.button_Div.Text = "/";
            this.button_Div.UseVisualStyleBackColor = true;
            this.button_Div.Click += new System.EventHandler(this.button_Div_Click);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(176, 179);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(206, 20);
            this.textBox_Answer.TabIndex = 9;
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Answer.Location = new System.Drawing.Point(97, 184);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(57, 16);
            this.label_Answer.TabIndex = 8;
            this.label_Answer.Text = "Answer";
            this.label_Answer.Click += new System.EventHandler(this.label_Answer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 260);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.button_Div);
            this.Controls.Add(this.button_Mul);
            this.Controls.Add(this.button_Sub);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Number2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Number1);
            this.Controls.Add(this.label_Number1);
            this.Name = "Form1";
            this.Text = "\\";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Number1;
        private System.Windows.Forms.TextBox textBox_Number1;
        private System.Windows.Forms.TextBox textBox_Number2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.Button button_Mul;
        private System.Windows.Forms.Button button_Div;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_Answer;
    }
}

