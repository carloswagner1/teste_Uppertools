using CadastroDeEmpresa.Classes;
using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class frmNovoCadastro : Form
    {
        public frmNovoCadastro()
        {
            InitializeComponent();
        }
        Empresa e = null;
        BuscarEmpresa ee = new BuscarEmpresa();

        private void btnPesquisarCNPJ_Click(object sender, EventArgs e)
        {
            mskbxCNPJ.Enabled = false;
            btnPesquisarCNPJ.Enabled = false;
            string cnpj = mskbxCNPJ.Text;
            bool valid = N2.ValidateCNPJ(cnpj);

            if (valid)
            {
                Tuple<Empresa, int> result = this.ee.pesquisar(cnpj);
                gvwDados.DataSource = result.Item1.toDataTable();
                this.e = result.Item1;

                switch (result.Item2)
                {
                    case 0:
                        btnAdd.Enabled = false;
                        btnPesquisarCNPJ.Enabled = true;
                        btnAdd.Enabled = false;
                        mskbxCNPJ.Text = string.Empty;
                        mskbxCNPJ.Enabled = true;
                        lblStatus.Text = "Cadastro já existe no sistema.";
                        break;
                    case 1:
                        btnAdd.Enabled = true;
                        btnPesquisarCNPJ.Enabled = false;
                        lblStatus.Text = "Clique em adicionar para a inclusão do cadastro?";
                        break;
                    default:
                        btnAdd.Enabled = false;
                        btnPesquisarCNPJ.Enabled = false;
                        break;
                }
            }
            else
            {
                lblStatus.Text = "CNPJ invalido";
                mskbxCNPJ.Clear();
                mskbxCNPJ.Enabled = true;
                btnPesquisarCNPJ.Enabled = true;
            }
                
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                btnAdd.Enabled = false;
                ConexaoBanco cb = new ConexaoBanco();
                cb.inserir(this.e, mskbxCNPJ.Text);
                MessageBox.Show("Adicionado ao banco com sucesso");
                mskbxCNPJ.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu falha ao adicionar ao banco de dados");
            }
        }

        private void mskbxCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }

    internal class N2
    {
        internal static bool ValidateCNPJ(string cnpj) => Validate.ValidateCNPJ(cnpj);
    }
}
