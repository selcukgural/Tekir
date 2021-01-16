namespace Tekir
{
    public class Code : IContent, IMarkdown
    {
        public Code()
        {

        }

        public Code(string content) : base(content)
        {

        }

        public Code(IMarkdown markdown) : base(markdown)
        {

        }

        public Code(string content, IMarkdown markdown) : base(content, markdown)
        {

        }

        public override string ToString()
        {
            var text = "";
            if (!string.IsNullOrEmpty(Content))
                text = string.Concat("`", Content, "`");

            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}