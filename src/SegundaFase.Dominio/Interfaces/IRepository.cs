using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SegundaFase.Business.Models;

namespace SegundaFase.Business.Interfaces
{
    //Fornece os métodos necessários para qualquer entidade (Repositório Genérico)
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Adicionar(TEntity entity); // método que adiciona qualquer informação que seja filha de Entity
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        //Bucar entidade por qualquer parâmetro
        Task<int> SaveChanges();

    }
}
