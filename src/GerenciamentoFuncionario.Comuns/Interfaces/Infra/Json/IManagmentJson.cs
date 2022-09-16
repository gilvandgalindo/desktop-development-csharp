using System.Collections.Generic;

namespace GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json
{
    public interface IManagmentJson<T>
    {
        List<T> ReadJson();
        void WriteJson(List<T> list);
    }
}
