namespace LoteriasCaixa.Common
{
    public static class Url
    {
        public const string MegaSena = "http://www1.caixa.gov.br/loterias/loterias/megasena/megasena_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtconcurso=";

        public const string LotoFacil = "http://www1.caixa.gov.br/loterias/loterias/lotofacil/lotofacil_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtconcurso=";

        public const string LotoMania = "http://www1.caixa.gov.br/loterias/loterias/lotomania/_lotomania_pesquisa.asp?submeteu=sim&opcao=concurso&txtconcurso=";

        public const string Quina = "http://www1.caixa.gov.br/loterias/loterias/quina/quina_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtconcurso=";

        public const string TimeMania = "http://www1.caixa.gov.br/loterias/loterias/timemania/timemania_pesquisa.asp?submeteu=sim&opcao=concurso&txtconcurso=";

        public const string DuplaSena = "http://www1.caixa.gov.br/loterias/loterias/duplasena/duplasena_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtconcurso=";

        public const string Federal = "http://www1.caixa.gov.br/loterias/loterias/federal/federal_pesquisa.asp?submeteu=sim&opcao=concurso&txtconcurso=";
    }

    public static class RegexExpression
    {
        public const string Numeros = @"<li[^>]*>(.*?)</li>";
    }

    public static partial class JsonFormat
    {
        public const string InicioNumeros = @"[{""numeros"":""";

        public const string ConcatenaNumeros = @"""},{""numeros"":""";

        public const string FimNumeros = @"""}]";
    }
}
