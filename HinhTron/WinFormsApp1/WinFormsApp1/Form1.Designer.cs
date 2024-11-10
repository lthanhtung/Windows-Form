namespace WinFormsApp1
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
            Chuvi = new Button();
            Dientich = new Button();
            thoat = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            KetQua = new TextBox();
            SuspendLayout();
            // 
            // Chuvi
            // 
            Chuvi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Chuvi.Location = new Point(69, 112);
            Chuvi.Name = "Chuvi";
            Chuvi.Size = new Size(148, 48);
            Chuvi.TabIndex = 0;
            Chuvi.Text = "Chu vi";
            Chuvi.UseVisualStyleBackColor = false;
            Chuvi.Click += Chuvi_Click;
            // 
            // Dientich
            // 
            Dientich.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Dientich.Location = new Point(307, 112);
            Dientich.Name = "Dientich";
            Dientich.Size = new Size(148, 48);
            Dientich.TabIndex = 1;
            Dientich.Text = "Diện tích";
            Dientich.UseVisualStyleBackColor = false;
            Dientich.Click += Dientich_Click;
            // 
            // thoat
            // 
            thoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.Location = new Point(572, 112);
            thoat.Name = "thoat";
            thoat.Size = new Size(148, 48);
            thoat.TabIndex = 2;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = false;
            thoat.Click += thoat_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(493, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 67);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 37);
            label1.Name = "label1";
            label1.Size = new Size(285, 31);
            label1.TabIndex = 4;
            label1.Text = "Nhập bán kính hình tròn:";
            // 
            // KetQua
            // 
            KetQua.Location = new Point(53, 189);
            KetQua.Multiline = true;
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(698, 228);
            KetQua.TabIndex = 5;
            KetQua.TextChanged += KetQua_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KetQua);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(thoat);
            Controls.Add(Dientich);
            Controls.Add(Chuvi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Chuvi;
        private Button Dientich;
        private Button thoat;
        private TextBox textBox1;
        private Label label1;
        private TextBox KetQua;
    }
}