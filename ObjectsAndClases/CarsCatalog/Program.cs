using System;
using System.Collections.Generic;
using System.Linq;

namespace CarsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("/")
                .ToArray();
            List<Cars> Cars = new List<Cars>();
            List<Trucs> Trucs = new List<Trucs>();
            while (input[0]!= "end")
            {
                string brand = input[1];
                string model = input[2];
                string x = input[3];
                switch (input[0])
                {
                   
                    case "Car":
                        Cars car = new Cars(brand, model, x);
                        Cars.Add(car);
                        break;
                    case "Truck":
                        Trucs truck = new Trucs(brand, model, x);
                        Trucs.Add(truck);
                        break;
                }
                input = Console.ReadLine()
               .Split("/")
               .ToArray();
            }

           Cars.Sort((a1, a2) => a1.Brand.CompareTo(a2.Brand));
            Trucs = Trucs.OrderBy(a => a.Brand).ToList();
            Console.WriteLine("Cars:");
            PrintC(Cars);
            Console.WriteLine("Trucks:");
            PrintT(Trucs);
        }

        private static void PrintC(List<Cars> cars)
        {
            foreach (Cars car in cars)
            {
                
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HP}hp");
            }
        }

        private static void PrintT(List<Trucs> trucs)
        {
            foreach (Trucs truck in trucs)
            {
                
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    

    class Cars
        {
            public Cars(string brand, string model , string hp)
            {
                Brand = brand;
                Model = model;
                HP = hp;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HP { get; set; }


       

    }

     class Trucs
     {
            public Trucs(string brand, string model, string kg)
            {
                Brand = brand;
                Model = model;
                Weight = kg;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }

     }
   
   

}
