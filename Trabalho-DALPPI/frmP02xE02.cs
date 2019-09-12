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
    public partial class frmP02xE02 : Form
    {
        public frmP02xE02()
        {
            InitializeComponent();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Utilitarios objDiferenca = new Utilitarios();

            int resultado = objDiferenca.Diferenca(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
            MessageBox.Show("A diferença entre o maior e o menor é: " + resultado);
        }
    }
}
