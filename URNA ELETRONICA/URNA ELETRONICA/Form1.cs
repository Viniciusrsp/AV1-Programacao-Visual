using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URNA_ELETRONICA
{
    public partial class Form1 : Form
    {
        // Dicionário de candidatos
        Dictionary<string, (string nome, string imagem, int votos)> candidatos = new Dictionary<string, (string nome, string imagem, int votos)>()
        {
            { "13", ("Lula", "Imagens/lula.jpg", 0) },
            { "22", ("Bolsonaro", "Imagens/bolsonaro.jpg", 0) },
            { "12", ("Ciro Gomes", "Imagens/ciro.jpg", 0) }
        };

        // Contadores de votos
        int votosBranco = 0;
        int votosNulos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Função para adicionar número ao TextBox
        private void AdicionarNumero(string numero)
        {
            if (txtNumero.Text.Length < 2)
            {
                txtNumero.Text += numero;
                if (txtNumero.Text.Length == 2)
                {
                    MostrarCandidato(txtNumero.Text);
                }
            }
        }

        // Função para exibir o candidato
        private void MostrarCandidato(string numero)
        {
            if (candidatos.ContainsKey(numero))
            {
                var candidato = candidatos[numero];
                lblCandidato.Text = "Candidato: " + candidato.nome;
                string caminhoImagem = Path.Combine(Application.StartupPath, candidato.imagem);
                if (File.Exists(caminhoImagem))
                {
                    picFoto.Image = Image.FromFile(caminhoImagem);
                }
                else
                {
                    picFoto.Image = null;
                }
            }
            else
            {
                lblCandidato.Text = "Número inválido";
                picFoto.Image = null;
            }
        }

        // Botões numéricos
        private void btn0_Click_1(object sender, EventArgs e) => AdicionarNumero("0");
        private void btn1_Click(object sender, EventArgs e) => AdicionarNumero("1");
        private void btn2_Click(object sender, EventArgs e) => AdicionarNumero("2");
        private void btn3_Click(object sender, EventArgs e) => AdicionarNumero("3");
        private void btn4_Click(object sender, EventArgs e) => AdicionarNumero("4");
        private void btn5_Click(object sender, EventArgs e) => AdicionarNumero("5");
        private void btn6_Click(object sender, EventArgs e) => AdicionarNumero("6");
        private void btn7_Click(object sender, EventArgs e) => AdicionarNumero("7");
        private void btn8_Click(object sender, EventArgs e) => AdicionarNumero("8");
        private void btn9_Click(object sender, EventArgs e) => AdicionarNumero("9");

        // Botão Corrige
        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lblCandidato.Text = "";
            picFoto.Image = null;
        }

        // Botão Branco
        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "BRANCO";
            lblCandidato.Text = "Voto em Branco";
            picFoto.Image = null;
        }

        // Botão Confirma
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string voto = txtNumero.Text;

            if (voto == "BRANCO")
            {
                votosBranco++;
                MessageBox.Show("Voto em branco confirmado!");
            }
            else if (candidatos.ContainsKey(voto))
            {
                candidatos[voto] = (candidatos[voto].nome, candidatos[voto].imagem, candidatos[voto].votos + 1);
                MessageBox.Show("Voto confirmado para " + candidatos[voto].nome);
            }
            else
            {
                votosNulos++;
                MessageBox.Show("Voto nulo!");
            }

            txtNumero.Text = "";
            lblCandidato.Text = "";
            picFoto.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
