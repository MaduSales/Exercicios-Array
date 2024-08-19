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
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }
        int[] numeros = new int[4];
        int indice = 0;
        int total = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (indice < numeros.Length)
            {
                numeros[indice] = Convert.ToInt32(txtNumero.Text);

                total += numeros[indice];
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
        }
    }
}
