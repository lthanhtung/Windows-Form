namespace GiaiPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double a;
        public double b;
        public double c;
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsa_TextChanged(object sender, EventArgs e)
        {

        }

        private void hsb_TextChanged(object sender, EventArgs e)
        {

        }

        private void hsc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giai_Click(object sender, EventArgs e)
        {
            a = 0; b = 0; c = 0;
            bool hs_a = double.TryParse(hsa.Text, out a);
            bool hs_b = double.TryParse(hsb.Text, out b);
            bool hs_c = double.TryParse(hsc.Text, out c);
            if (!hs_b)
            {
                Kq.Text = "giá trị b không phải là giá trị số ";
            }
            else if (!hs_c) 
            {
                Kq.Text = "giá trị c không phải là giá trị số ";
            }
            else if (!hs_a) 
            {
                Kq.Text = "giá trị a không phải là giá trị số ";

            }
            
               else if(a == 0) 
                {
                    Kq.Text = "hệ số a không được bằng 0. Vui lòng nhập lại!!!";

                }
                else if ( a < 0)
                {
                    Kq.Text="hệ số a không nhận giá trị <0. Vui lòng nhập lại!!!";
                }
                else
                {
                    double x1;
                    double x2;
                    double denta = b * b - 4 * a * c;
                    if ( denta < 0 )
                    {
                        Kq.Text = "phương trình vô nghiệm";
                    }
                    else if( denta > 0 )
                    {
                        x1 = (-b - Math.Sqrt( denta )) / (2*a);
                        x2 = (-b + Math.Sqrt(denta)) / (2*a);
                        Kq.Text = String.Format("phương trình có 2 nghiệm: x1 = {0}, x2 = {1}", x1.ToString(), x2.ToString());

                    }
                     else if (denta ==  0)
                    {
                        double x = 0;
                        x = -b / (2 * a);
                        Kq.Text = string.Format("nghiệm của phương trình : x1 = x2 ={0}",x.ToString());
                    }

                }
            

        }

        private void Kq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}