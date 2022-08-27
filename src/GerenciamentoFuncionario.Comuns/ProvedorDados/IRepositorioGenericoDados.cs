using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface IRepositorioGenericoDados<T> where T : class
    {
        IList<T> RecuperaTodos(params Expression<Func<T, object>>[] propriedadesNavegacao);
        IList<T> Recupera(Expression<Func<T, bool>> clausulaWhere = null, Func<IQueryable<T>, IOrderedQueryable<T>> ordenarPor = null, string propriedadesNavegacao = "");
        T RecuperaUnico(Func<T, bool> clausulaWhere, params Expression<Func<T, object>>[] propriedadesNavegacao);
        void Adicionar(params T[] itens);
        void Atualizar(params T[] itens);
        void Remover(params T[] itens);
    }
}
