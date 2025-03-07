using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btTinh_Click(object sender, EventArgs e)
        {


            lblKQ.Text = "";
            lbKQ.Items.Clear();
            int so = Int32.Parse(nubBangCuuChuong.Value.ToString());
            for (int i = 1; i < 11; i++)
            {
                lblKQ.Text += so + " x " + i + " = " + so * i + Environment.NewLine;
                lbKQ.Items.Add(so + " x " + i + " = " + so * i + Environment.NewLine);

            }
        }

        private void lbKQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            lbKQ.Items.Clear();
            int so = Int32.Parse(nubBangCuuChuong.Value.ToString());
            for (int i = 1; i < 11; i++)
            {
                lblKQ.Text += so + " x " + i + " = " + so * i + Environment.NewLine;
                lbKQ.Items.Add(so + " x " + i + " = " + so * i + Environment.NewLine);
            }
        }

        private void nubBangCuuChuong_ValueChanged(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            lbKQ.Items.Clear();
            int so = Int32.Parse(nubBangCuuChuong.Value.ToString());
            for (int i = 1; i < 11; i++)
            {
                lblKQ.Text += so + " x " + i + " = " + so * i + Environment.NewLine;
                lbKQ.Items.Add(so + " x " + i + " = " + so * i + Environment.NewLine);
            }
        }
    }
}
