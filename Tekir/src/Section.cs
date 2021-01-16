namespace Tekir
{
    public class Section : IMarkdown
    {
        public string Click;
        public string Code;
        public IMarkdown Markdown;

        public Section()
        {

        }

        public Section(string click, string code)
        {
            Click = click;
            Code = code;
        }
        public Section(string click, string code, IMarkdown markdown)
        {
            Click = click;
            Code = code;
            Markdown = markdown;
        }

        public override string ToString()
        {
            return string.Concat("[", Click, "]", "(#", Code, ")", Markdown?.ToString() ?? "");
        }
    }
}