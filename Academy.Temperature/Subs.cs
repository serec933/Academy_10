using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Temperature
{
    public class S1
    {
        private Termometro _term;
        public S1(Termometro term)
        {
            this._term = term;
            TemperatureEventHandler del = new TemperatureEventHandler(term_TemperatureTooHigh);
            //invoco add_MailArrived(del)
            this._term.TemperatureTooHigh += del;
        }
        public void term_TemperatureTooHigh(Object sender, double t)
        {
            Console.WriteLine("i'm SUBSCRIBER1 \r\n Temperature is: {0}", t);
        }
    }
    public class S2
    {
        private Termometro _term;
        public S2(Termometro term)
        {
            this._term = term;
            TemperatureEventHandler del = new TemperatureEventHandler(term_TemperatureTooHigh);
            //invoco add_MailArrived(del)
            this._term.TemperatureTooHigh += del;
        }
        public void term_TemperatureTooHigh(Object sender, double t)
        {
            Console.WriteLine("i'm SUBSCRIBER2 \r\n Temperature is: {0}",t);
        }
    }
    public class S3
    {
        private Termometro _term;
        public S3(Termometro term)
        {
            this._term = term;
            TemperatureEventHandler del = new TemperatureEventHandler(term_TemperatureTooHigh);
            //invoco add_MailArrived(del)
            this._term.TemperatureTooHigh += del;
        }
        public void term_TemperatureTooHigh(Object sender, double t)
        {
            Console.WriteLine("i'm SUBSCRIBER3 \r\n Temperature is: {0}",t);
        }
    }
}

