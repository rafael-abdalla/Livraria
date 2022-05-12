using Livraria.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.DTOs.Request
{
    public class LivroResponse
    {
        [Display(Name = "Título")]
        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Data de publicação")]
        public DateTime? DataPublicacao { get; set; }

        public static LivroResponse ConverterParaResponse(Livro livro)
        {
            return new LivroResponse
            {
                Titulo = livro.Titulo,
                Autor = livro.Autor,
                Quantidade = livro.Quantidade,
                Preco = livro.Preco,
                DataPublicacao = livro.DataPublicacao
            };
        }
    }
}
