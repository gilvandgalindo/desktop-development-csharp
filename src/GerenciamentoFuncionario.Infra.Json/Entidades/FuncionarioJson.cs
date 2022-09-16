using GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json;
using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.Override;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Infra.Json.Entidades
{
    public class FuncionarioJson : IFuncionarioJson
    {
        private readonly ManagmentJson<FuncionarioOverride> _managmentJson;

        public FuncionarioJson()
        {
            _managmentJson = new ManagmentJson<FuncionarioOverride>(@"C:\TestJson\", "Funcionarios");
        }

        public void AtribuiFuncionarios(List<Funcionario> funcionarios)
        {
            var funcionariosOverride = new List<FuncionarioOverride>();
            funcionarios?.ForEach(x => funcionariosOverride.Add(
                new FuncionarioOverride
                {
                    Id = x.Id,
                    CargoId = x.CargoId,
                    DataEntrada = x.DataEntrada,
                    EBebedorCafe = x.EBebedorCafe,
                    NomeCompleto = x.NomeCompleto
                }));
            _managmentJson.WriteJson(funcionariosOverride);
        }

        public List<Funcionario> RecebeFuncionarios()
        {
            var funcionarios = new List<Funcionario>();
            _managmentJson.ReadJson()?.ForEach(x => funcionarios.Add(x));
            return funcionarios;
        }

    }
}
