using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Catalog> veahicle = new List<Catalog>();

            while (input[0] != "End")
            {
                Catalog newCar = new Catalog(input[0], input[1], input[2], 
                    double.Parse(input[3]));


                veahicle.Add(newCar);

                input = Console.ReadLine()
                .Split()
                .ToArray();

            }
            
            string modelToprint = Console.ReadLine();

            while (modelToprint != "Close the Catalogue")
            {
                //int index = veahicle.FindIndex(x => x.Model == modelToprint);

                //Console.WriteLine(veahicle[index]);
                Catalog pritCar = veahicle.First(x => x.Model == modelToprint);
                Console.WriteLine(pritCar);

                modelToprint = Console.ReadLine();
            }

            Catalog[] cars = veahicle.Where(x => x.Type == "car")
               .ToArray();
            List<Catalog> trucs = veahicle.Where(z => z.Type == "truck")
              .ToList();
            double truckSum = 0;
            double carsum = 0;
            double carsCout = 0;

            foreach (var carTruck in veahicle)
            {
                if (carTruck.Type == "car")
                {
                    carsum += carTruck.HP;
                    carsCout++;

                }
                else if (carTruck.Type == "truck")
                {
                    truckSum += carTruck.HP;
                    
                }
            }

            if (cars.Length >0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(carsum / carsCout):F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (trucs.Count >0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(truckSum / (veahicle.Count - carsCout)):F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
           


            //foreach (var truck in trucs)
            //{

            //    truckSum += truck.HP;
            //}
            //foreach (var car in cars)
            //{
            //    carsum += car.HP;
            //}


           
            

           // Console.WriteLine($"Cars have average horsepower of: {(carsum / cars.Length):F2}.");
           //Console.WriteLine($"Trucks have average horsepower of: {(truckSum / trucs.Count):F2}.");
        }
    }
    class Catalog
    {
        public Catalog(string type, string model, string color, double hp)
        {
            Type = type;
            Model = model;
            Color = color;
            HP = hp;

        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HP { get; set; }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")} ");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HP}");

            return sb.ToString().TrimEnd();
        }
    }
}
