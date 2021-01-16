namespace Tekir
{
    public class LinkedImage : Image, IMarkdown
    {
        public string LinkedUrl;

        public LinkedImage()
        {
        }
        public LinkedImage(string title, string url, string linkedUrl) : base(title, url)
        {
            LinkedUrl = linkedUrl;
        }
        public LinkedImage(string title, string url, string linkedUrl, IMarkdown markdown) : base(title, url, markdown)
        {
            LinkedUrl = linkedUrl;
        }
        public override string ToString()
        {
            return string.Concat("[![alt text]", "(", Url, " ", "\"", Title, "\"", ")]", "(", LinkedUrl, ")");
        }
    }
}