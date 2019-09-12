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
    public partial class frmP01xE02 : Form
    {
        public frmP01xE02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string pares;

            Utilitarios objPares = new Utilitarios();
            pares = objPares.NumeroPar(Convert.ToInt32(txtNumeroIni.Text),Convert.ToInt32(txtNumeroFin.Text));
            
            MessageBox.Show(pares);
        }
    }
}
