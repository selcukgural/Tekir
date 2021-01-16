using System;

namespace Tekir
{
    public class Italic : IContent, IMarkdown
    {
        public Italic()
        {

        }

        public Italic(string content) : base(content)
        {
        }
        public Italic(IMarkdown markdown) : base(markdown)
        {
        }
        public Italic(string content, IMarkdown markdown) : base(content, markdown)
        {
        }

        public override string ToString()
        {
            string text;
            if (!string.IsNullOrEmpty(Content))
            {
                text = string.Concat("*", Content, "*");
            }
            else
            {
                if (Markdown == null)
                    throw new ArgumentNullException(nameof(Content) + " and " + nameof(Markdown) +
                                                    " cannot be null same time");

                return string.Concat("*", Markdown.ToString(), "*");
            }

            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}