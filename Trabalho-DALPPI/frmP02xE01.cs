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
    public partial class frmP02xE01 : Form
    {
        public frmP02xE01()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Utilitarios objDobroMetade = new Utilitarios();
            var retorno = objDobroMetade.DobroMetade(Convert.ToDouble(txtNumero.Text));
            MessageBox.Show(retorno.Item1 + retorno.Item2);            
        }
    }
}
