using System;

namespace App
{
    /// <summary>
    /// The Doohickey -- for when widgets just won't do.
    /// </summary>
    public interface IDoohickey
    {
        void Go();
    }

    public class Doohickey : IDoohickey
    {
        private readonly IDoohickeyConfiguration _config;
        private readonly IConsoleWriter _consoleWriter;

        public Doohickey(IDoohickeyConfiguration config, IConsoleWriter consoleWriter)
        {
            this._config = config;
            this._consoleWriter = consoleWriter;
        }

        public void Go()
        {
            for (var i = 0; i < this._config.Count; i++)
            {
                this._consoleWriter.WriteLine(this._config.Name);
            }
        }
    }
}
