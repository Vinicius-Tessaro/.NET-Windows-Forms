using Jogo_de_dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Jogo_de_dados
{
    public partial class Form1 : Form
    {
        private int valorJogador1, valorJogador2;
        private bool jogaJogador1, jogaJogador2, fimDeJogo;
        private Image[] imagensDado = new Image[7];
        private Random rndDado = new Random();
        public Form1()
        {
            InitializeComponent();
            IniciarImagens();
        }
        private void IniciarImagens()
        {
            imagensDado[0] = Properties.Resources._0;
            imagensDado[1] = Properties.Resources._1;
            imagensDado[2] = Properties.Resources._2;
            imagensDado[3] = Properties.Resources._3;
            imagensDado[4] = Properties.Resources._4;
            imagensDado[5] = Properties.Resources._5;
            imagensDado[6] = Properties.Resources._6;
        }



            private int sortear_dado()
        {
            int val_dado;
            val_dado = rndDado.Next(1, 6);
            return val_dado;
        }



        private void Compara_dados()
        {
            if (valorJogador1 > valorJogador2)
            {
                lblGanhador.Text = "Jogador 1 Ganhou";
            }
            else if (valorJogador2 > valorJogador1)
            {
                lblGanhador.Text = "Jogador 2 Ganhou";
            }
            else
            {
                lblGanhador.Text = "Ocorreu um empate";
            }
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (jogaJogador1)
            {
                valorJogador1 = sortear_dado();
                dado_jogador1.Image = imagensDado[valorJogador1];
                jogaJogador1 = false;
                if (jogaJogador2 == false)
                {
                    Compara_dados();
                    //Os dois jogaram
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (jogaJogador2)
            {
                valorJogador2 = sortear_dado();
                dado_jogador2.Image = imagensDado[valorJogador2];
                jogaJogador2 = false;
                if (jogaJogador1 == false)
                {
                    Compara_dados();
                    //Os dois jogaram
                }
            }
        }
        private void btnReinicia_Click(object sender, EventArgs e)
        {
            jogaJogador1 = true;
            jogaJogador2 = true;
            lblGanhador.Text = " ";
        }

    }
}