using System;
using System.Collections.Generic;


namespace SquadraDiCalcio
{
    public class Manager
    {
        #region Inserimento Manuale Giocatori

        //    public static List<Giocatori> players = new List<Giocatori>();
        //    public static void NuovoGiocatore()
        //    {
        //        Console.Clear();
        //        Console.WriteLine("====== INSERISCI NUOVO GIOCATORE ======");
        //        Console.WriteLine();
        //        Console.WriteLine("Scegli Ruolo:");
        //        var ruolo = Helpers.SceltaRuolo();
        //        if (ruolo == Ruolo.Portiere)
        //        {
        //            Console.Clear();
        //            Portieri p = new Portieri();
        //            Console.WriteLine("==Portiere==");
        //            p.RuoloSquadra = ruolo;

        //            Console.WriteLine("Inserisci Nominativo");
        //            p.Nominativo = Console.ReadLine();

        //            Console.WriteLine("Inserisci Data di Nascita");
        //            p.DataDiNascita = Helpers.CheckData();

        //            Console.WriteLine("Inserisci Numero Maglia");
        //            p.NumeroMaglia = Helpers.CheckInt();

        //            Console.WriteLine("Titolare/Riserva");
        //            p.Titolare = Helpers.RuoloInRosa();

        //            Console.WriteLine("Gol Subiti");
        //            p.GolSubiti = Helpers.CheckInt();

        //            Console.WriteLine("Rigori Parati");
        //            p.RigoriParati = Helpers.CheckInt();

        //            players.Add(p);
        //        }
        //        if (ruolo == Ruolo.Difensore)
        //        {
        //            Console.Clear();
        //            Difensori d = new Difensori();
        //            Console.WriteLine("==Difensore==");
        //            d.RuoloSquadra = ruolo;

        //            Console.WriteLine("Inserisci Nominativo");
        //            d.Nominativo = Console.ReadLine();

        //            Console.WriteLine("Inserisci Data di Nascita");
        //            d.DataDiNascita = Helpers.CheckData();

        //            Console.WriteLine("Inserisci Numero Maglia");
        //            d.NumeroMaglia = Helpers.CheckInt();

        //            Console.WriteLine("Titolare/Riserva");
        //            d.Titolare = Helpers.RuoloInRosa();

        //            Console.WriteLine("Tackle Riusciti");
        //            d.TackleRiusciti = Helpers.CheckInt();

        //            players.Add(d);
        //        }
        //        if (ruolo == Ruolo.Centrocampista)
        //        {
        //            Console.Clear();
        //            Centrocampisti c = new Centrocampisti();
        //            Console.WriteLine("==Centrocampista==");
        //            c.RuoloSquadra = ruolo;

        //            Console.WriteLine("Inserisci Nominativo");
        //            c.Nominativo = Console.ReadLine();

        //            Console.WriteLine("Inserisci Data di Nascita");
        //            c.DataDiNascita = Helpers.CheckData();

        //            Console.WriteLine("Inserisci Numero Maglia");
        //            c.NumeroMaglia = Helpers.CheckInt();

        //            Console.WriteLine("Titolare/Riserva");
        //            c.Titolare = Helpers.RuoloInRosa();

        //            Console.WriteLine("Passaggi Riusciti");
        //            c.PassaggiRiusciti = Helpers.CheckInt();

        //            Console.WriteLine("Passaggi Tentati");
        //            c.PassaggiTentati = Helpers.CheckInt();

        //            players.Add(c);
        //        }
        //        if (ruolo == Ruolo.Attaccante)
        //        {
        //            Console.Clear();
        //            Attaccanti a = new Attaccanti();
        //            Console.WriteLine("==Attaccanti==");
        //            a.RuoloSquadra = ruolo;

        //            Console.WriteLine("Inserisci Nominativo");
        //            a.Nominativo = Console.ReadLine();

        //            Console.WriteLine("Inserisci Data di Nascita");
        //            a.DataDiNascita = Helpers.CheckData();

        //            Console.WriteLine("Inserisci Numero Maglia");
        //            a.NumeroMaglia = Helpers.CheckInt();

        //            Console.WriteLine("Titolare/Riserva");
        //            a.Titolare = Helpers.RuoloInRosa();

        //            Console.WriteLine("Gol Realizzati");
        //            a.GolRealizzati = Helpers.CheckInt();

        //            players.Add(a);
        //        }

        //}
        #endregion
        public static void DatiDirigenza()
        {
            Squadra dirigenza = new Squadra()
            {
                Nome = "FC. Pre Academy",
                Fondazione = "23/07/2021",
                Campionato = "Serie A",
                Presidente = "Mario Rossi",
                Allenatore = "Simone Bianchi"
            };
            Console.Clear();
            Console.WriteLine("====== DATI DIRIGENZA ======");
            Console.WriteLine(dirigenza.ToString());
            Console.WriteLine();
            Console.WriteLine(">> Premi un tasto per tornare alla Gestione Squadra");
            Console.ReadKey();
        }

