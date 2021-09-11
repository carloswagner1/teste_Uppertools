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
    public partial class frmBuscarCadastro : Form
    {
        public frmBuscarCadastro()
        {
            InitializeComponent();
        }
        /*Empresa e = null;
        BuscarEmpresa ee = new BuscarEmpresa();*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbtnCNPJ.Checked == true)
            {
                string cnpj = mskbxCNPJBuscar.Text;
                bool valid = N2.ValidateCNPJ(cnpj);

                if (valid)
                {
                    ConexaoBanco cb = new ConexaoBanco();
                    _ = cb.select(cnpj);
                }
                else
                {
                    lblStatusB.Text = "CNPJ invalido";
                    mskbxCNPJBuscar.Clear();
                }

            }
            if(rdbtnNomeBuscar.Checked == true)
            {
                string nome = txbxNomeBuscar.Text;
                if(nome == "")
                {
                    lblStatusB.Text = "Campo Vazio";
                }
                else
                {
                    ConexaoBanco cb = new ConexaoBanco();
                    _ = cb.select(nome);
                }
            }        

        }
    }
}
