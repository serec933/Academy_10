using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.MailSystem
{
    public class Fax
    {
        private MailManager _mm;
        //non ho initialise component

        public Fax(MailManager mm)
        {
            this._mm = mm;
            //creo delegate
            //MailEventHandler del = new MailEventHandler(mm_MailArrived);
            //invoco add_MailArrived(del)
            this._mm.MailArrived += _mm_MailArrived;
        }

        private void _mm_MailArrived(object sender, MailEventArgs e)
        {
            Console.WriteLine("i'm a PRINTER \r\n Mail From: {0}, Mail to: {1}, \r\n Subject: {2}, Body: {3}",
                                e.From, e.To, e.Subject, e.Body);
        }



    }

}
