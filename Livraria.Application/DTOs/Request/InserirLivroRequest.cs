using Livraria.Application.Utils;
using Livraria.Domain.Entities;

namespace Livraria.Application.DTOs.Request
{
    public class InserirLivroRequest : BaseLivroRequest
    {
        public static Livro ConverterParaEntidade(InserirLivroRequest dto)
        {
            return new Livro(Guid.NewGuid(), dto.Titulo, dto.Autor, dto.Quantidade, dto.Preco, Converters.ConverterParaTimeStamp(dto.DataPublicacao));
        }
    }
}
