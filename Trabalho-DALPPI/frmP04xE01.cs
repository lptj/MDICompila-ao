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
    public partial class frmP04xE01 : Form
    {
        public frmP04xE01()
        {
            InitializeComponent();
        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            Utilitarios objSoma = new Utilitarios();
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            int numero3 = Convert.ToInt32(txtN3.Text);
            int numero4 = Convert.ToInt32(txtN4.Text);
            int numero5 = Convert.ToInt32(txtN5.Text);
            int numero6 = Convert.ToInt32(txtN6.Text);
            int numero7 = Convert.ToInt32(txtN7.Text);
            int numero8 = Convert.ToInt32(txtN8.Text);
            int total = objSoma.recebernum(numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8);
            MessageBox.Show("O total é: " + total);
        }
    }
}
