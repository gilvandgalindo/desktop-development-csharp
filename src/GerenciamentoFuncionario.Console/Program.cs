using GerenciamentoFuncionario.AcessoDados;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Console
{
    class Program
    {
        static void Main()
        {
            var provedorFuncionario = new FuncionarioProvedorDados();
            var provedorCargo = new CargoProvedorDados();

            provedorFuncionario.CarregaFuncionarios();
            ApresentaFuncionarios(provedorFuncionario.CarregaFuncionarios());

            //CRIAR FUNCIONARIOS
            provedorCargo.SalvaCargo("Developer");
            provedorCargo.SalvaCargo("Engenheiro");
            provedorCargo.SalvaCargo("Analise");

            //CRIAR FUNCIONARIOS
            provedorFuncionario.SalvaFuncionario("Fulano de Tal", provedorCargo.RecuperaCargoPorNome("Developer").Id, false);
            provedorFuncionario.SalvaFuncionario("Ciclano de Tal", provedorCargo.RecuperaCargoPorNome("Engenheiro").Id, true);
            provedorFuncionario.SalvaFuncionario("Beltrano de Tal", provedorCargo.RecuperaCargoPorNome("Analise").Id, true);

            ApresentaFuncionarios(provedorFuncionario.CarregaFuncionarios());

            //BUSCA POR ID
            var funcionarioSelecionado = provedorFuncionario.RecuperaFuncionarioPorId(3);

            //EXCLUI FUNCIONARIO
            provedorFuncionario.ExcluiFuncionario(funcionarioSelecionado);
            //provedorFuncionario.ExcluiFuncionarioPorId(4);

            ApresentaFuncionarios(provedorFuncionario.CarregaFuncionarios());

            //BUSCA POR ID
            funcionarioSelecionado = provedorFuncionario.RecuperaFuncionarioPorId(2);

            //ATUALIZA FUNCIONARIO
            funcionarioSelecionado.NomeCompleto = "bla bla tla";
            funcionarioSelecionado.NaoEBebedorDeCafe();
            funcionarioSelecionado.SetCargoId(2);
            provedorFuncionario.AtualizaFuncionario(funcionarioSelecionado);

            ApresentaFuncionarios(provedorFuncionario.CarregaFuncionarios());
        }

        private static void ApresentaFuncionarios(IEnumerable<Comuns.Modelos.Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                System.Console.WriteLine($"{funcionario.Id} - {funcionario.NomeCompleto} - {funcionario.EBebedorCafe} | {funcionario.CargoId} ");
                System.Console.WriteLine("----------------------------------------------");
                System.Console.WriteLine("\n\n");
            }

            System.Console.ReadKey();
            System.Console.Clear();
        }

    }
}
