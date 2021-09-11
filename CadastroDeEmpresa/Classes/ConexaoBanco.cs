using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CadastroDeEmpresa.Classes
{
    public class ConexaoBanco
    {
        string _conStr = string.Empty;
        public ConexaoBanco()
        {
            this._conStr = "Server=localhost;Port=3306;Database=projeto;Uid=root;Pwd=root";
        }
        public Empresa procurarCNPJ(string CNPJ)
        {
            return this.select("SELECT E.CNPJ, E.nome, E.telefone, E.email, E.fantasia, E.capital_social, E.situacao, T.descricao as Tipo, EN.logradouro, EN.bairro, EN.numero, EN.complemento, EN.uf, EN.cep, EN.municipio FROM Empresa E " +
                                "LEFT JOIN TipoEmpresa T ON T.IdTipo = E.IdTipo " +
                                "LEFT JOIN Endereco EN ON EN.IdEndereco = E.IdEndereco " +
                                "WHERE E.CNPJ = " + CNPJ);
        }

        public Empresa select(string query)
        {
            MySqlConnection _con = new MySqlConnection(this._conStr);
            DataTable _table = new DataTable();
            using (MySqlDataAdapter _adp = new MySqlDataAdapter(query, _con))
            {
                int v = _adp.Fill(_table);
            }
            _con.Close();
            _table = GenerateTransposedTable(_table);

            return dataTableToEmpresa(_table);
        }

        public void inserir(Empresa e, string CNPJ)
        {
            MySqlConnection _con = new MySqlConnection(this._conStr);
            _con.Open();

            this.inserirEndereco(e, _con);

            foreach (Atividades a in e.atividade_principal)
                this.inserirAtividade(a, CNPJ, _con);

            foreach (Atividades a in e.atividades_secundarias)
                this.inserirAtividade(a, CNPJ, _con);

            this.inserirEmpresa(e, CNPJ, _con);

            _con.Close();
        }
        private void inserirEmpresa(Empresa e, string CNPJ, MySqlConnection _con)
        {
            string queryEmpresa = "INSERT INTO Empresa VALUES('" + CNPJ + "','" + e.nome + "','" + e.telefone + "','" + e.email + "','" + e.natureza_juridica + "','" + e.fantasia + "'," + e.capital_social + ",'" + e.situacao + "',NULL,NULL,NULL);";
            MySqlCommand command = new MySqlCommand(queryEmpresa, _con);
            command.ExecuteNonQuery();
        }
       
        private void inserirEndereco(Empresa e, MySqlConnection _con)
        {
            try
            {
                string queryEndereco = "INSERT INTO Endereco VALUES (NULL,'" + e.logradouro + "','" + e.bairro + "'," + e.numero + ",'" + e.complemento + "','" + e.uf + "','" + e.cep + "','" + e.municipio + "');";
                MySqlCommand command = new MySqlCommand(queryEndereco, _con);
                command.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        private void inserirAtividade(Atividades at, string CNPJ, MySqlConnection _con)
        {
            try
            {
                string queryAtividade = "INSERT INTO Atividade VALUES (" + at.code + "," + at.text + ");";
                MySqlCommand command = new MySqlCommand(queryAtividade, _con);
                command.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public void remover(string CNPJ)
        {
            MySqlConnection _con = new MySqlConnection(this._conStr);
            _con.Open();
            removerAtividadesSecundarias(CNPJ, _con);
            removerADM(CNPJ, _con);
            removerEmpresa(CNPJ, _con);
            _con.Close();

        }

        internal void inserir(Empresa e, object text)
        {
            throw new NotImplementedException();
        }

        private void removerAtividadesSecundarias(string CNPJ, MySqlConnection _con)
        {
            string query = "DELETE FROM atividades_secundarias WHERE CNPJ = " + CNPJ;
            MySqlCommand command = new MySqlCommand(query, _con);
            command.ExecuteNonQuery();
        }

        private void removerADM(string CNPJ, MySqlConnection _con)
        {
            string query = "DELETE FROM administracao WHERE CNPJ = " + CNPJ;
            MySqlCommand command = new MySqlCommand(query, _con);
            command.ExecuteNonQuery();
        }
        private void removerEmpresa(string CNPJ, MySqlConnection _con)
        {
            string query = "DELETE FROM Empresa WHERE CNPJ = " + CNPJ;
            MySqlCommand command = new MySqlCommand(query, _con);
            command.ExecuteNonQuery();
        }

        private DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            foreach (DataRow inRow in inputTable.Rows)
            {
                string newColName = inRow[0].ToString();
                outputTable.Columns.Add(newColName);
            }

            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();
                newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    newRow[cCount + 1] = colValue;
                }
                outputTable.Rows.Add(newRow);
            }

            return outputTable;
        }

        private Empresa dataTableToEmpresa(DataTable tabela)
        {
            Empresa retorno = new Empresa();
            try
            {
                retorno.nome = tabela.Rows[0][1].ToString();
                retorno.telefone = tabela.Rows[1][1].ToString();
                retorno.email = tabela.Rows[2][1].ToString();
                retorno.fantasia = tabela.Rows[3][1].ToString();
                retorno.capital_social = tabela.Rows[4][1].ToString();
                retorno.situacao = tabela.Rows[5][1].ToString();
                retorno.tipo = tabela.Rows[6][1].ToString();
                retorno.logradouro = tabela.Rows[7][1].ToString();
                retorno.bairro = tabela.Rows[8][1].ToString();
                retorno.numero = tabela.Rows[9][1].ToString();
                retorno.complemento = tabela.Rows[10][1].ToString();
                retorno.uf = tabela.Rows[11][1].ToString();
                retorno.cep = tabela.Rows[12][1].ToString();
                retorno.municipio = tabela.Rows[13][1].ToString();
                retorno.status = "OK";
            }
            catch (Exception)
            {
                retorno.status = "ERRO";
                retorno.message = "CNPJ INVALIDO OU NÃO ENCONTRADO";
            }

            return retorno;
        }
    }
}
