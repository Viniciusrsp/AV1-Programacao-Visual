using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace urna
{
    public partial class Form1 : Form
    {

        string num;

        int candidato10, candidato20, candidato30, branco, nulo;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnNumero(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDireita.Text = txtDireita.Text + bt.Text;

        }
        private void txtDireita_TextChanged(object sender, EventArgs e)
        {
            num = txtDireita.Text;

            if (num == "7")
            {
                pictureBox1.Image = Properties.Resources.Ronaldo;
                lblNomeCandidato.Text = "Ronaldo";

            }

            else if (num == "10")
            {
                pictureBox1.Image = Properties.Resources.Messi;
                lblNomeCandidato.Text = "Messi";
            }

            else if (num == "11")
            {
                pictureBox1.Image = Properties.Resources.Neymar;
                lblNomeCandidato.Text = "Neymar";
            }
            else if (num == "--")
            {
                pictureBox1.Image = Properties.Resources.fundobranco_urna;
                lblNomeCandidato.Text = "Branco";
            }
            else if (num != "1" && num != "2" && num != "3" && num != "4" && num != "5" && num != "6" &&
                  num != "7" && num != "8" && num != "9" && num != "0" & num != "--")
            {
                pictureBox1.Image = Properties.Resources.fundoLARANJA_urna1;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDireita.Text = "";
            lblNomeCandidato.Text = "";
            a = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fundobranco_urna;
            txtDireita.Text = "--";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var resultado = new Form2(candidato10, candidato20, candidato30, branco, nulo);
            resultado.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string ValorDigitado = txtDireita.Text;

            if (ValorDigitado == "7")
            {
                candidato10 += 1;
                txtDireita.Clear();
                lblNomeCandidato.ResetText();
                pictureBox1.Image = Properties.Resources.Ronaldo;
            }
            else if (ValorDigitado == "10")
            {
                candidato20 += 1;
                txtDireita.Clear();
                lblNomeCandidato.ResetText();
                pictureBox1.Image = Properties.Resources.Messi;
            }
            else if (ValorDigitado == "11")
            {
                candidato30 += 1;
                txtDireita.Clear();
                lblNomeCandidato.ResetText();
                pictureBox1.Image = Properties.Resources.Neymar;
            }
            else if (ValorDigitado == "")
            {
                branco += 1;
                txtDireita.Clear();
                lblNomeCandidato.ResetText();
                pictureBox1.Image = Properties.Resources.fundobranco_urna;
            }
            else
            {
                nulo += 1;
                txtDireita.Clear();
                lblNomeCandidato.ResetText();
                pictureBox1.Image = Properties.Resources.fundobranco_urna;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      


    }
}