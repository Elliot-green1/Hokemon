using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon!");

            // Instantiation of new Hokemon
            
                        Hokemon hoke01 = new Hokemon();  // INSTANTIATE new Hokemon object referred to as Hoke01
                        hoke01.get_details();
                        Console.WriteLine($"Attack value is: {hoke01.attackCalculator()}");
                        Console.WriteLine($"Defence value is: {hoke01.defenceCalculator()}");
                        Hokemon hoke02 = new Hokemon();  // INSTANTIATE Hoke02
                        hoke02.get_details();
                        Console.WriteLine($"Attack value is: {hoke02.attackCalculator()}");
                        Console.WriteLine($"Defence value is: {hoke02.defenceCalculator()}");

                        Hokemon hokemonObject = new Hokemon();  // INSTANTIATE hokemonObject
                        hokemonObject.get_details();
                        Console.WriteLine($"Attack value is: {hokemonObject.attackCalculator()}");
                        Console.WriteLine($"Defence value is: {hokemonObject.defenceCalculator()}");
            
           

        }
    }
}
