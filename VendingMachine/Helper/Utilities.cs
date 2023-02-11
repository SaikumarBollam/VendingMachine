using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Helper
{
    public static class Utilities
    {
        public static void ClearLine(int lines = 1)
        {
            for (int i = 1; i <= lines; i++)
            {
                if (Console.CursorTop > 0)
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
            }
        }
    }
}
