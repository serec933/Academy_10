using System;
using System.Collections.Generic;

namespace Academy.Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
           //TestProdotto();
           //TestNegozio();
           TestProdottoOfferta();
           
        }

        private static void TestNegozio()
        {
            Negozio neg = new Negozio("nome", "cognome");
            Console.WriteLine("Il nome del negozio è: " + neg.NomeNegozio + " e il proprietario si chiama:" + neg.NomeProprietario);
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("Inserisci la descrizione del prodotto, il prezzo, lo sconto e il codice divisi da spazio: ");
                string line = Console.ReadLine();
                string[] res = line.Split(' ');
                if (res.Length > 4)
                {
                    Console.WriteLine("TROPPI PARAMETRI");
                }
                if (res.Length == 4)
                {
                    string descrip = res[0];
                    double price = Convert.ToDouble(res[1]);
                    double sconto = Convert.ToDouble(res[2]);
                    int codice = Convert.ToInt32(res[3]);
                    neg.AggiungiProd(descrip, price, sconto, codice);
                }
                if (res.Length == 3)
                {
                    string descrip = res[0];
                    double price = Convert.ToDouble(res[1]);
                    double sconto = Convert.ToDouble(res[2]);
                   neg.AggiungiProd(descrip, price, sconto);
                }
                if (res.Length == 1)
                {
                    string descrip = res[0];
                    neg.AggiungiProd(descrip);
                }

                count++;
            }
            Console.WriteLine("Lista dei prodotti nel negozio:");
            count = 1;
            foreach (Prodotto p2 in neg.products_list)
            {
                Console.WriteLine("Il prodotto numero {0} è "+p2.Descrizione + " Il prezzo del prodotto è {1} Euro, è scontato del {2} % e il codice prodotto è {3}", count,p2.Prezzo, p2.Sconto, p2.Codice);
                count++;
            }
           
        
        }
        private static void TestProdottoOfferta()
        {
            DateTime today = new DateTime(2020, 11, 13);
            List<ProdottoInOfferta> lista_prodotti = new List<ProdottoInOfferta>();
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("Inserisci la descrizione del prodotto, il prezzo, lo sconto e il codice divisi da spazio: ");
                string line = Console.ReadLine();
                string[] res = line.Split(' ');
                Console.WriteLine("Inserisci giorno, mese e anno di inizio della promozione: ");
                string lineinizio = Console.ReadLine();
                string[] resinizio = lineinizio.Split(' ');
                Console.WriteLine("Inserisci giorno, mese e anno di fine della promozione: ");
                string linefine = Console.ReadLine();
                string[] resfine = linefine.Split(' ');
                int annoi, mesei, giornoi;
                int annof, mesef, giornof;
                annoi = Convert.ToInt32(resinizio[2]); mesei = Convert.ToInt32(resinizio[1]); giornoi = Convert.ToInt32(resinizio[0]);
                annof = Convert.ToInt32(resfine[2]); mesef = Convert.ToInt32(resfine[1]); giornof = Convert.ToInt32(resfine[0]);
                DateTime inizio = new DateTime(annoi,mesei,giornoi);
                DateTime fine = new DateTime(annof,mesef,giornof);

               

                if (res.Length > 4)
                {
                    Console.WriteLine("TROPPI PARAMETRI");
                }
                if (res.Length == 4)
                {
                    string descrip = res[0];
                    double price = Convert.ToDouble(res[1]);
                    double sconto = Convert.ToDouble(res[2]);
                    int codice = Convert.ToInt32(res[3]);
                    ProdottoInOfferta P_off = new ProdottoInOfferta(descrip, price, sconto, codice, inizio, fine);
                    lista_prodotti.Add(P_off);
                }
                if (res.Length == 3)
                {
                    string descrip = res[0];
                    double price = Convert.ToDouble(res[1]);
                    double sconto = Convert.ToDouble(res[2]);
                    ProdottoInOfferta P_off = new ProdottoInOfferta(descrip, price, sconto, inizio, fine);
                    lista_prodotti.Add(P_off);
                }
                if (res.Length == 1)
                {
                    string descrip = res[0];
                    ProdottoInOfferta P_off = new ProdottoInOfferta(descrip, inizio, fine);
                    lista_prodotti.Add(P_off);
                }

                count++;
            }
            foreach(ProdottoInOfferta p in lista_prodotti)
            {
                if (p.Offerta())
                {
                    Console.WriteLine("IL PRODOTTO {0} è IN OFFERTA", p.Descrizione);
                }
                else
                {
                    Console.WriteLine("IL PRODOTTO {0} NON è IN OFFERTA",p.Descrizione);
                }
            }
        }
        private static void TestProdotto()
        {
            
            Console.WriteLine("Inserisci la descrizione del prodotto, il prezzo, lo sconto e il codice divisi da spazio: ");
            string line = Console.ReadLine();
            string[] res = line.Split(' ');
            if (res.Length > 4)
            {
                Console.WriteLine("TROPPI PARAMETRI");
            }
            if (res.Length == 4)
            {
                string descrip = res[0];
                double price = Convert.ToDouble(res[1]);
                double sconto = Convert.ToDouble(res[2]);
                int codice = Convert.ToInt32(res[3]);
                Console.WriteLine("COSTRUTTORE CON TUTTI PARAMETRI:");
                Prodotto p = new Prodotto(descrip, price, sconto, codice);
                Console.WriteLine("Il prodotto è: " + p.Descrizione + " Il prezzo del prodotto è {0} Euro, è scontato del {1} % e il codice prodotto è {2}", p.Prezzo, p.Sconto, p.Codice);
            }
            if (res.Length == 3)
            {
                string descrip = res[0];
                double price = Convert.ToDouble(res[1]);
                double sconto = Convert.ToDouble(res[2]);
                int codice = Convert.ToInt32(res[3]);
                Console.WriteLine("COSTRUTTORE SENZA CODICE");
                Prodotto p1 = new Prodotto(descrip, price, sconto);
                Console.WriteLine("Il prodotto è: " + p1.Descrizione + " Il prezzo del prodotto è {0} Euro, è scontato del {1} % e il codice prodotto è {2}", p1.Prezzo, p1.Sconto, p1.Codice);
            }
            if (res.Length == 1)
            {
                string descrip = res[0];
                double price = Convert.ToDouble(res[1]);
                double sconto = Convert.ToDouble(res[2]);
                int codice = Convert.ToInt32(res[3]);
                Console.WriteLine("COSTRUTTORE SENZA PREZZO E SCONTO");
                Prodotto p2 = new Prodotto(descrip, codice);
                Console.WriteLine("Il prodotto è: " + p2.Descrizione + " Il prezzo del prodotto è {0} Euro, è scontato del {1} % e il codice prodotto è {2}", p2.Prezzo, p2.Sconto, p2.Codice);
            }
            
           
        }
    }
}
