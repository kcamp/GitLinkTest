using System;

namespace App
{
    public interface IConsoleWriter
    {
        void Write(string format, params object[] args);
        void WriteLine(string format, params object[] args);
    }

    public class ConsoleWriter : IConsoleWriter
    {
        public void Write(string format, params object[] args)
        {
            Console.Write(format, args);
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}