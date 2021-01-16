using System;

namespace Tekir
{
    public class Bold : IContent, IMarkdown
    {
        public Bold()
        {

        }

        public Bold(string content) : base(content)
        {

        }
        public Bold(IMarkdown markdown) : base(markdown)
        {
        }
        public Bold(string content, IMarkdown markdown) : base(content, markdown)
        {
        }
        public override string ToString()
        {
            string text;
            if (!string.IsNullOrEmpty(Content))
            {
                text = string.Concat("**", Content, "**");
            }
            else
            {
                if (Markdown == null)
                    throw new ArgumentNullException(nameof(Content) + " and " + nameof(Markdown) +
                                                    " cannot be null same time");

                return string.Concat("**", Markdown.ToString(), "**");
            }

            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}