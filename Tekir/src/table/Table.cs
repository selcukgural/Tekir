using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tekir
{
    public class Table : Row, IMarkdown
    {
        public List<Column> Columns { get; set; }
        public Table()
        {
            Columns = new List<Column>();
        }

        public Table(List<Column> columns)
        {
            Columns = columns;
        }

        public void AddColumn(Column column)
        {
            Columns.Add(column);
        }
        public void AddRange(IEnumerable<Column> columns)
        {
            Columns.AddRange(columns);
        }

        public void AddRow(IEnumerable<string> rows)
        {
            if (Columns == null || !Columns.Any()) throw new ArgumentException("Before add a row you must add column/columns");
            if (rows == null || !rows.Any()) throw new ArgumentNullException(nameof(rows));
            if (Columns.Count != rows.Count()) throw new ArgumentException("Columns and rows count must be same size");

            Rows.Add(rows.ToList());
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("|");

            foreach (var column in Columns)
            {
                builder.Append(column.Name).Append("|");
            }

            builder.AppendLine().Append("|");

            foreach (var column in Columns)
            {
                switch (column.Alignment)
                {
                    case Alignment.Right:
                        builder.Append(string.Join("",Enumerable.Repeat("-", column.Name.Length - 1))).Append(":").Append("|");
                        break;
                    case Alignment.Center:
                        builder.Append(":").Append(string.Join("",Enumerable.Repeat("-", column.Name.Length - 2))).Append(":").Append("|");
                        break;
                    default:
                        builder.Append(string.Join("",Enumerable.Repeat("-", column.Name.Length))).Append("|");
                        break;

                }
            }

            builder.AppendLine();

            foreach (var row in Rows)
            {
                builder.Append("|");

                foreach (var rw in row)
                {
                    builder.Append(rw).Append("|");
                }

                builder.AppendLine();
            }

            return builder.AppendLine().ToString();
        }
    }
}