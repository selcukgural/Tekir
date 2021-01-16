using System.Collections.Generic;
using System.Linq;

namespace Tekir
{
    public class ListElement : IContent, IMarkdown
    {
        public IEnumerable<string> Elements;
        public ListElement()
        {

        }

        public ListElement(IEnumerable<string> elements)
        {
            Elements = elements;
        }
        public ListElement(IMarkdown markdown) : base(markdown)
        {

        }

        public ListElement(IEnumerable<string> elements, IMarkdown markdown) : base(markdown)
        {
            Elements = elements;
        }

        public override string ToString()
        {
            var text = Elements.Aggregate("", (current, element) => current + string.Concat("- ", element, "\n"));

            return Markdown == null ? text : string.Concat(text, Markdown.ToString(), "\n");
        }
    }
}