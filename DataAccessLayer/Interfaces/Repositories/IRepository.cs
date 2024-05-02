using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Busca todos os registros de uma entidade.
        /// </summary>
        /// <returns>A consulta com todos os registros da entidade.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Busca a entidade correspondente ao <paramref name="id"/> informado.
        /// </summary>
        /// <param name="id">O ID da entidade a ser buscada.</param>
        /// <returns>A entidade correspondente ao <paramref name="id"/> informado.</returns>
        T GetById(int id);

        /// <summary>
        /// Cria a entidade informada no parâmetro (<paramref name="entity"/>).
        /// </summary>
        /// <param name="entity">Entidade a ser criada.</param>
        /// <returns>A entidade do tipo <typeparamref name="T"/> criada.</returns>
        T Create(T entity);

        /// <summary>
        /// Atualiza a entidade informado no parâmetro (<paramref name="entity"/>).
        /// </summary>
        /// <param name="entity">Entidade a ser atualizada.</param>
        /// <returns>A entidade do tipo <typeparamref name="T"/> atualizada.</returns>
        T Update(T entity);

        /// <summary>
        /// Obtém o primeiro registro de uma entidade.
        /// </summary>
        /// <returns>O primeiro registro da entidade.</returns>
        T FirstOrDefault();

        /// <summary>
        /// Exclui a entidade correspondente ao <paramref name="id"/> informado.
        /// </summary>
        /// <param name="id">ID do entity que será excluído.</param>
        void Delete(int id);

    }
}
