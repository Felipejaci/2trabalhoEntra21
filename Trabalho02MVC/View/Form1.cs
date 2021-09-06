using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho02MVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreecheBotao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnGerarNovo_Click(object sender, EventArgs e)
        {
            //reseta a tabela 
            PreecheBotao();
            dgPontos.Rows.Clear();
            lblPontos.Text = "";
            palavrasUsadas.Clear();
            txtInsira.Clear();
        }

        List<string> palavrasUsadas = new List<string>();
        Model.Usuario uso = new Model.Usuario();

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            bool confere = true;
            //cria a matriz para verificar os pontos
            string[][] matriz = new string[3][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new string[3];
            }
            //matriz recebe os valores
            matriz[0][0] = btn00.Text;
            matriz[0][1] = btn01.Text;
            matriz[0][2] = btn02.Text;
            matriz[1][0] = btn10.Text;
            matriz[1][1] = btn11.Text;
            matriz[1][2] = btn12.Text;
            matriz[2][0] = btn20.Text;
            matriz[2][1] = btn21.Text;
            matriz[2][2] = btn22.Text;

            //confere se a palavra ja foi usada
            foreach (var item in palavrasUsadas)
            {
                if (item == txtInsira.Text)
                {
                    confere = false;
                }
            }

            if (confere == true)
            {
                //adiciona no data grid
                palavrasUsadas.Add(txtInsira.Text);
                uso.palavras = txtInsira.Text;
                uso.pontos = Convert.ToInt32(Control.Controller.ContadorPontos(matriz, txtInsira.Text.ToUpper()));

                dgPontos.Rows.Add(uso.palavras, uso.pontos);
            }
            else if (confere == false)
            {
                MessageBox.Show("Palavra ja usada");
            }
            txtInsira.Clear();
        }

        public void PreecheBotao()
        {
            //preenche o tabuleiro com a função preeche tabuleiro do model
            btn00.Text = Model.Gerador.preencheTabuleiro("A", "D");
            btn01.Text = Model.Gerador.preencheTabuleiro("E", "F");
            btn02.Text = Model.Gerador.preencheTabuleiro("B", "C");
            btn10.Text = Model.Gerador.preencheTabuleiro2("G", "I", "U");
            btn11.Text = Model.Gerador.preencheTabuleiro2("H", "J", "V");
            btn12.Text = Model.Gerador.preencheTabuleiro("K", "L");
            btn20.Text = Model.Gerador.preencheTabuleiro2("M", "O", "Q");
            btn21.Text = Model.Gerador.preencheTabuleiro2("N", "T", "P");
            btn22.Text = Model.Gerador.preencheTabuleiro2("R", "S", "Z");
        }
    }
}
