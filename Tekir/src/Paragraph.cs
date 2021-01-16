namespace Tekir
{
    public class Paragraph : IContent, IMarkdown
    {
        public Paragraph()
        {

        }

        public Paragraph(IMarkdown markdown) : base(markdown)
        {

        }
        public override string ToString()
        {
            return Markdown == null ? "\n" : string.Concat("\n", Markdown.ToString(), "\n");
        }
    }
}