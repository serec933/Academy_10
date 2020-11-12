using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Temperature
{
    public delegate void TemperatureEventHandler(Object sender, double temperatura);
    public class Termometro
    {
        public event TemperatureEventHandler TemperatureTooHigh;
        private double _t;
        public void SimulateTemperature(double t)
        {
            if (t > 25)
            {
                this._t = t;
                TemperatureTooHigh?.Invoke(this, this._t);
            }

        }
    }
}
