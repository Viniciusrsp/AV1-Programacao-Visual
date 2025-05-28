namespace Calculadora
{
    public partial class Form1 : Form
    {

        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtResultado.Text, out decimal valor))
            {
                OperacaoSelecionada = Operacao.Soma;
                Valor = valor;
                txtResultado.Text = "";
                lblOperacao.Text = "+";
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtResultado.Text, out decimal valor))
            {
                OperacaoSelecionada = Operacao.Subtracao;
                Valor = valor;
                txtResultado.Text = "";
                lblOperacao.Text = "-";
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtResultado.Text, out decimal valor))
            {
                OperacaoSelecionada = Operacao.Multiplicacao;
                Valor = valor;
                txtResultado.Text = "";
                lblOperacao.Text = "x";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtResultado.Text, out decimal valor))
            {
                OperacaoSelecionada = Operacao.Divisao;
                Valor = valor;
                txtResultado.Text = "";
                lblOperacao.Text = "/";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtResultado.Text, out decimal novoValor))
                return;

            switch (OperacaoSelecionada)
            {
                case Operacao.Soma:
                    Resultado = Valor + novoValor;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - novoValor;
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * novoValor;
                    break;
                case Operacao.Divisao:
                    if (novoValor == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero.");
                        return;
                    }
                    Resultado = Valor / novoValor;
                    break;
            }

            txtResultado.Text = Resultado.ToString();
            lblOperacao.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                if (string.IsNullOrWhiteSpace(txtResultado.Text))
                    txtResultado.Text = "0,";
                else
                    txtResultado.Text += ",";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            Resultado = 0;
            Valor = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
        }
    }
}
