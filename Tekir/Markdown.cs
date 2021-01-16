using System.Text;

namespace Tekir
{
    public class Markdown
    {
        private readonly StringBuilder _builder = new StringBuilder();
        public Markdown Add(IMarkdown markdown)
        {
            _builder.Append(markdown);
            return this;
        }

        public Markdown AddLine(IMarkdown markdown)
        {
            _builder.AppendLine(markdown.ToString());
            return this;
        }

        public string Get()
        {
            return _builder.ToString();
        }

        public void Clear()
        {
            _builder.Clear();
        }

        public void Save(IEntry entry)
        {
            entry.Save();
        }
    }
}
