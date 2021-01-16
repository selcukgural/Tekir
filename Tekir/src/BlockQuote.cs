namespace Tekir
{
    public class BlockQuote : IContent, IMarkdown
    {
        public BlockQuote()
        {

        }

        public BlockQuote(string content) : base(content)
        {

        }
        public BlockQuote(IMarkdown markdown) : base(markdown)
        {

        }
        public BlockQuote(string content, IMarkdown markdown) : base(content, markdown)
        {

        }
        public override string ToString()
        {
            var text = "> ";
            if (!string.IsNullOrEmpty(Content))
                text += Content;

            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}