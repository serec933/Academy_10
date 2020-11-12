using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Academy.MailSystem
{
    public class MailEventArgs
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
    //sta roba mi serve per evitarmi di scrivere string string string nel delegate
    public delegate void MailEventHandler(Object sender, MailEventArgs args);
    //sender è chi ha sollevato l'evento (aka MailManager), non serve ai fini della compilazione
    //ma può essere utile nel debug.
    public class MailManager
    {
        public event MailEventHandler MailArrived;
        public void SimulateMailArrived(string from, string to, string subj, string body)
        {
            MailEventArgs args = new MailEventArgs()
            {
                Body = body,
                From=from,
                Subject=subj,
                To=to
            };
            MailArrived?.Invoke(this, args);
            /*
             EQUIVALENTE A :
            if (MailArrived !=null)
            {
                MailArrived(this, args);
                /*EQUIVALENTE A 
                foreach (var item in MailArrived.GetInvocationList().ToList())
                {
                    MailEventHandler mm_eh = (MailEventHandler)item;
                    mm_eh(this, args);
                }
               
            }
            */

        }
    }

    
}
