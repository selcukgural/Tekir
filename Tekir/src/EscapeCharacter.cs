namespace Tekir
{
    public class EscapeCharacter : IMarkdown
    {
        public char Character;
        public IMarkdown Markdown;
        public EscapeCharacter()
        {

        }

        public EscapeCharacter(char character)
        {
            Character = character;
        }
        public EscapeCharacter(char character, IMarkdown markdown)
        {
            Character = character;
            Markdown = markdown;
        }

        public override string ToString()
        {
            return string.Concat("\\", Character, Markdown?.ToString() ?? "");
        }
    }
}
