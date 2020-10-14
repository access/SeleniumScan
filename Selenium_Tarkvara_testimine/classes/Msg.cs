using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Tarkvara_testimine.classes
{
    public static class Msg
    {
        public static void printl(string msg, ConsoleColor color = ConsoleColor.White)
        {
            DateTime date = DateTime.Now;
            if (color != ConsoleColor.White)
                Console.ForegroundColor = color;
            Console.WriteLine(date + "\t" + msg);
            Console.ResetColor();
        }
    }
}
