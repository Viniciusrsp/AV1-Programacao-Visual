﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class Form1 : Form
    {
        Image[] imgCpu = new Image[]
        {
            Properties.Resources.PedraC,
            Properties.Resources.PapelC,
            Properties.Resources.TesouraC
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;
            Jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(bt.Tag));
            Jogada jogadaAdversario = RetornaJogadaDoAdversario();
            Resultado resultado = RetornaGanhador(jogadaJogador, jogadaAdversario);

            if(resultado == Resultado.VitoriaCpu)
            {
                LbPtCpu.Text = (int.Parse(LbPtCpu.Text) + 1) .ToString();
            }
            else if(resultado == Resultado.VitoriaJogador)
            {
                LbPtJogador.Text = (int.Parse(LbPtJogador.Text) + 1).ToString();
            }
        }

        private Jogada RetornaJogadaDoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaDoAdversario()
        {
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            PicCpu.Image = imgCpu[escolha];
            return (Jogada)escolha;
        }

        private Resultado RetornaGanhador(Jogada jogador, Jogada adversario)
        {
            if(jogador == Jogada.Pedra)
            {
                if(adversario == Jogada.Papel)
                {
                    return Resultado.VitoriaCpu;
                }
                else if(adversario == Jogada.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }
            }
            else if(jogador == Jogada.Papel)
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaJogador;
                }
                else if (adversario == Jogada.Tesoura)
                {
                    return Resultado.VitoriaCpu;
                }
            }
            else
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaCpu;
                }
                else if (adversario == Jogada.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empata;
        }
        
    }
    enum Jogada
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }

    enum Resultado
    {
        VitoriaJogador,
        VitoriaCpu,
        Empata
    }
}
