namespace Tekir
{
    public abstract class IContent
    {
        public string Content;
        public IMarkdown Markdown;

        protected IContent()
        {

        }
        protected IContent(string content)
        {
            Content = content;
        }

        protected IContent(IMarkdown markdown)
        {
            Markdown = markdown;
        }

        protected IContent(string content, IMarkdown markdown)
        {
            Content = content;
            Markdown = markdown;
        }
    }
}
