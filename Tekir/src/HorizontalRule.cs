namespace Tekir
{
    public class HorizontalRule : IContent, IMarkdown
    {
        public HorizontalRule()
        {

        }

        public HorizontalRule(IMarkdown markdown) : base(markdown)
        {

        }

        public override string ToString()
        {
            return string.Concat("---", Markdown?.ToString() ?? "");
        }
    }
}