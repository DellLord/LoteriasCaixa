using LoteriasCaixa.Common;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static LoteriasCaixa.Common.JsonFormat;
using static LoteriasCaixa.Common.RegexExpression;

namespace LoteriasCaixa.Services.Rules
{
    public class TimeMania : Core.LoteriasCaixa
    {
        public TimeMania(int numeroConcurso)
        {
            ResultadoJogo = GetJogo(numeroConcurso).Result;
        }

        protected sealed override async Task<string> GetJogo(int numeroConcurso)
        {
            try
            {
                var url = $"{Url.TimeMania}{numeroConcurso}";

                var documentText = await CustomHttpClient.DocumentText(url);

                var sb = new StringBuilder(InicioNumeros);

                var regex = new Regex(Numeros);

                var collection = regex.Matches(documentText.ToSplit(7));

                foreach (Match item in collection)
                {
                    sb.Append($"{item.Groups[1]},");
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
