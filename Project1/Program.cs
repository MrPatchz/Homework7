using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer test_default = new Odometer();
            test_default.add(4.4, 7.0);
            test_default.ToString();
            test_default.reset();
            test_default.ToString();

            Odometer test_2_arg = new Odometer(100,200);
            test_2_arg.ToString();
            test_2_arg.add(50, 70);
            test_2_arg.ToString();
            test_2_arg.reset();
            test_2_arg.ToString();
        }
    }
}
