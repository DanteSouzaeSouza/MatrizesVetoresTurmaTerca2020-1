using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizesVetoresTurmaTerca2020_1
{
    public partial class FrmVetorMatriz : Form
    {
        public FrmVetorMatriz()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            // declarando um vetor de 10 posições e instanciando
            int[] vetor = new int[10];

            // Limpando a listBox
            lstVetor.Items.Clear();

            // Atribuir os valores à ListBox usando FOR
            for (int i = 0; i < 10; i++)
            {
                //atribuindo o valor de i para o vetor no índice i
                vetor[i] = i;

                // adicionando o item atual ao ListBox
                lstVetor.Items.Add("Vetor índice [" + i + "] = " + vetor[i]);
            }
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            // Limpando o Listbox da matriz
            lstMatriz.Items.Clear();

            // variáveis para acessar as posições dos índices da matriz
            // linha - representa linha
            // coluna - representa coluna

            int linha, coluna;

            //declara a variável numeros com 5 linhas e 4 colunas

            int[,] numeros = new int[5, 4];    //dimensão da matriz 5 x 4

            // atribuindo os valores à matriz
            for (linha = 0; linha < 5; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    //atribui o valor à posição [linha, coluna] como linha * coluna
                    numeros[linha, coluna] = linha * coluna;  
                }
            }

            //exibindo os dados no ListBox
            // percorrendo as linha da matriz
            for (linha = 0; linha < 5; linha++)
            { //percorrendo as colunas da matriz
                for (coluna = 0; coluna < 4; coluna++)
                {  // adicionando o texto com os elementos ao ListBox
                    lstMatriz.Items.Add("Elemento = " + "" +
                                        "["+ linha + ", " + coluna + "] é " + 
                                        numeros[linha, coluna]);
                }
            }
        }

        private void lstMatriz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
