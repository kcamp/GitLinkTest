using System.Diagnostics;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Debugger.Launch();
            new Doohickey(
                new DoohickeyConfigurator().Named("TestPdb").WithCount(5).WithSize(10).Build(),
                new ConsoleWriter()
                ).Go();
        }
    }
}
