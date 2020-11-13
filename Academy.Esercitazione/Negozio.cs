using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Esercitazione
{
    public class Negozio:Prodotto
    {
        public string NomeNegozio { get; set; }
        public string NomeProprietario { get; set; }
        public List<Prodotto> products_list = new List<Prodotto>();
        public void AggiungiProd(string desc, double price, double disc, int code)
        {
            this.products_list.Add(new Prodotto(desc, price, disc, code));
        }
        public Negozio(string nneg, string nprop,string desc, double price, int code, double disc): base(desc, price,disc, code )
        {
            this.products_list.Add(new Prodotto(desc,price,disc,code));
            this.NomeNegozio = nneg;
            this.NomeProprietario = nprop;
        }
        public Negozio(string nneg, string nprop):base("Ancora Nessun Prodotto")
        {
            this.NomeNegozio = nneg;
            this.NomeProprietario = nprop;
        }

        public Negozio(string nneg, string nprop, List<Prodotto> lista) : base("Do una lista")
        {
            this.NomeNegozio = nneg;
            this.NomeProprietario = nprop;
            this.products_list = new List<Prodotto>(lista);
        }

    }
}
