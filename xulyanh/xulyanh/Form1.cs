using System.Windows.Forms;

namespace xulyanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mo_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog mofile = new OpenFileDialog();
            mofile.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (mofile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(mofile.FileName);
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string duongdan =@"D:\HUONGDOITUONG\VS\xulyanh\249268301_305076741451655_147907452803681982_n.png";
            pictureBox1.Image = Image.FromFile(duongdan);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}