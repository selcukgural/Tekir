namespace Tekir
{
    public class LineBreak : IContent, IMarkdown
    {
        public LineBreak()
        {

        }

        public LineBreak(IMarkdown markdown) : base(markdown)
        {

        }
        public override string ToString()
        {
            return Markdown == null ? "<br>" : string.Concat("<br>", Markdown.ToString());
        }
    }
}