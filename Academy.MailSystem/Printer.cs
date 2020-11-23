using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.MailSystem
{
    public class Printer
    {
        private MailManager _mm;
        public Printer(MailManager mm)
        {
            this._mm = mm;
            MailEventHandler del = new MailEventHandler(mm_MailArrived);
            //invoco add_MailArrived(del)
            this._mm.MailArrived += del;
        }
        public void mm_MailArrived(Object sender, MailEventArgs e)
        {
            Console.WriteLine("i'm a PRINTER \r\n Mail From: {0}, Mail to: {1}, \r\n Subject: {2}, Body: {3}",
                                e.From, e.To, e.Subject, e.Body);
        }
    }
}
