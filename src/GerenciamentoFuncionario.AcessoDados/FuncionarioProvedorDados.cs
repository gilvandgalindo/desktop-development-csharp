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

        public void AtualizaFuncionario(Funcionario funcionario)
        {
            var listaFuncionariosAtualizada = _contexto.Funcionarios;
            listaFuncionariosAtualizada.Remove(listaFuncionariosAtualizada?.FirstOrDefault(x => x.Id.Equals(funcionario?.Id)));
            listaFuncionariosAtualizada.Add(funcionario);
            _contexto.Funcionarios = listaFuncionariosAtualizada;
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            var listaComFuncionarioExcluido = _contexto.Funcionarios;
            listaComFuncionarioExcluido.Remove(listaComFuncionarioExcluido?.FirstOrDefault(x => x.Id.Equals(funcionario?.Id)));
            _contexto.Funcionarios = listaComFuncionarioExcluido;
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            return _contexto.Funcionarios.Find(x => x.Id.Equals(id));
        }

        public void SalvaFuncionario(string nomeCompleto, int cargoId, bool eBebedorCafe)
        {
            var listaFuncionarioNovo = _contexto.Funcionarios;
            var novoFuncionario = new Funcionario(GeradorDeId(), nomeCompleto, cargoId, eBebedorCafe);
            listaFuncionarioNovo.Add(novoFuncionario);
            _contexto.Funcionarios = listaFuncionarioNovo;
            Debug.WriteLine($"Funcionário salvo: {novoFuncionario.PrimeiroNome}");
        }

        public IEnumerable<Funcionario> CarregaFuncionarios() => _contexto.Funcionarios;

        private int GeradorDeId()
        {
            var maiorId = _contexto.Funcionarios.Any() ? _contexto.Funcionarios.Max(x => x.Id) : 0;
            bool temId;
            do
            {
                maiorId++;
                temId = _contexto.Funcionarios.Any(x => x.Id.Equals(maiorId));
                //temId = _contexto.Funcionarios.Any(x => x.Id == maiorId);
            } while (temId);

            return maiorId;
        }
    }
}