        public static void ModificaSquadra()
        {
            Console.Clear();
            Console.WriteLine("====== MODIFICA SQUADRA TITOLARI ======");
            ElencoGiocatori(Rosa.players2);
            Console.WriteLine("Inserisci Numero Cartellino del Giocatore:");
            int id = Helpers.CheckInt();
            Giocatori cartellino = CercaCartellino(id);
            if (cartellino == null)
            {
                Console.WriteLine($"Non ci sono giocatori con numero cartellino {id}");
            }
            else
            {
                Giocatori giocatore = cartellino;
                giocatore.Titolare = Helpers.RuoloInRosa();
                Console.WriteLine($"Il Giocatore {giocatore.Nominativo} ora è {giocatore.Titolare}");
            }
            Console.WriteLine();
            Console.WriteLine(">> Premi un tasto per tornare alla Gestione Squadra");
            Console.ReadKey();
        }

        public static void StatisticheTitolari()
        {
            Console.Clear();
            List<Giocatori> titolari = CercaTitolari();
            Console.WriteLine("====== STATISTICHE GIOCATORI TITOLARI ======");
            Console.WriteLine();

            foreach (var player in titolari)
            {
                Console.WriteLine($"[Numero Cartellino: {player.NumeroCartellino}] {player.Nominativo} || {player.RuoloSquadra,-20}");
                Console.WriteLine(player.ToString());
                Console.WriteLine(new String('-', 75));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(">> Premi un tasto per tornare alla Gestione Squadra");
            Console.ReadKey();

        }

        public static List<Giocatori> CercaTitolari()
        {
            List<Giocatori> t = new List<Giocatori>();

            //foreach (Giocatori titolare in players) //PER INSERIMENTO MANUALE
            foreach (Giocatori titolare in Rosa.players2)
            {
                if (titolare.Titolare == Titolare.Titolare)
                {
                    t.Add(titolare);
                }
            }
            return t;
        }

        public static List<Giocatori> CercaRiserve()
        {
            List<Giocatori> r = new List<Giocatori>();

            foreach (Giocatori riserva in Rosa.players2)
            {
                if (riserva.Titolare == Titolare.Titolare)
                {
                    r.Add(riserva);
                }
            }
            return r;
        }


        public static void VenditaGiocatori()
        {
            Console.Clear();
            Console.WriteLine("====== VENDITA GIOCATORI ======");
            Console.WriteLine();
            //ElencoGiocatori(Manager.players); //PER INSERIMENTO MANUALE
            ElencoGiocatori(Rosa.players2);
            do
            {
                Console.WriteLine("Inserisci Numero Cartellino:");
                int id = Helpers.CheckInt();
                Giocatori vendiGiocatore = CercaCartellino(id);
                if (vendiGiocatore == null)
                {
                    Console.WriteLine($"Non ci sono giocatori con numero cartellino {id}");
                }
                else
                {
                    Giocatori vendi = vendiGiocatore;
                    Console.WriteLine($"Il Giocaore {vendiGiocatore.Nominativo} è stato venduto.");
                    //players.Remove(vendi); //PER INSERIMENTO MANUALE
                    Rosa.players2.Remove(vendi);
                    break;
                }

            } while (true);

            Console.WriteLine();
            Console.WriteLine(">> Premi un tasto per tornare alla Gestione Squadra");
            Console.ReadKey();
        }

        public static Giocatori CercaCartellino(int num)
        {
            //foreach (Giocatori pl in players) //PER INSERIMENTO MANUALE
            foreach (Giocatori pl in Rosa.players2)
            {
                if (pl.NumeroCartellino == num)
                {
                    return pl;
                }
            }
            return null;
        }

        public static void ElencoGiocatori(List<Giocatori> list)
        {
            Console.Clear();
            Console.WriteLine("====== ELENCO GIOCATORI ======");
            Console.WriteLine();

            Console.WriteLine("{0, -10}{1,-20}{2,-20}{3, -15}{4, -20}", "N°", "Ruolo", "Nominativo", "Maglia N°", "Titolare/Riserva");
            Console.WriteLine(new String('-', 95));
            foreach (var player in list)
            {
                Console.WriteLine($"{player.NumeroCartellino,-10}{player.RuoloSquadra,-20}{player.Nominativo,-20}{player.NumeroMaglia,-15}{player.Titolare,-20}");

            }

            Console.WriteLine();
            Console.WriteLine(">> Premi un tasto per andare avanti");
            Console.ReadKey();

        }

    }
}
