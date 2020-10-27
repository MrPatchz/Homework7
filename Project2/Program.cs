using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature noarg = new Temperature();
            Temperature oneScaleArg = new Temperature('f');
            Temperature oneTempArg = new Temperature((float)20.0);
            Temperature twoArg = new Temperature(30, 'C');
            Console.Out.WriteLine("~~~~~~~~~~~~Test getTemp~~~~~~~~~~~~~~~");
            Console.Out.WriteLine(twoArg.getTemperatureF());
            Console.Out.WriteLine(oneTempArg.getTemperatureC());
            Console.Out.WriteLine("~~~~~~~~~~~~Test object creation~~~~~~~~~~~~~~~");
            noarg.ToString();
            oneTempArg.ToString();
            oneScaleArg.ToString();
            twoArg.ToString();
            Console.Out.WriteLine("~~~~~~~~~~~~Test setters~~~~~~~~~~~~~~~");
            oneScaleArg.setTemp((float)67.0);
            oneTempArg.setScale('f');
            noarg.setAll((float)67.0, 'f');
            noarg.ToString();
            oneTempArg.ToString();
            oneScaleArg.ToString();
            twoArg.ToString();
            Console.Out.WriteLine("~~~~~~~~~~~~Test equals~~~~~~~~~~~~~~~");
            Console.Out.WriteLine(noarg.Equals(oneScaleArg) + " Should be true");
            Console.Out.WriteLine(noarg.Equals(oneTempArg) + " Should be false");



        }
    }
}
