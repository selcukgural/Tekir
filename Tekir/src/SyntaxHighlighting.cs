namespace Tekir
{
    public class SyntaxHighlighting : IMarkdown
    {
        public string Code;
        public string Language;
        public IMarkdown Markdown;
        public SyntaxHighlighting()
        {

        }

        public SyntaxHighlighting(string code, string language)
        {
            Code = code;
            Language = language;
        }
        public SyntaxHighlighting(string code, string language, IMarkdown markdown)
        {
            Code = code;
            Language = language;
            Markdown = markdown;
        }

        public override string ToString()
        {
            return string.Concat("```", Language, "\n", Code, "\n", "```", Markdown?.ToString() ?? "");
        }
    }
}