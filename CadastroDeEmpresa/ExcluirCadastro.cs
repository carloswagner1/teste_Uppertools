using CadastroDeEmpresa.Classes;
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
    public partial class frmExcluirCadastro : Form
    {
        public frmExcluirCadastro()
        {
            InitializeComponent();
        }
        Empresa e = null;
        BuscarEmpresa ee = new BuscarEmpresa();
        private void btnPesquisarCNPJEx_Click(object sender, EventArgs e)
        {
            mskbxCNPJEx.Enabled = false;
            btnPesquisarCNPJEx.Enabled = false;
            string cnpj = mskbxCNPJEx.Text;
            bool valid = N2.ValidateCNPJ(cnpj);

            if (valid)
            {
                Tuple<Empresa, int> result = this.ee.pesquisar(cnpj);
                gvwDados.DataSource = result.Item1.toDataTable();
                this.e = result.Item1;

                switch (result.Item2)
                {
                    case 0:
                        btnExcluir.Enabled = true;
                        btnPesquisarCNPJEx.Enabled = false;
                        lblStatusEx.Text = "Clique em excluir para remover o cadastro?";
                        break;
                    case 1:
                        btnExcluir.Enabled = false;
                        btnPesquisarCNPJEx.Enabled = true;
                        btnExcluir.Enabled = false;
                        mskbxCNPJEx.Text = string.Empty;
                        mskbxCNPJEx.Enabled = true;
                        lblStatusEx.Text = "Cadastro não existe no sistema.";
                        break;
                    default:
                        btnExcluir.Enabled = false;
                        btnPesquisarCNPJEx.Enabled = true;
                        break;
                }
            }
            else
            {
                lblStatusEx.Text = "CNPJ invalido";
                mskbxCNPJEx.Clear();
                mskbxCNPJEx.Enabled = true;
                btnPesquisarCNPJEx.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                btnExcluir.Enabled = false;
                ConexaoBanco cb = new ConexaoBanco();
                cb.remover(mskbxCNPJEx.Text);
                MessageBox.Show("Removido do banco com sucesso");
                mskbxCNPJEx.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu falha ao remover do banco de dados");
            }
        }

        private void mskbxCNPJEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
