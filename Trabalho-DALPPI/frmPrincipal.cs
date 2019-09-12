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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP01xE01 tela = new frmP01xE01();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP01xE02 tela = new frmP01xE02();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP01xE03 tela = new frmP01xE03();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP01xE04 tela = new frmP01xE04();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP01xE05 tela = new frmP01xE05();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmP02xE01 tela = new frmP02xE01();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmP02xE02 tela = new frmP02xE02();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmP02xE03 tela = new frmP02xE03();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmP02xE04 tela = new frmP02xE04();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP02xE05 tela = new frmP02xE05();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmP03xE01 tela = new frmP03xE01();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void exercício3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmP03xE03 tela = new frmP03xE03();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP03xE04 tela = new frmP03xE04();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmP04xE01 tela = new frmP04xE01();
            tela.MdiParent = this;
            tela.Show();
        }

        


    }
}
