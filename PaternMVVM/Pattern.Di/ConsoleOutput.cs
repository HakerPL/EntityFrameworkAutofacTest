using System;

namespace Pattern.Di
{
    class ConsoleOutput : IOutput
    {
        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Di works");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
