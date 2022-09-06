using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        private readonly Contexto _contexto;

        public FuncionarioProvedorDados()
        {
            _contexto = new Contexto();
        }

        public void AtualizaFuncionario(Funcionario funcionarioAtualizado)
        {
            _contexto.Funcionarios.ForEach(f => 
            {
                if(f.Id == funcionarioAtualizado.Id)
                {
                    f.NomeCompleto = funcionarioAtualizado.NomeCompleto;
                    //f.PrimeiroNome = funcionarioAtualizado.PrimeiroNome;
                    //f.UltimoNome = funcionarioAtualizado.UltimoNome;
                    //f.CargoId = funcionarioAtualizado.CargoId;
                    //f.EBebedorCafe = funcionarioAtualizado.EBebedorCafe;
                }
            });

        }

        public void ExcluiFuncionarioPorId(int id)
        {
            var funcionario = RecuperaFuncionarioPorId(id);
            ExcluiFuncionario(funcionario);
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            _contexto.Funcionarios.Remove(funcionario);
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            return _contexto.Funcionarios.Find(x => x.Id == id);
            //return _contexto.Funcionarios.FirstOrDefault(x => x.Id == id);
            //return _contexto.Funcionarios.Where(x => x.Id == id).FirstOrDefault();
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            Debug.WriteLine($"Funcionário salvo: {funcionario.PrimeiroNome}");
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            return _contexto.Funcionarios;
        }
    }
}
