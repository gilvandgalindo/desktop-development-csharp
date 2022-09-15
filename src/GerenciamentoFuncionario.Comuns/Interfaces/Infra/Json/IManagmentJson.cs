using Newtonsoft.Json.Linq;

namespace GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json
{
    public interface IManagmentJson
    {
        string ReadJson();
        void WriteJson(JObject jObject);
        void CreateJsonFile();
        void RemoveJsonFile();
    }
}
