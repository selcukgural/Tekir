namespace Tekir
{
    public class FreeText : IContent, IMarkdown
    {
        public FreeText()
        {

        }
        public FreeText(string content) : base(content)
        {
        }

        public FreeText(IMarkdown markdown) : base(markdown)
        {

        }
        public FreeText(string content, IMarkdown markdown) : base(content, markdown)
        {
        }
        public override string ToString()
        {
            var text = "";
            if (!string.IsNullOrEmpty(Content))
                text = Content;

            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}