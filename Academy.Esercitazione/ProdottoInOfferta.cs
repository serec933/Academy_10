using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Esercitazione
{
    class ProdottoInOfferta:Prodotto
    {
        public DateTime dataInizio { get; set; }
        public DateTime dataFine { get; set; }
        public ProdottoInOfferta(string descrip, double price, double sale, int code, DateTime inizio, DateTime fine) : base(descrip, price, sale, code)
        {
            this.dataFine = fine;
            this.dataInizio = inizio;
        }
        public ProdottoInOfferta(string descrip, double price, double sale, DateTime inizio, DateTime fine) : base(descrip, price, sale)
        {
            this.dataFine = fine;
            this.dataInizio = inizio;
        }
        public ProdottoInOfferta(string descrip, DateTime inizio, DateTime fine) : base(descrip)
        {

            this.dataFine = fine;
            this.dataInizio = inizio;
        }
        public bool IsInOfferta()
        {
            DateTime today = DateTime.Now;
            return (today >= dataInizio & today <= dataFine.AddDays(1));
        }
    }
}
