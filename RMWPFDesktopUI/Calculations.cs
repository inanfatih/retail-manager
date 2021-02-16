using System.Collections.Generic;

namespace WPFDesktopUI
{
    class Calculations : ICalculations
    {
        public List<string> Register { get; set; }
        public double Add(double x, double y)
        {
            return x + y;
        }

    }
}
