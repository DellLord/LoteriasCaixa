using LoteriasCaixa.Services.Rules;
using System.Threading.Tasks;
using LoteriasCaixa.Common;

namespace LoteriasCaixa.Services
{
    public static class LoteriasCaixaService 
    {
        public static async Task<string> GetResultado(int numeroConcurso, TipoJogo tipoJogo)
        {
            switch (tipoJogo)
            {
                case TipoJogo.MegaSena:

                    return await Task.Run(() => new MegaSena(numeroConcurso).ResultadoJogo);

                case TipoJogo.LotoFacil:

                    return await Task.Run(() => new LotoFacil(numeroConcurso).ResultadoJogo);

                case TipoJogo.LotoMania:

                    return await Task.Run(() => new LotoMania(numeroConcurso).ResultadoJogo);

                case TipoJogo.Quina:

                    return await Task.Run(() => new Quina(numeroConcurso).ResultadoJogo);

                case TipoJogo.TimeMania:

                    return await Task.Run(() => new TimeMania(numeroConcurso).ResultadoJogo);

                case TipoJogo.DuplaSena:

                    return await Task.Run(() => new DuplaSena(numeroConcurso).ResultadoJogo);

                default:

                    return await Task.Run(() => "Tipo de Jogo inválido.".ToJsonResult());
            }
        }        
    }
}
