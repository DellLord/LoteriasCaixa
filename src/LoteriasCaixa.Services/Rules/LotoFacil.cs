using LoteriasCaixa.Common;
using System;
using System.Text;
using System.Threading.Tasks;
using static LoteriasCaixa.Common.JsonFormat;

namespace LoteriasCaixa.Services.Rules
{
    public class LotoFacil : Core.LoteriasCaixa
    {
        public LotoFacil(int numeroConcurso)
        {
            ResultadoJogo = GetJogo(numeroConcurso).Result;
        }

        protected sealed override async Task<string> GetJogo(int numeroConcurso)
        {
            try
            {
                var url = $"{Url.LotoFacil}{numeroConcurso}";

                var documentText = await CustomHttpClient.DocumentText(url);

                var sb = new StringBuilder(InicioNumeros);

                for (var index = 3; index <= 17; index++)
                {
                    sb.Append($"{documentText.ToSplit(index)},");
                }

                sb.Remove(sb.Length - 1, 1);

                sb.Append(FimNumeros);

                return await Task.Run(() => sb.ToString());
            }
            catch (Exception ex)
            {
                return await Task.Run(() => ex.Message.ToJsonErrorResult());
            }
        }
    }
}
