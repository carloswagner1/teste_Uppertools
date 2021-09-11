using System;
using System.Reflection;
using System.Data;

namespace CadastroDeEmpresa.Classes
{
    public class Empresa
    {
        public string status { get; set; }
        public string message { get; set; }
        public Atividades[] atividade_principal { get; set; }
        public string data_situacao { get; set; }
        public string complemento { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public Atividades[] atividades_secundarias { get; set; }
        public Administracao[] qsa { get; set; }
        public string situacao { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string municipio { get; set; }
        public string abertura { get; set; }
        public string natureza_juridica { get; set; }
        public string fantasia { get; set; }
        public string cnpj { get; set; }
        public string ultima_atualizacao { get; set; }
        public string capital_social { get; set; }

        public DataTable toDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Propriedade");
            dt.Columns.Add("Valor");
            foreach (PropertyInfo info in typeof(Empresa).GetProperties())
            {
                dt.Rows.Add(info.Name, info.GetValue(this));
            }

            dt.AcceptChanges();
            return dt;
        }
    }
}
