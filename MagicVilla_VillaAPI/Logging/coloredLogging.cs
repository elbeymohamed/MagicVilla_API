using System;

namespace MagicVilla_VillaAPI.Logging
{
    public class coloredLogging : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR - " + message);
                // Console.BackgroundColor = ConsoleColor.Black;
                Console.ResetColor();
            }
            else
            if (type == "warning")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("WARNING - " + message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
}
