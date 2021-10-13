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
    public partial class Ketqua : Form
    {
        private string tinkq;
        public Ketqua(string tinkq)
        {
            InitializeComponent();
            this.tinkq = tinkq;
            this.CenterToScreen();
        }

        private void Ketqua_Load(object sender, EventArgs e)
        {
            txt_tinkq.Text = tinkq;
            txt_tinkq.Select(0, 0);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
