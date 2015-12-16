using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    class LineDisplay
    {
        private List<string> lines;
        private int selectedLine;

        public LineDisplay()
        {
            lines = new List<string>();
            selectedLine = 0;
        }

        public void AddNewLine(string line)
        {
            lines.Add(line);
        }

        public void Draw()
        {
            Console.Clear();
            for (int i = 0; i < lines.Count; i++)
            {
                if (i != selectedLine)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(lines[i] + "\n");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(lines[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n");
                }
            }
        }
        public void Input(ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow)
                selectedLine--;
            else if (key == ConsoleKey.DownArrow)
                selectedLine++;
            if (selectedLine < 0)
                selectedLine = 0;
            if (selectedLine > (lines.Count - 1))
                selectedLine = (lines.Count - 1);
        }

    }
}
