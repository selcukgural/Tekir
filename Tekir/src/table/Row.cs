using System.Collections.Generic;
using System.Linq;

namespace Tekir
{
    public class Row
    {
        public List<IEnumerable<string>> Rows { get; set; }
        public Row()
        {
            Rows = new List<IEnumerable<string>>();
        }

        public Row(IEnumerable<string> rows)
        {
            Rows = new List<IEnumerable<string>> {rows.ToList()};
        }

        public void Add(IEnumerable<string> rows)
        {
            Rows.Add(rows.ToList());
        }
    }
}