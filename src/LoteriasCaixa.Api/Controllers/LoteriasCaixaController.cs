using System.Threading.Tasks;
using LoteriasCaixa.Services;
using LoteriasCaixa.Common;
using Microsoft.AspNetCore.Mvc;

namespace LoteriasCaixa.Api.Controllers
{
    [Route("api/[controller]")]
    public class LoteriasCaixaController : Controller
    {
        // GET: api/loteriascaixa
        [HttpGet("{numeroConcurso}/{tipoJogo}")]
        public async Task<JsonResult> Get(int numeroConcurso, TipoJogo tipoJogo)
        {
            var result = await LoteriasCaixaService.GetResultado(numeroConcurso, tipoJogo);

            return new JsonResult(result.ToJsonResult());
        }
    }
}
