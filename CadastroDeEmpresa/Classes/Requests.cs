using System;
using System.Net;
using Newtonsoft.Json;
using System.Text.Json;

namespace CadastroDeEmpresa.Classes
{
    public class Requests
    {
        string ApiURL = "https://www.receitaws.com.br/v1/cnpj/";
        public Empresa GetEmpresa(string cnpj)
        {
            Empresa json = null;
            try
            {
                var resposta = new WebClient().DownloadData(ApiURL + cnpj);
                var readOnlySpan = new ReadOnlySpan<byte>(resposta);
                json = System.Text.Json.JsonSerializer.Deserialize<Empresa>(readOnlySpan);
            }
            catch (Exception) { }

            return json;
        }
    }
}
