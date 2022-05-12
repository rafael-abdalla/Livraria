using Livraria.Application.Utils;
using Livraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.DTOs.Request
{
    public class AtualizarLivroRequest : BaseLivroRequest
    {
        [Required(ErrorMessage = "Id obrigatório.")]
        public Guid Id { get; set; }

        public static Livro ConverterParaEntidade(AtualizarLivroRequest dto)
        {
            return new Livro(dto.Id, dto.Titulo, dto.Autor, dto.Quantidade, dto.Preco, Converters.ConverterParaTimeStamp(dto.DataPublicacao));
        }

        public static AtualizarLivroRequest ConverterParaRequest(Livro obj)
        {
            return new AtualizarLivroRequest {
                Id = obj.Id,
                Titulo = obj.Titulo,
                Autor = obj.Autor,
                Quantidade = obj.Quantidade,
                Preco = obj.Preco,
                DataPublicacao = Converters.ConverterParaTimeStamp(obj.DataPublicacao)
            };
        }
    }
}
