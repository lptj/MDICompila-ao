using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_DALPPI
{
    public partial class frmP03xE03 : Form
    {
        public frmP03xE03()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Utilitarios objLetras = new Utilitarios();
            int resultado = objLetras.ContaLetras(txtFrase.Text.ToLower(), txtLetra.Text.ToLower());

            if (resultado == 0)
            {
                MessageBox.Show("Essa letra não tem na frase!");
            }
            else
            {
                MessageBox.Show("A quantidade da letra, " + txtLetra.Text.ToUpper() + " na frase é: " + resultado);
            }
        }
    }
}
