using System.Threading.Tasks;

namespace LoteriasCaixa.Services.Core
{
    public abstract class LoteriasCaixa : ILoteriasCaixa
    {
        public string ResultadoJogo { get; set; }

        protected abstract Task<string> GetJogo(int numeroConcurso);       
    }
}
