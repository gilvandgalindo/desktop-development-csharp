using GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace GerenciamentoFuncionario.Infra.Json
{
    public class ManagmentJson: IManagmentJson
    {
        public ManagmentJson(string basePath, string fileName) => _jsonFile = @$"{basePath}{fileName}.json";

        private readonly string _jsonFile;

        public string ReadJson() => File.ReadAllText(_jsonFile);

        public void WriteJson(JObject jObject)
        {
            string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
            File.WriteAllText(_jsonFile, output);
        }

        public void CreateJsonFile()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveJsonFile()
        {
            throw new System.NotImplementedException();
        }
    }
}
