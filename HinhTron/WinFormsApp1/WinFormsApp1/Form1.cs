namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double r;
        public double pi = 3.14;
        private void Chuvi_Click(object sender, EventArgs e)
        {
            r = 0;
            bool result = double.TryParse(textBox1.Text, out r);
            if (!result)
            {
                KetQua.Text = "Không phải giá trị số. Xin nhập lại!!!";
            }
            else
            {
                if (r <0) 
                {
                    KetQua.Text = "Bán kính không thể nhận giá trị âm. Xin nhập lại!!!";
                }
                else
                {
                    double chuvi = 2 * r * pi;
                    KetQua.Text = "Chu vi = " + chuvi.ToString(); 
                }
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Dientich_Click(object sender, EventArgs e)
        {
            bool result = double.TryParse(textBox1.Text, out r);
            if (!result)
            {
                KetQua.Text = "Không phải giá trị số. Xin nhập lại!!!";
            }
            else
            {
                if (r <0) 
                {
                    KetQua.Text = "Bán kính không thể nhận giá trị âm. Xin nhập lại!!!";
                }
                else
                {
                    if (r > 0) 
                    {
                        double S = r * r * pi;
                        KetQua.Text ="Dien tich =" + S.ToString();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}