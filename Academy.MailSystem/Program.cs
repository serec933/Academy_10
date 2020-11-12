using System;
using System.Data.Common;

namespace Academy.MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();
            Fax fax = new Fax(mm);
            Printer printer = new Printer(mm);



            mm.SimulateMailArrived("serena", "Francesca", "salutoni", "tanti saluti,baci baci");
            mm.SimulateMailArrived("Francesca", "Serena", "salutoni", "tanti saluti a te,baci baci");
        }
    }
}
