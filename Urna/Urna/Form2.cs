using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urna
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int votos10, int votos7, int votos11, int votosBranco, int votosNulos)
        {
            InitializeComponent();

            label1.Text = $"Messi: {votos10}";
            label2.Text = $"Ronaldo: {votos7}";
            label3.Text = $"Neymar: {votos11}";
            label4.Text = $"branco: {votosBranco}";
            label5.Text = $"Nulo: {votosNulos}";
        }
    }
}