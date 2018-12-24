using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANSO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            phanso a, b, c;
            a = new phanso(int.Parse(tbTuSo1.Text), int.Parse(tbMauSo1.Text));
            b = new phanso(int.Parse(tbTuSo2.Text), int.Parse(tbMauSo2.Text));
            if (rd1.Checked)
            {
                c = phanso.Cong(a, b);
            }
            else if (rd2.Checked)
            {
                c = phanso.Tru(a, b);
            }
            else if (rd3.Checked)
            {
                c = phanso.Nhan(a, b);
            }
            else
            {
                c = phanso.Chia(a, b);
            }
            tbTuSo3.Text = c.TuSo.ToString();
            tbMauSo3.Text = c.MauSo.ToString();
        }
    }
}
