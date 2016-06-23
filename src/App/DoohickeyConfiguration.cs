namespace App
{
    public interface IDoohickeyConfiguration
    {
        int Count { get; }
        string Name { get; }
        int Size { get; }
    }

    public class DoohickeyConfiguration : IDoohickeyConfiguration
    {
        public DoohickeyConfiguration(int count, string name, int size)
        {
            this.Count = count;
            this.Name = name;
            this.Size = size;
        }

        public int Count { get; }

        public string Name { get; }

        public int Size { get; }
    }
}