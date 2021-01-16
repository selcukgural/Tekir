namespace Tekir
{
    public class FencedCode : Code
    {
        public FencedCode()
        {
            
        }

        public FencedCode(string content):base(content)
        {
            
        }
        public FencedCode(IMarkdown markdown) : base(markdown)
        {

        }
        public FencedCode(string content,IMarkdown markdown) : base(content, markdown)
        {

        }
        public override string ToString()
        {
            var text = "";
            if (!string.IsNullOrEmpty(Content))
                text = string.Concat("```", Content, "```");

            return Markdown == null ? text : string.Concat(text, Markdown.ToString());
        }
    }
}
