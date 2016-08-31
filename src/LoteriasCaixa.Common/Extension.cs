namespace LoteriasCaixa.Common
{
    public static class Text
    {
        public static string ToSplit(this string text, int index)
        {
            try
            {
                return text.Split('|')[index];
            }
            catch 
            {
                return string.Empty;
            }
        }
    }
}
