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
    public partial class frmP03xE04 : Form
    {
        public frmP03xE04()
        {
            InitializeComponent();
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnVerif_Click(object sender, EventArgs e)
        {
            Utilitarios objAno = new Utilitarios();
            if (txtAno.Text != "")
            {
                string resultado = objAno.AnoBissexto(Convert.ToInt32(txtAno.Text));
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Digite um ano");
            }
        }     
    }
}
