using GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json;
using GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Infra.Json.Entidades
{
    public class CargoJson : ICargoJson
    {
        private readonly ManagmentJson<Cargo> _managmentJson;

        public CargoJson()
        {
            _managmentJson = new ManagmentJson<Cargo>(@"C:\TestJson\", "Cargos");
        }

        public void AtribuiCargos(List<Cargo> cargos) => _managmentJson.WriteJson(cargos);

        public List<Cargo> RecebeCargos() => _managmentJson.ReadJson();

    }
}
