using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    class GestioneSquadra
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("== Gestione Squadra ==");
            bool continuare = true;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("---- Pannello di Controllo ----");
                Console.WriteLine("[1] Aggiungi un nuovo giocatore alla Rosa [INSERIMENTO MANUALE || Al momento è commentato]");
                Console.WriteLine("[2] Visualizza Elenco Giocatori");
                Console.WriteLine("[3] Vendita Giocatori");
                Console.WriteLine("[4] Visualizza Statistiche Squadra Titolare");
                Console.WriteLine("[5] Modifica Rosa Squadra");
                Console.WriteLine("[6] Visualizza Dati Società");

                Console.WriteLine();
                Console.WriteLine("---- Uscita ----");
                Console.WriteLine("0 - Exit");

                Console.WriteLine();
                Console.Write("Inserisci la tua scelta: ");


                int choice;
                bool isInt;
                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out choice);
                } while (!isInt);

                switch (choice)
                {
                    case 1:
                        //Manager.NuovoGiocatore(); //PER INSERIMENTO MANUALE
                        break; 
                    case 2:
                        //Manager.ElencoGiocatori(Manager.players); //PER INSERIMENTO MANUALE
                        Manager.ElencoGiocatori(Rosa.players2);
                        break;
                    case 3:
                        Manager.VenditaGiocatori();
                        break;
                    case 4:
                        Manager.StatisticheTitolari();
                        break;
                    case 5:
                        Manager.ModificaSquadra();
                        break;
                    case 6:
                        Manager.DatiDirigenza();
                        break;
                    case 0:
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata. Riprova.");
                        break;
                }
            } while (continuare);


        }
    }
}
