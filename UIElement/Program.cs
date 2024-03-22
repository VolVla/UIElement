using System;

namespace UIElement
{
    class Program
    {
        static void Main()
        {
            int firstLine = 0;
            int maxHealth = 10;
            double percentFillBar;
            char fillSymbol = '#';
            string wordExit = "exit";
            string userInput = "";

            while (userInput != wordExit)
            {
                percentFillBar = ReadPercent();
                DrawBar(maxHealth, percentFillBar, firstLine, fillSymbol);
                Console.WriteLine("\nДля выхода из программы напишите " + wordExit + " для продолжения напишите любой символ");
                userInput = Console.ReadLine();
                Console.Clear();
            }
        }

        static double ReadPercent()
        {
            Console.WriteLine($"\nВведите % текущей шкалы");
            double.TryParse(Console.ReadLine(), out double percentFill);
            Console.Clear();
            return percentFill;
        }

        static void DrawBar(int lenghtBar, double percent, int positionX, char fillSymbol)
        {
            int maximumPercentFillBar = 100;
            int minumumPercentFillBar = 0;

            if (percent >= minumumPercentFillBar && percent <= maximumPercentFillBar)
            {
                string bar = "";
                char rightFrame = ']';
                char leftFrame = '[';
                char emptySymbol = '_';
                int positionY = 0;
                int currentValue = (int)Math.Round(lenghtBar * (percent / maximumPercentFillBar));
                int difference = lenghtBar - currentValue;

                Console.SetCursorPosition(positionY, positionX);
                Console.Write(leftFrame);
                bar = Cycle(currentValue, fillSymbol, bar);
                bar = Cycle(difference, emptySymbol, bar);
                Console.Write(bar + rightFrame);
            }
        }

        static string Cycle(int lenghtBar, char fillSymbol, string bar)
        {
            for (int i = 0; i < lenghtBar; i++)
            {
                bar += fillSymbol;
            }

            return bar;
        }
    }
}
