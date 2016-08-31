namespace LoteriasCaixa.Common
{
    public static partial class JsonFormat
    {
        private const string InicioResultado = @"{{""resultado"":";

        private const string FimResultado = @"}}";

        public static string ToJsonErrorResult(this string json)
        {
            return $@"""{json}""";
        }

        public static string ToJsonResult(this string json)
        {
            return $"{InicioResultado}{json}{FimResultado}";
        }
    }
}
