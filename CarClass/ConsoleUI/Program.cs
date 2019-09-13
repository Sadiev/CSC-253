using System;

/**
* 08/24/2019
* CSC 253
* Dilshod Sadiev
* Car Class
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(2017, "Ford");//test
            while (true)
            {
                Console.Write("1.Accelerate\n2.Brake\nEnter 1 ,2 or any key to Exit > ");
                switch (Console.ReadLine())
                {
                    case "1":
                        car.Accelerate();
                        break;
                    case "2":
                        car.Brake();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
    }
    class Car
    {
        public ushort Year { get; set; }
        public string Make { get; set; }
        public byte Speed { get; set; }
        public Car(ushort year, string make)
        {
            Year = year;
            Make = make;
            Speed = 0;
        }
        public void Accelerate()
        {
            Speed += 5;
            Console.WriteLine($"\nCurrent speed is {Speed}.\n");
        }
        public void Brake()
        {
            if (Speed>0)
            Speed -= 5;
            Console.WriteLine($"\nCurrent speed is {Speed}.\n");
        }
    }
}
