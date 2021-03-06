using Livraria.Domain.Entities;

namespace Livraria.Domain.Repositories
{
    public interface ILivroRepository : IDisposable
    {
        Task<List<Livro>> ObterTodos();
        Task<Livro?> ObterPorId(Guid id);
        Task Inserir(Livro livro);
        Task Atualizar(Livro livro);
        Task Eliminar(Livro livro);
        Task Eliminar(Guid id);
    }
}
