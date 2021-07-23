using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    public class Giocatori
    {
        public int NumeroCartellino { get; set; }
        public string Nominativo { get; set; }
        //public DateTime DataDiNascita { get; set; }
        public string DataDiNascita { get; set; }
        public int NumeroMaglia { get; set; }
        public Titolare Titolare { get; set; }
        public Ruolo RuoloSquadra { get; set; }

        public Giocatori()
        {
            Random random = new Random();
            NumeroCartellino = random.Next(1, 101);
        }

    }

    public class Portieri : Giocatori
    {
        public int GolSubiti { get; set; }
        public int RigoriParati { get; set; }

        public override string ToString()
        {
            return $"=====STATISTICHE=====\n"+
                $"Gol Subiti: {GolSubiti}\n" +
                $"Rigori Parati: {RigoriParati}";
        }


    }

    public class Difensori : Giocatori
    {
        public int TackleRiusciti { get; set; }

        public override string ToString()
        {
            return $"=====STATISTICHE=====\n" +
                $"Tackle Riusciti: {TackleRiusciti}";
        }
    }

    public class Centrocampisti : Giocatori
    {
        public int PassaggiTentati { get; set; }
        public int PassaggiRiusciti { get; set; }

        public override string ToString()
        {
            return $"=====STATISTICHE=====\n" +
                $"Passaggi Tentati: {PassaggiTentati}\n" +
                $"Passaggi Riusciti {PassaggiRiusciti}";
        }
    }
    public class Attaccanti : Giocatori
    {
        public int GolRealizzati { get; set; }

        public override string ToString()
        {
            return $"=====STATISTICHE=====\n" +
                $"Gol Realizzati: {GolRealizzati}";
        }
    }

    
    
}
