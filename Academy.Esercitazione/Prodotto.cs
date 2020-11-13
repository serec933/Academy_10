using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Esercitazione
{
    public class Prodotto
    {
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double Sconto { get; set; }
        public int Codice { get; set; }

        public Prodotto(string descrip, double price, double sale, int code)
        {
            this.Descrizione = descrip;
            this.Prezzo = price;
            this.Sconto = sale;
            this.Codice = code;
        }
        public Prodotto(string descrip, double price, double sale)
        {
            this.Descrizione = descrip;
            this.Prezzo = price;
            this.Sconto = sale;
            this.Codice = -1;
        }

        public Prodotto(string descrip, int code)
        {
            this.Descrizione = descrip;
            this.Prezzo = 0;
            this.Sconto = 0;
            this.Codice = code;
        }
        public Prodotto(string descrip)
        {
            this.Descrizione = descrip;
        }

    }
}
