using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorrrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a,b);
            ketQua = c.Execture("+");
            txtKQ.Text = ketQua.ToString();
        }

    }
}
