using System.Collections.Generic;
using System.Linq;

namespace Tekir
{
    public class OrderedList : IContent, IMarkdown
    {
        public IEnumerable<string> List { get; set; }
        public OrderedList()
        {

        }

        public OrderedList(IEnumerable<string> list)
        {
            List = list;
        }

        public OrderedList(IMarkdown markdown) : base(markdown)
        {

        }
        public OrderedList(IEnumerable<string> list, IMarkdown markdown)
        {
            List = list;
            Markdown = markdown;
        }

        public override string ToString()
        {
            if (List == null || !List.Any() && Markdown != null)
                return Markdown.ToString();

            var itemNo = 1;
            var text = List.Aggregate("", (current, li) => current + string.Concat(itemNo++, ". ", li, "\n"));

            return Markdown == null ? text : string.Concat(text, Markdown.ToString(), "\n");
        }
    }
}