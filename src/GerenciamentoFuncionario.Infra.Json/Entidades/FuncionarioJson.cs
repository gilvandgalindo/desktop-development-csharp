using GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json;
using GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Infra.Json.Entidades
{
    public class FuncionarioJson : IFuncionarioJson
    {
        private readonly ManagmentJson<Funcionario> _managmentJson;

        public FuncionarioJson()
        {
            _managmentJson = new ManagmentJson<Funcionario>(@"C:\TestJson\", "Funcionarios");
        }

        public void AtribuiFuncionarios(List<Funcionario> funcionarios)
        {
            _managmentJson.WriteJson(funcionarios);
        }

        public List<Funcionario> RecebeFuncionarios() => _managmentJson.ReadJson();

    }
}
