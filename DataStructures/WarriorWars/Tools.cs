using System;

namespace WarriorWars
{
    static class Tools
    {
        public static void ColorFulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
