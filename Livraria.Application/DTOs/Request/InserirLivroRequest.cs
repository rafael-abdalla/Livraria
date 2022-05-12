using Livraria.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.DTOs.Request
{
    public class InserirLivroRequest
    {
        [Required(ErrorMessage = "Titulo obrigatório.", AllowEmptyStrings = false), MaxLength(250)]
        public string? Titulo { get; set; }

        [MaxLength(150)]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "Quantidade obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "Informe um valor maior que {1}.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Preço obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "Informe um valor maior que {1}.")]
        public decimal Preco { get; set; }

        [Display(Name = "Data de publicação")]
        public DateTime? DataPublicacao { get; set; }

        public static Livro ConverterParaEntidade(InserirLivroRequest dto)
        {
            return new Livro(Guid.NewGuid(), dto.Titulo, dto.Autor, dto.Quantidade, dto.Preco, dto.DataPublicacao);
        }
    }
}
