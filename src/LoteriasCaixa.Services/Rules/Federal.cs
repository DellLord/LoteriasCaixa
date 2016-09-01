using LoteriasCaixa.Common;
using System;
using System.Text;
using System.Threading.Tasks;
using static LoteriasCaixa.Common.JsonFormat;

namespace LoteriasCaixa.Services.Rules
{
    public class Federal : Core.LoteriasCaixa
    {
        public Federal(int numeroConcurso)
        {
            ResultadoJogo = GetJogo(numeroConcurso).Result;
        }

        protected sealed override async Task<string> GetJogo(int numeroConcurso)
        {
            try
            {
                var url = $"{Url.Federal}{numeroConcurso}";

                var documentText = await CustomHttpClient.DocumentText(url);

                var sb = new StringBuilder();

                var currentPosition = 1;

                var documentTextArrayByPipe = documentText.Split('|');

                for (var index = 6; index <= 14; index += 2)
                {
                    sb.Append(InicioNumeros);
                    sb.Append($"{currentPosition}\",");
                    sb.Append($"\"{documentTextArrayByPipe[index].ToJsonWithNoDots()}\",");
                    sb.Append($"\"{documentTextArrayByPipe[index + 1]}");
                    sb.Append(FimNumeros);
                    currentPosition++;
                }                

                return await Task.Run(() => sb.ToString());
            }
            catch (Exception ex)
            {
                return await Task.Run(() => ex.Message.ToJsonErrorResult());
            }
        }
    }
}
