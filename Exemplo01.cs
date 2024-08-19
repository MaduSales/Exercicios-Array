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
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        int[] numeros = new int[4];
        int indice = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (indice < numeros.Length)
            {
                numeros[indice] = Convert.ToInt32(txtNumero.Text);
                indice++;

                txtNumero.Clear();
                txtNumero.Focus(); // Tenta mover o foco do teclado para aquele controle, permitindo que o usuário interaja diretamente com ele.

                MessageBox.Show("Agora o índice é " + indice);
            }
            else
            {
                btnAdicionar.Enabled = false; // Quando Enabled é false, o controle está desabilitado, o que significa que ele aparece esmaecido (normalmente em cinza) e o usuário não pode clicar ou interagir com ele.
            }


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            for (indice = 0; indice < numeros.Length; indice++)
            {
                listNumeros.Items.Add(numeros[indice]);
            }
        }
    }
}
