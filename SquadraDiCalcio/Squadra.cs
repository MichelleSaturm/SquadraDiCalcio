using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    public class Squadra
    {
        public string Nome { get; set; }
        public string Fondazione { get; set; }
        public string Campionato { get; set; }
        public string Presidente { get; set; }
        public string Allenatore { get; set; }
        public List<Giocatori> RosaGiocatori { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"Fondazione: {Fondazione}\n" +
                $"Campionato: {Campionato}\n" +
                $"Presidente: {Presidente}\n" +
                $"Allenatore: {Allenatore}";
        }



    }

    
}
