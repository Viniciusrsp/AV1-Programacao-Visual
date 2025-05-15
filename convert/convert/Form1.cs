using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(txtEntrada.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            lblResultado.Text = $"Resultado: {fahrenheit:F2} °F";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
