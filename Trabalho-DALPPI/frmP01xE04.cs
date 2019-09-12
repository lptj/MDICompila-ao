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
    public partial class frmP01xE04 : Form
    {
        public frmP01xE04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Utilitarios divisivel = new Utilitarios();
            MessageBox.Show(divisivel.DivisivelTres(Convert.ToInt32(txtNumero.Text)));
        }
    }
}
