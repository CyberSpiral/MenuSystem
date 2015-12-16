using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    class Program
    {
        static void Main(string[] args)
        {
            LineDisplay lines = new LineDisplay();
            lines.AddNewLine("Option 1");
            lines.AddNewLine("Option 2");
            lines.AddNewLine("Option 3");
            lines.AddNewLine("Option 4");
            lines.AddNewLine("Option 5");
            while (true)
            {
                lines.Draw();
                lines.Input(Console.ReadKey().Key);
            }

        }
    }
}
