using Microsoft.AspNetCore.Mvc;

namespace MeuAppDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("{nome}")]
        public IActionResult Get(string nome)
        {
            return Ok(new { Mensagem = $"Olá, {nome}! Esta é uma API .NET rodando em container." });
        }
    }
}
