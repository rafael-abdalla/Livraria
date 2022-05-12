using Livraria.Application.DTOs.Request;
using Livraria.Domain.Entities;
using Livraria.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILogger<LivroController> _logger;
        private readonly ILivroRepository _repository;

        public LivroController(ILivroRepository repository, ILogger<LivroController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            try
            {
                var response = await _repository.ObterTodos();
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] InserirLivroRequest request)
        {
            try
            {
                var livro = new Livro(Guid.NewGuid(), request.Titulo, request.Autor, request.Quantidade, request.Preco, request.DataPublicacao);
                await _repository.Inserir(livro);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
    }
}
