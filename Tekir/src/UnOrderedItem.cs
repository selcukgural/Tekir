using System.Collections.Generic;

namespace Tekir
{
    public class UnOrderedItem
    {
        public string Parent;
        public IEnumerable<string> Childs;

        public UnOrderedItem()
        {

        }

        public UnOrderedItem(string parent)
        {
            Parent = parent;
        }

        public UnOrderedItem(string parent, IEnumerable<string> childs)
        {
            Parent = parent;
            Childs = childs;
        }
    }
}