namespace App
{
    public class DoohickeyConfigurator
    {
        private int _size;
        private int _count;
        private string _name;

        public DoohickeyConfigurator WithSize(int size)
        {
            this._size = size;
            return this;
        }

        public DoohickeyConfigurator WithCount(int count)
        {
            this._count = count;
            return this;
        }

        public DoohickeyConfigurator Named(string name)
        {
            this._name = name;
            return this;
        }

        public IDoohickeyConfiguration Build()
        {
            return new DoohickeyConfiguration(this._count, this._name, this._size);
        }
    }
}