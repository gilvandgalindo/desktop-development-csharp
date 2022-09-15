using GerenciamentoFuncionario.Comuns.Interfaces.Infra.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.Infra.Json.Entidades
{
    public class FuncionarioJson
    {
        private readonly ManagmentJson _managmentJson;

        public FuncionarioJson(IManagmentJson managmentJson)
        {
            _managmentJson = new ManagmentJson(@"C:\", "Funcionario");
        }
    }
}
