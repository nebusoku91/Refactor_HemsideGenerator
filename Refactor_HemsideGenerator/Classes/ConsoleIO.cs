using Refactor_HemsideGenerator.Interfaces;

namespace Refactor_HemsideGenerator.Classes
{
    public class ConsoleIO : IConsoleIO
    {
        public void PrintString(string Output)
        {
            Console.WriteLine(Output);
        }
    }
}
