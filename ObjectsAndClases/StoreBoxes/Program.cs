using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BoxInfo> boxes =  new List<BoxInfo>();
            List<PriceName> items = new List<PriceName>();

            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();
            while (input[0] != "end"&& input[0] != "End")
            {
                PriceName item = new PriceName();
                BoxInfo box = new BoxInfo();


                
                item.Namee = input[1];
                double pr = double.Parse(input[3]);
                item.Price = pr;
                double priceOfBox = double.Parse(input[3]) * double.Parse(input[2]);
                items.Add(item);

                box.SN = int.Parse(input[0]);
                box.Name = input[1];
                box.Qusntity = int.Parse(input[2]);
                box.BoxPrice = priceOfBox;
                box.Price= double.Parse(input[3]) ;

                boxes.Add(box);

                input = Console.ReadLine()
                .Split(" ")
                .ToArray();


            }

            for (int i = 0; i < boxes.Count; i++)
            {
                for (int j = i; j < boxes.Count; j++)
                {
                    if (boxes[j].BoxPrice> boxes[i].BoxPrice)
                    {
                        BoxInfo dj = boxes[i];
                        boxes[i] = boxes[j];
                        boxes[j] = dj;
                       // Console.WriteLine(boxes[j + 1].BoxPrice);

                    }
               }
            }
            foreach (BoxInfo box in boxes)
            {
                Console.WriteLine($"{box.SN}");
                Console.WriteLine($"-- {box.Name} - ${box.Price:F2}: {box.Qusntity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }

                
        }
        
    
        class BoxInfo
        {

            public int SN { get; set; }
            public string Name { get; set; }
            // public Item Item { get; set } 
            public int Qusntity { get; set; }
            public double BoxPrice { get; set; }
            public double Price { get; set; }
        }
        class PriceName
        {
            public string Namee { get; set; }
            public double Price { get; set; }

        }
    }


}
