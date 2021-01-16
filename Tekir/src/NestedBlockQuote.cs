namespace Tekir
{
    public class NestedBlockQuote : IContent, IMarkdown
    {
        public NestedBlockQuote()
        {

        }

        public NestedBlockQuote(string content) : base(content)
        {

        }
        public NestedBlockQuote(IMarkdown markdown) : base(markdown)
        {

        }

        public NestedBlockQuote(string content, IMarkdown markdown) : base(content, markdown)
        {

        }
        public override string ToString()
        {
            var text = ">> ";
            if (!string.IsNullOrEmpty(Content))
                text += Content;

            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}