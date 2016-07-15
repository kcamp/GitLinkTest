using System;
using System.Diagnostics;
using debug_test;

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

            try
            {
                var performer = new ConditionalPerformer(() => true, new Thrower());
                performer.Do();
            }
            catch (Exception ex)
            {
                if (Debugger.IsAttached) { Debug.WriteLine(ex.ToString()); }
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Finished.  Any key to continue.");
            Console.ReadKey();
        }
    }
}
