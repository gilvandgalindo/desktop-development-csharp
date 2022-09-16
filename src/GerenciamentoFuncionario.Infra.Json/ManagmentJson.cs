using GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GerenciamentoFuncionario.Infra.Json
{
    public class ManagmentJson<T> : IManagmentJson<T> where T : class
    {
        public ManagmentJson(string basePath, string fileName)
        {
            _jsonFile = @$"{basePath}{fileName}.json";
            CreateDirectory(basePath);
            CreateJsonFile();
        }

        private void CreateDirectory(string basePath)
        {
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);
        }

        private readonly string _jsonFile;

        public List<T> ReadJson() => JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(_jsonFile));

        public void WriteJson(List<T> list)
        {
            string output = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(_jsonFile, output);
        }

        private void CreateJsonFile()
        {
            if (!File.Exists(_jsonFile)) File.CreateText(_jsonFile);
        }

        private void RemoveJsonFile() => File.Delete(_jsonFile);

    }
}
