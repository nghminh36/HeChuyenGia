using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeChuanDoanBenh
{
    public partial class Anh : Form
    {
        public Anh()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        List<Image> listImage = new List<Image>();
        int number = 0;

        private void hinhanh()
        {
            string source = Application.StartupPath.ToString();
            listImage.Add(Image.FromFile(source + "Image\\C:\\5.jpg"));
        }
        public void xuatmanhinh(int index)
        {
            hinhanh();
            pictureBox1.Image = listImage[index];
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void layanh(int value)
        {
            number = value;
        }
        private void Anh_Load(object sender, EventArgs e)
        {
            xuatmanhinh(number);
        }
    }
}
