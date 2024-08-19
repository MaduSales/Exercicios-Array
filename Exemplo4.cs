using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class Exemplo4 : Form
    {
        public Exemplo4()
        {
            InitializeComponent();
        }
        int[] numeros = new int[4];
        int indice = 0, total;
        int menor = int.MaxValue; // Começa com o maior valor possível para garantir que qualquer número seja menor
        int maior = int.MinValue; // Começa com o menor valor possível para garantir que qualquer número seja maior
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (indice < numeros.Length) { 

                int numero = int.Parse(txtNumero.Text);
                numeros[indice] = numero; 
                
                total += numeros[indice];

                if (numero < menor)
                {
                    menor = numero;
                }

                if (numero > maior)
                {
                    maior = numero;
                }

                indice++;

                MessageBox.Show("Agora o índice é " + indice);

                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                btnAdicionar.Enabled = false;
            }



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = total.ToString();

            txtMenor.Text = menor.ToString();
            txtMaior.Text = maior.ToString();
        }
    }
}
