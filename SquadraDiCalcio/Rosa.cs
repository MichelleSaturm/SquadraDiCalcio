using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    public class Rosa
    {
        public static List<Giocatori> players2 = new List<Giocatori>()
            {
                new Portieri () {Nominativo = "Luca Rossi", DataDiNascita="07/12/1999", NumeroMaglia=1, RuoloSquadra=Ruolo.Portiere, Titolare=Titolare.Titolare,GolSubiti=23,RigoriParati=4 },
                new Portieri () {Nominativo = "Giampaolo Verdi", DataDiNascita="01/11/2009", NumeroMaglia=12, RuoloSquadra=Ruolo.Portiere, Titolare=Titolare.Riserva,GolSubiti=13,RigoriParati=1 },
                new Portieri () {Nominativo = "Carlo Bianchi", DataDiNascita="04/10/2010", NumeroMaglia=33, RuoloSquadra=Ruolo.Portiere, Titolare=Titolare.Riserva,GolSubiti=2,RigoriParati=0 },
                
                new Difensori () {Nominativo = "Luigi Neri", DataDiNascita="04/01/2010", NumeroMaglia=2, RuoloSquadra=Ruolo.Difensore, Titolare=Titolare.Titolare, TackleRiusciti = 21},
                new Difensori () {Nominativo = "Enrico Giallini", DataDiNascita="14/11/2000", NumeroMaglia=3, RuoloSquadra=Ruolo.Difensore, Titolare=Titolare.Titolare, TackleRiusciti = 11},
                new Difensori () {Nominativo = "Federico Violi", DataDiNascita="09/04/2002", NumeroMaglia=4, RuoloSquadra=Ruolo.Difensore, Titolare=Titolare.Titolare, TackleRiusciti = 22},
                new Difensori () {Nominativo = "Walter Liuto", DataDiNascita="01/04/1999", NumeroMaglia=15, RuoloSquadra=Ruolo.Difensore, Titolare=Titolare.Riserva, TackleRiusciti = 2},
                new Difensori () {Nominativo = "Stefano Palloni", DataDiNascita="01/02/1999", NumeroMaglia=5, RuoloSquadra=Ruolo.Difensore, Titolare=Titolare.Riserva, TackleRiusciti = 12},
                new Difensori () {Nominativo = "Fabrizio Palli", DataDiNascita="11/12/1999", NumeroMaglia=6, RuoloSquadra=Ruolo.Difensore, Titolare=Titolare.Titolare, TackleRiusciti = 13},
                
                new Centrocampisti () {Nominativo = "Gianluigi Grigi", DataDiNascita="11/10/1999", NumeroMaglia=7, RuoloSquadra=Ruolo.Centrocampista, Titolare=Titolare.Titolare, PassaggiRiusciti= 12, PassaggiTentati= 22},
                new Centrocampisti () {Nominativo = "Roberto Verdini", DataDiNascita="21/11/2000", NumeroMaglia=8, RuoloSquadra=Ruolo.Centrocampista, Titolare=Titolare.Titolare, PassaggiRiusciti= 22, PassaggiTentati= 32},
                new Centrocampisti () {Nominativo = "Simone DeRossi", DataDiNascita="03/05/1999", NumeroMaglia=9, RuoloSquadra=Ruolo.Centrocampista, Titolare=Titolare.Riserva, PassaggiRiusciti= 2, PassaggiTentati= 4},
                new Centrocampisti () {Nominativo = "Valerio Maretti", DataDiNascita="11/12/2002", NumeroMaglia=23, RuoloSquadra=Ruolo.Centrocampista, Titolare=Titolare.Titolare, PassaggiRiusciti= 10, PassaggiTentati= 22},
                new Centrocampisti () {Nominativo = "Quirino Quadri", DataDiNascita="01/02/2002", NumeroMaglia=33, RuoloSquadra=Ruolo.Centrocampista, Titolare=Titolare.Riserva, PassaggiRiusciti= 10, PassaggiTentati= 10},
                new Centrocampisti () {Nominativo = "Michele Santino", DataDiNascita="05/10/2002", NumeroMaglia=11, RuoloSquadra=Ruolo.Centrocampista, Titolare=Titolare.Titolare, PassaggiRiusciti= 20, PassaggiTentati= 22},
                
                new Attaccanti () {Nominativo = "Leonardo Matti", DataDiNascita="04/06/2001", NumeroMaglia=13, RuoloSquadra=Ruolo.Attaccante, Titolare=Titolare.Titolare, GolRealizzati = 5},
                new Attaccanti () {Nominativo = "Raffaello Dentini", DataDiNascita="04/04/2001", NumeroMaglia=14, RuoloSquadra=Ruolo.Attaccante, Titolare=Titolare.Titolare, GolRealizzati = 12},
                new Attaccanti () {Nominativo = "Donatello Rospetto", DataDiNascita="14/06/2001", NumeroMaglia=73, RuoloSquadra=Ruolo.Attaccante, Titolare=Titolare.Riserva, GolRealizzati = 2},
                new Attaccanti () {Nominativo = "Michelangelo Alberello", DataDiNascita="24/01/2000", NumeroMaglia=31, RuoloSquadra=Ruolo.Attaccante, Titolare=Titolare.Riserva, GolRealizzati = 15},
                new Attaccanti () {Nominativo = "Andrea Andrei", DataDiNascita="14/11/2001", NumeroMaglia=44, RuoloSquadra=Ruolo.Attaccante, Titolare=Titolare.Riserva, GolRealizzati = 15},
                new Attaccanti () {Nominativo = "Tommaso Naso", DataDiNascita="08/09/2001", NumeroMaglia=94, RuoloSquadra=Ruolo.Attaccante, Titolare=Titolare.Riserva, GolRealizzati = 5},
            };
    }
}
