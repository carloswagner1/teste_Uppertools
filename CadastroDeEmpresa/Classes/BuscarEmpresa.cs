using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CadastroDeEmpresa.Classes
{
    class BuscarEmpresa
    {
        Requests requests = new Requests();
        ConexaoBanco cb = new ConexaoBanco();

        public Tuple<Empresa, int> pesquisar(string CNPJ)
        {
            Empresa aux = null;

            aux = pesquisarBanco(CNPJ);
            if (!aux.status.Equals("ERRO"))
                return Tuple.Create(aux, 0);

            aux = pesquisarAPI(CNPJ);
            return !aux.status.Equals("ERROR") ? Tuple.Create(aux, 1) : Tuple.Create(aux, 2);
        }

        public Empresa pesquisarBanco(string CNPJ)
        {
            Empresa retorno = this.cb.procurarCNPJ(CNPJ);

            return retorno;
        }

        public Empresa pesquisarAPI(string CNPJ)
        {
            Empresa emp = this.requests.GetEmpresa(CNPJ);

            return emp;
        }
    }
}
