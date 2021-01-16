namespace Tekir
{
    public class Image : IMarkdown
    {
        public string Title;
        public string Url;
        public IMarkdown Markdown;
        public Image()
        {

        }

        public Image(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public Image(string title, string url, IMarkdown markdown)
        {
            Title = title;
            Url = url;
            Markdown = markdown;
        }

        public override string ToString()
        {
            return string.Concat("![:(]", "(", Url, " ", "\"", Title, "\"", ")", Markdown?.ToString() ?? "");
        }
    }
}