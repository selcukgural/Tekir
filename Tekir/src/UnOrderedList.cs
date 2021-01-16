using System.Collections.Generic;
using System.Linq;

namespace Tekir
{
    public class UnOrderedList : IContent, IMarkdown
    {
        public IEnumerable<UnOrderedItem> Items { get; set; }
        public UnOrderedList()
        {

        }

        public UnOrderedList(IEnumerable<UnOrderedItem> items)
        {
            Items = items;
        }

        public UnOrderedList(IMarkdown markdown) : base(markdown)
        {

        }
        public UnOrderedList(IEnumerable<UnOrderedItem> items, IMarkdown markdown)
        {
            Items = items;
            Markdown = markdown;
        }

        public override string ToString()
        {
            if (Items == null || !Items.Any())
                return Markdown.ToString();

            var text = "";
            foreach (var item in Items)
            {
                text += string.Concat("* ", item.Parent, "\n");

                if (item.Childs == null || !item.Childs.Any())
                    continue;

                text = item.Childs.Aggregate(text, (current, child) => string.Concat(current, "    * ", child, "\n"));
            }

            return Markdown == null ? text : string.Concat(text, "\n", Markdown.ToString());
        }
    }
}