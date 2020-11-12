using System;

namespace Academy.Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Termometro term = new Termometro();
            S1 s1 = new S1(term);
            S2 s2 = new S2(term);
            S3 s3 = new S3(term);

            for (int i = 0; i < 50; i++)
            {
                double t = Accademy.Helper.Helper.GetRandomDouble(20, 30);
                Console.WriteLine(t);
                term.SimulateTemperature(t);
            }
            
           
        }
    }
}
