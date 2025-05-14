namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnIgual = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnC = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            button15 = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 15F);
            txtResultado.Location = new Point(12, 12);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(218, 40);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUm
            // 
            btnUm.BackColor = SystemColors.GradientInactiveCaption;
            btnUm.Location = new Point(12, 130);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(50, 50);
            btnUm.TabIndex = 1;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = SystemColors.GradientInactiveCaption;
            btnDois.Location = new Point(68, 130);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(50, 50);
            btnDois.TabIndex = 2;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.GradientInactiveCaption;
            btnTres.Location = new Point(124, 130);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(50, 50);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = SystemColors.GradientInactiveCaption;
            btnSoma.Location = new Point(180, 74);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(50, 50);
            btnSoma.TabIndex = 4;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = SystemColors.GradientInactiveCaption;
            btnSubtracao.Location = new Point(180, 130);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(50, 50);
            btnSubtracao.TabIndex = 8;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.GradientInactiveCaption;
            btnSeis.Location = new Point(124, 186);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(50, 50);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.GradientInactiveCaption;
            btnCinco.Location = new Point(68, 186);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(50, 50);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = SystemColors.GradientInactiveCaption;
            btnQuatro.Location = new Point(12, 186);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(50, 50);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.GradientInactiveCaption;
            btnIgual.Location = new Point(180, 242);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(50, 106);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = SystemColors.GradientInactiveCaption;
            btnNove.Location = new Point(124, 242);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(50, 50);
            btnNove.TabIndex = 11;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = SystemColors.GradientInactiveCaption;
            btnOito.Location = new Point(68, 242);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(50, 50);
            btnOito.TabIndex = 10;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = SystemColors.GradientInactiveCaption;
            btnSete.Location = new Point(12, 242);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(50, 50);
            btnSete.TabIndex = 9;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.GradientInactiveCaption;
            btnZero.Location = new Point(12, 298);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(106, 50);
            btnZero.TabIndex = 13;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = SystemColors.GradientInactiveCaption;
            btnVirgula.Location = new Point(124, 298);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(50, 50);
            btnVirgula.TabIndex = 14;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.GradientInactiveCaption;
            btnC.Location = new Point(12, 74);
            btnC.Name = "btnC";
            btnC.Size = new Size(50, 50);
            btnC.TabIndex = 16;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = SystemColors.GradientInactiveCaption;
            btnDivisao.Location = new Point(124, 74);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(50, 50);
            btnDivisao.TabIndex = 17;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = SystemColors.GradientInactiveCaption;
            btnMultiplicacao.Location = new Point(180, 186);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(50, 50);
            btnMultiplicacao.TabIndex = 18;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.GradientInactiveCaption;
            button15.Location = new Point(68, 74);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 15;
            button15.Text = "<";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(17, 25);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(239, 356);
            Controls.Add(lblOperacao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnC);
            Controls.Add(button15);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnIgual);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnSoma);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnIgual;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnC;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button button15;
        private Label lblOperacao;
    }
}
