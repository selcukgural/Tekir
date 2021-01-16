namespace Tekir
{
    public class Link : IMarkdown
    {
        public string Click;
        public string Url;
        public IMarkdown Markdown;

        public Link()
        {

        }

        public Link(string click, string url)
        {
            Click = click;
            Url = url;
        }
        public Link(string click, string url, IMarkdown markdown)
        {
            Click = click;
            Url = url;
            Markdown = markdown;
        }

        public override string ToString()
        {
            return string.Concat("[", Click, "]", "(", Url, ")", Markdown?.ToString() ?? "");
        }
    }
}