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
    public partial class Exemplo03 : Form
    {
        public Exemplo03()
        {
            InitializeComponent();
        }

        int linha = 0;
        int coluna = 0;

        int[,] matriz = new int[3, 3];

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            matriz[linha, coluna] = Convert.ToInt32(txtNumero.Text);
            txtNumero.Clear();
            txtNumero.Focus();
            coluna++; // Fará isso: de [0,0], irá para [0,1] e depois [0,2] por conta do incremento

            if (coluna == 3)
            {
                linha++; // Fará isso: de [0,3] irá para [1,0] e depois [1,1]
                coluna = 0;
            }

            if (linha == 3 && coluna == 0)
            {
                btnAdicionar.Enabled = false;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            for (linha = 0; linha < 3; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    listNumeros.Items.Add($"Matriz {linha}, {coluna} = {matriz[linha, coluna]}"); // Vai exibir as posições da linha [0] e da coluna [0] e depois o valor armazenado [0,0] = 1;
                }
            }
        }
    }
}
