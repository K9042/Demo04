using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh2
{
    class Amplifier
    {
        private readonly int minVolume = 0;
        private readonly int maxVolume = 100;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume && value >= minVolume)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Set volume between 0-100!");
                }
            }
        }
    }
}
