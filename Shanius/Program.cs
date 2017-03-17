using System;

namespace Shanius
{
    class Program
    {
        static void Main(string[] args)
        {
            float Tax = 0;
            string Line = null;

            Console.WriteLine("Bitte trage den Steuersatz ein");
            Line = Console.ReadLine();
            if (Line.Contains("%"))
            {
                Line = Line.Remove(Line.IndexOf("%"), 1);
            }
            float.TryParse(Line, out Tax);

            Tax /= 100;

            float Value = 0.0f;
            float Result = 0.0f;
            while (Tax > 0)
            {
                Console.WriteLine("Bitte gebe den Wert ein");
                Line = Console.ReadLine();
                if (Line.Contains(","))
                {
                    Line = Line.Replace(",", ".");
                }
                float.TryParse(Line, out Value);
                Result = (Value * Tax) + Value;
                Console.WriteLine("Das Ergebnis ist: {0}", Result);
            }
        }
    }
}