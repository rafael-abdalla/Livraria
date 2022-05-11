using System.ComponentModel.DataAnnotations;

namespace Livraria.Api.DTOs
{
    public class InserirLivroDto
    {
        [Required, MaxLength(250)]
        public string? Titulo { get; set; }

        [MaxLength(150)]
        public string? Autor { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Display(Name = "Data de publicação")]
        public DateTime? DataPublicacao { get; set; }
    }
}
