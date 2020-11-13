using System;

namespace Academy.Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
           //TestProdotto();
           TestNegozio();
            //TestProdottoOfferta();
           
        }

        private static void TestNegozio()
        {

            Negozio neg = new Negozio("nome", "cognome");
            Console.WriteLine("Il nome del negozio è: " + neg.NomeNegozio + " e il proprietario si chiama:" + neg.NomeProprietario);
            int count = 0;
            while (count < 3)
            {
                string descrip = null;
                Console.WriteLine("Descrizione Prodotto : ");
                descrip = Console.ReadLine();
                double price = 0;
                Console.WriteLine("Prezzo Prodotto : ");
                price = Convert.ToDouble(Console.ReadLine());
                double sconto = 0;
                Console.WriteLine("Sconto Prodotto : ");
                sconto = Convert.ToDouble(Console.ReadLine());
                int codice = 0;
                Console.WriteLine("Codcie Prodotto : ");
                codice = Convert.ToInt32(Console.ReadLine());
                neg.AggiungiProd(descrip, price, sconto, codice);
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
            string descrip = "fazzoletti";
            int code = 1000;
            double prezzo = 100;
            double discount = 10;
            DateTime inizio = new DateTime(2020, 11, 10);
            DateTime fine = new DateTime(2020, 11, 17);
            ProdottoInOfferta P_off = new ProdottoInOfferta(descrip, prezzo, discount, code, inizio, fine);
            DateTime today = new DateTime(2020, 11, 13);
            if (P_off.Offerta(today))
            {
                Console.WriteLine("IL PRODOTTO {0} è IN OFFERTA",P_off.Descrizione);
            }
            else
            {
                Console.WriteLine("IL PRODOTTO NON è IN OFFERTA");
            }
        }
        private static void TestProdotto()
        {
            string descrip = null; 
            Console.WriteLine("Descrizione Prodotto : ");
            descrip = Console.ReadLine();
            double price = 0;
            Console.WriteLine("Prezzo Prodotto : ");
            price = Convert.ToDouble(Console.ReadLine());
            double sconto = 0;
            Console.WriteLine("Sconto Prodotto : ");
            sconto = Convert.ToDouble(Console.ReadLine());
            int codice = 0;
            Console.WriteLine("Codcie Prodotto : ");
            codice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("COSTRUTTORE CON TUTTI PARAMETRI:");
            Prodotto p = new Prodotto(descrip,price,sconto,codice);
            Console.WriteLine("Il prodotto è: "+ p.Descrizione +" Il prezzo del prodotto è {0} Euro, è scontato del {1} % e il codice prodotto è {2}",  p.Prezzo, p.Sconto, p.Codice);

            Console.WriteLine("COSTRUTTORE SENZA CODICE");
            Prodotto p1 = new Prodotto(descrip, price, sconto);
            Console.WriteLine("Il prodotto è: " + p1.Descrizione + " Il prezzo del prodotto è {0} Euro, è scontato del {1} % e il codice prodotto è {2}", p1.Prezzo, p1.Sconto, p1.Codice);

            Console.WriteLine("COSTRUTTORE SENZA PREZZO E SCONTO");
            Prodotto p2 = new Prodotto(descrip, codice);
            Console.WriteLine("Il prodotto è: " + p2.Descrizione + " Il prezzo del prodotto è {0} Euro, è scontato del {1} % e il codice prodotto è {2}", p2.Prezzo, p2.Sconto, p2.Codice);
        }
    }
}
