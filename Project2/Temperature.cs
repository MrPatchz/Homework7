using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class Temperature
    {
        private float temperature;
        private char scale;

        public Temperature()
        {
            this.temperature = 0;
            this.scale = 'C';
        }

        public Temperature(char scale)
        {
            this.temperature = 0;
            this.scale = scale;
        }

        public Temperature(float temperature)
        {
            this.temperature = temperature;
            this.scale = 'C';
        }

        public Temperature(float temperature, char scale)
        {
            this.temperature = temperature;
            this.scale = scale;
        }

        public float getTemperatureC()
        {
            if (this.scale == 'c' || this.scale == 'C')
            {
                return this.temperature;
            }
            return (float)Math.Round(((this.temperature) - 32.0 * (5.0 / 9.0)), 1);
        }

        public float getTemperatureF()
        {
            if (this.scale == 'f' || this.scale == 'F')
            {
                return this.temperature;
            }
            return (float)Math.Round((((this.temperature) * (9.0 / 5.0) + 32)), 1);
        }

        public void setTemp(float temperature)
        {
            this.temperature = temperature;
        }

        public void setScale(char scale)
        {
            this.scale = scale;
        }

        public void setAll(float temperature, char scale)
        {
            this.temperature = temperature;
            this.scale = scale;
        }

        public void ToString()
        {
            Console.Out.WriteLine("The Temperature is "
                + temperature + " " + scale + "Degrees"
                );
        }

        public bool Equals(Temperature compare)
        {
            if(this.getTemperatureC() == compare.getTemperatureC())
            {
                return true;
            }
            return false;
        }
    }
}
