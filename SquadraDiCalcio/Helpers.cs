using System;

namespace SquadraDiCalcio
{
    class Helpers
    {
        public static int CheckInt()
        {
            bool isInt;
            int intero;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out intero);
            } while (!isInt);
            return intero;
        }

        public static Ruolo SceltaRuolo()
        {
            Console.WriteLine($"[{(int)Ruolo.Portiere}] - {Ruolo.Portiere}");
            Console.WriteLine($"[{(int)Ruolo.Difensore}] - {Ruolo.Difensore}");
            Console.WriteLine($"[{(int)Ruolo.Centrocampista}] - {Ruolo.Centrocampista}");
            Console.WriteLine($"[{(int)Ruolo.Attaccante}] - {Ruolo.Attaccante}");

            bool isInt;
            int ruolo;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out ruolo);
            } while (!isInt || ruolo < 0 || ruolo > 5);
            return (Ruolo)ruolo;
        }

        public static Titolare RuoloInRosa()

        {
            Console.WriteLine($"[{(int)Titolare.Titolare}] - {Titolare.Titolare}");
            Console.WriteLine($"[{(int)Titolare.Riserva}] - {Titolare.Riserva}");

            bool isInt;
            int tr;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out tr);
            } while (!isInt || tr < 0 || tr > 1);
            return (Titolare)tr;
        }

        public static DateTime CheckData()
        {
            bool notDate;
            DateTime data = new DateTime();
            do
            {
                notDate = DateTime.TryParse(Console.ReadLine(), out data);
            } while (!notDate);
            return data;
        }

        

        
    }
}
