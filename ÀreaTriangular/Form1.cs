using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÀreaTriangular
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;
            if (txtbase.Text != "" && txtaltura.Text != "")
            {
                n1 = double.Parse(txtbase.Text);
                n2 = double.Parse(txtaltura.Text);
                resultado = (n1 * n2) / 2;
                lblresultado.Text = resultado.ToString();

            }
        }
    }
}
