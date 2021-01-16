using System.Linq;

namespace Tekir
{
    public class Heading : IContent, IMarkdown
    {
        public readonly HeadingLevel HeadingLevel;

        public Heading(HeadingLevel level)
        {
            HeadingLevel = level;
        }
        public Heading(HeadingLevel level, string content)
        {
            HeadingLevel = level;
            Content = content;
        }

        public Heading(HeadingLevel level, string content, IMarkdown markdown) : base(content, markdown)
        {
            HeadingLevel = level;
        }
        public override string ToString()
        {
            var text = string.Concat(string.Join("", Enumerable.Repeat("#", (int)HeadingLevel)), " ", Content);
            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}