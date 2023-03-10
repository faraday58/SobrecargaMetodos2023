using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SobrecargaMetodos2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lbSuma.Text = Sumar(float.Parse(txtbSumando1.Text),float.Parse( txtbSumando2.Text)).ToString();

        }

        private float Sumar(float sumando1, float sumando2)
        {
            return sumando1 + sumando2;
        }

        private float Sumar(float sumando1, float sumando2, float sumando3 )
        {
            return sumando1 + sumando2 + sumando3;
        }

        private void btnSuma2_Click(object sender, EventArgs e)
        {
            lbSuma2.Text = Sumar(float.Parse(txtbSumando21.Text),float.Parse( txtbSumando22.Text), float.Parse(txtbsumando23.Text)).ToString();
        }
    }
}
