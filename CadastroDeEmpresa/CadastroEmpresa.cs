using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeEmpresa
{
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["NovoCadastro"];

            if (fc != null)
                fc.Close();

            frmNovoCadastro NovoCadastro = new frmNovoCadastro();
            NovoCadastro.MdiParent = this;
            NovoCadastro.WindowState = FormWindowState.Maximized;
            NovoCadastro.Show();
        }

        private void buscarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["BuscarCadastro"];

            if (fc != null)
                fc.Close();

            frmBuscarCadastro BuscarCadastro = new frmBuscarCadastro();
            BuscarCadastro.MdiParent = this;
            BuscarCadastro.WindowState = FormWindowState.Maximized;
            BuscarCadastro.Show();
        }

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ExcluirCadastro"];

            if (fc != null)
                fc.Close();

            frmExcluirCadastro ExcluirCadastro = new frmExcluirCadastro();
            ExcluirCadastro.MdiParent = this;
            ExcluirCadastro.WindowState = FormWindowState.Maximized;
            ExcluirCadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
