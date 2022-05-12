using Livraria.Data.Context;
using Livraria.Domain.Entities;
using Livraria.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly LivrariaContext _context;

        public LivroRepository(LivrariaContext context) =>
            _context = context;

        public async Task Atualizar(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(Livro livro)
        {
            _context.Remove(livro);
            await _context.SaveChangesAsync();
        }

        public async Task Inserir(Livro livro)
        {
            _context.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task<Livro?> ObterPorId(Guid id) =>
            await _context.Livro.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<List<Livro>> ObterTodos() =>
            await _context.Livro.AsNoTracking().ToListAsync();

        public void Dispose() =>
            _context.Dispose();
    }
}
