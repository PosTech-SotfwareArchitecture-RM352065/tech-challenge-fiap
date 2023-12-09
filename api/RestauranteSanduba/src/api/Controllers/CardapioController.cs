using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestauranteSanduba.Core.Application.Abstraction.Cardapios;
using RestauranteSanduba.Core.Application.Abstraction.Cardapios.Request;
using RestauranteSanduba.Core.Application.Abstraction.Cardapios.Response;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace RestauranteSanduba.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardapioController : ControllerBase
    {
        private readonly ILogger<CardapioController> _logger;
        private readonly ICardapioService _cardapioService;

        public CardapioController(ILogger<CardapioController> logger, ICardapioService cardapioService)
        {
            _logger = logger;
            _cardapioService = cardapioService;
        }

        [HttpGet(Name = "ConsultaCardapio")]
        [SwaggerOperation(
            Summary = "Obtem op��es do card�rpio",
            Description = "Consulta deve retornar os itens ativos do card�rpio",
            OperationId = "Get",
            Tags = new[] { "Cardapio" })]
        [SwaggerResponse(200, "Itens do card�rpio", typeof(List<ConsultaProdutoResponse>))]
        public IActionResult Get()
        {
            return Ok(_cardapioService.ConsultarProdutosAtivos());
        }

        [HttpPost(Name = "CadastraProduto")]
        [SwaggerOperation(
            Summary = "Cadastra novo Produto",
            Description = "Cadastra novo produto no card�rpio",
            OperationId = "Post",
            Tags = new[] { "Cardapio" })]
        [SwaggerResponse(200, "N�mero do Produto", typeof(CadastroProdutoResponse))]
        public IActionResult Post(CadastroProdutoRequest request)
        {
            return Ok(_cardapioService.CadastrarProduto(request));
        }
    }
}