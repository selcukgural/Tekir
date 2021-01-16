namespace Tekir
{
    public class UrlOrEmail : IContent, IMarkdown
    {
        public UrlOrEmail()
        {

        }

        public UrlOrEmail(string content) : base(content)
        {

        }

        public UrlOrEmail(string content, IMarkdown markdown) : base(content, markdown)
        {

        }

        public override string ToString()
        {
            return string.Concat("<", Content, ">", Markdown?.ToString() ?? "");
        }
    }
}