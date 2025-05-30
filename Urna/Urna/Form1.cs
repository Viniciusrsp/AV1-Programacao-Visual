using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using urna;

namespace URNA_ELETRONICA
{
    public partial class Form1 : Form
    {
        string num;

        int votosBranco = 0;
        int votosNulos = 0;
        int votos10 = 0;
        int votos7 = 0;
        int votos11 = 0;

        int candidato10, candidato20, candidato30, branco, nulo;
        int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNumero.Text += bt.Text;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            num = txtNumero.Text;

            if (num == "10")
            {
                picFoto.Image = Properties.Resources.Messi;
                lblCandidato.Text = "Messi";

            }

            else if (num == "7")
            {
                picFoto.Image = Properties.Resources.Ronaldo;
                lblCandidato.Text = "Ronaldo";
            }

            else if (num == "11")
            {
                picFoto.Image = Properties.Resources.Neymar;
                lblCandidato.Text = "Neymar";
            }
            else if (num != "1" && num != "2" && num != "3" && num != "4" && num != "5" && num != "6" &&
                  num != "7" && num != "8" && num != "9" && num != "0" & num != "--")
            {
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            var resultado = new Form2(votos10, votos7, votos11, votosBranco, votosNulos);
            resultado.ShowDialog();
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lblCandidato.Text = "";
            picFoto.Image = null;
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "--";
            lblCandidato.Text = "Voto em Branco";
            picFoto.Image = null;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (num == "10")
            {
                votos10++;
                MessageBox.Show("Voto confirmado para Messi");
            }
            else if (num == "7")
            {
                votos7++;
                MessageBox.Show("Voto confirmado para Ronaldo");
            }
            else if (num == "11")
            {
                votos11++;
                MessageBox.Show("Voto confirmado para Neymar");
            }
            else if (num == "--")
            {
                votosBranco++;
                MessageBox.Show("Voto em branco confirmado!");
            }
            else
            {
                votosNulos++;
                MessageBox.Show("Voto nulo!");
            }

            txtNumero.Clear();
            lblCandidato.Text = "";
            picFoto.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
