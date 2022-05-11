using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Domain.Entities
{
    [Table(name: "Livro")]
    public class Livro
    {
        public Livro(Guid id, string? titulo, string? autor, int quantidade, decimal preco, DateTime? dataPublicacao)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
            DataPublicacao = dataPublicacao;
        }

        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public Guid Id { get; protected set; }

        [Column("Titulo")]
        [Display(Name = "Título")]
        [Required, MaxLength(250)]
        public string? Titulo { get; private set; }

        [Column("Autor")]
        [Display(Name = "Autor")]
        [MaxLength(150)]
        public string? Autor { get; private set; }

        [Column("Quantidade")]
        [Display(Name = "Quantidade")]
        [Required]
        public int Quantidade { get; private set; }

        [Column("Preco")]
        [Display(Name = "Preço")]
        [Required]
        public decimal Preco { get; private set; }

        [Column("DataPublicacao")]
        [Display(Name = "Data de publicação")]
        public DateTime? DataPublicacao { get; private set; }
    }
}
