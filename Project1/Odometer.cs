using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Odometer
    {
        private double fuel_usage;
        private double miles_driven;

        public Odometer()
        {
            this.fuel_usage = 0;
            this.miles_driven = 0;
        }

        public Odometer(double fuel_usage, double miles_driven)
        {
            this.fuel_usage = fuel_usage;
            this.miles_driven = miles_driven;
        }

        public void reset()
        {
            this.fuel_usage = 0;
            this.miles_driven = 0;
        }

        public void add(double fuel_usage, double miles_driven)
        {
            this.fuel_usage += fuel_usage;
            this.miles_driven += miles_driven;
        }

        public void ToString()
        {
            Console.Out.WriteLine("Fuel used:" + this.fuel_usage +
                "\nMiles Driven:" + this.miles_driven);
        }
    }
}
