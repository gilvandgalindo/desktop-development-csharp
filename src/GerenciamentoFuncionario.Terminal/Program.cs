using GerenciamentoFuncionario.AcessoDados;
using System;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Terminal
{
    class Program
    {
        static void Main()
        {
            var provedorFuncionario = new FuncionarioProvedorDados();

            var funcionarios = provedorFuncionario.CarregaFuncionarios();
            ApresentaFuncionarios(funcionarios);
            //Console.WriteLine("Hello World!");

            //BUSCA POR ID
            //var funcionarioSelecionado = provedorFuncionario.RecuperaFuncionarioPorId(3);

            //provedorFuncionario.ExcluiFuncionario(funcionarioSelecionado);
            provedorFuncionario.ExcluiFuncionarioPorId(4);
            ApresentaFuncionarios(funcionarios);
        }

        private static void ApresentaFuncionarios(IEnumerable<Comuns.Modelos.Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Id} {funcionario.NomeCompleto}");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\n\n");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
