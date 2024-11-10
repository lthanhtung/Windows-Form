namespace GiaiPT
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
            HS1 = new Label();
            hsa = new TextBox();
            HS2 = new Label();
            hsb = new TextBox();
            HS3 = new Label();
            hsc = new TextBox();
            Giai = new Button();
            Thoat = new Button();
            label1 = new Label();
            Kq = new TextBox();
            SuspendLayout();
            // 
            // a
            // 
            HS1.AutoSize = true;
            HS1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HS1.Location = new Point(47, 46);
            HS1.Name = "a";
            HS1.Size = new Size(126, 28);
            HS1.TabIndex = 0;
            HS1.Text = "Nhập hệ số a";
            // 
            // hsa
            // 
            hsa.Location = new Point(194, 37);
            hsa.Multiline = true;
            hsa.Name = "hsa";
            hsa.Size = new Size(175, 37);
            hsa.TabIndex = 1;
            hsa.TextChanged += hsa_TextChanged;
            // 
            // b
            // 
            HS2.AutoSize = true;
            HS2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HS2.Location = new Point(47, 120);
            HS2.Name = "b";
            HS2.Size = new Size(128, 28);
            HS2.TabIndex = 2;
            HS2.Text = "Nhập hệ số b";
            // 
            // hsb
            // 
            hsb.Location = new Point(194, 111);
            hsb.Multiline = true;
            hsb.Name = "hsb";
            hsb.Size = new Size(175, 37);
            hsb.TabIndex = 3;
            hsb.TextChanged += hsb_TextChanged;
            // 
            // c
            // 
            HS3.AutoSize = true;
            HS3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HS3.Location = new Point(47, 197);
            HS3.Name = "c";
            HS3.Size = new Size(125, 28);
            HS3.TabIndex = 4;
            HS3.Text = "Nhập hệ số c";
            // 
            // hsc
            // 
            hsc.Location = new Point(194, 188);
            hsc.Multiline = true;
            hsc.Name = "hsc";
            hsc.Size = new Size(175, 37);
            hsc.TabIndex = 5;
            hsc.TextChanged += hsc_TextChanged;
            // 
            // Giai
            // 
            Giai.Location = new Point(64, 304);
            Giai.Name = "Giai";
            Giai.Size = new Size(132, 44);
            Giai.TabIndex = 6;
            Giai.Text = "Giải";
            Giai.UseVisualStyleBackColor = false;
            Giai.Click += Giai_Click;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(281, 304);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(132, 44);
            Thoat.TabIndex = 7;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = false;
            Thoat.Click += Thoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(432, 37);
            label1.Name = "label1";
            label1.Size = new Size(238, 28);
            label1.TabIndex = 8;
            label1.Text = "Nghiệm của phương trình\r\n";
            // 
            // Kq
            // 
            Kq.BackColor = SystemColors.Menu;
            Kq.Location = new Point(412, 82);
            Kq.Multiline = true;
            Kq.Name = "Kq";
            Kq.Size = new Size(386, 197);
            Kq.TabIndex = 9;
            Kq.UseWaitCursor = true;
            Kq.TextChanged += Kq_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Kq);
            Controls.Add(label1);
            Controls.Add(Thoat);
            Controls.Add(Giai);
            Controls.Add(hsc);
            Controls.Add(HS3);
            Controls.Add(hsb);
            Controls.Add(HS2);
            Controls.Add(hsa);
            Controls.Add(HS1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HS1;
        private TextBox hsa;
        private Label HS2;
        private TextBox hsb;
        private Label HS3;
        private TextBox hsc;
        private Button Giai;
        private Button Thoat;
        private Label label1;
        private TextBox Kq;
    }
}