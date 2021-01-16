namespace Tekir
{
    public class Column
    {
        public string Name;
        public Alignment Alignment;
        public Column(string name)
        {
            Name = name;
        }

        public Column(string name, Alignment alignment)
        {
            Name = name;
            Alignment = alignment;
        }
    }
}