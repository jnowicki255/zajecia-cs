using System;

namespace P05_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Aston Martin", "DB9", 2007);
            Console.WriteLine(car1.Brand);
            Console.WriteLine(car1.Model);
            //Console.WriteLine(car1.ProductionYear); - Ta linia nie zadziała, ponieważ właściwość ProductionYear posiada tylko setter.

            car1.Brand = "Dacia";
            Console.WriteLine(car1.Brand);
            Console.WriteLine(car1.Model);
            //Console.WriteLine(car1.ProductionYear);
        }
    }

    public class Car
    {
        private string brand;
        private string model;
        private int productionYear;

        public string Brand
        {
            get { return brand; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    return;

                brand = value; 
            }
        }

        public string Model
        {
            get { return model; }
        }

        public int ProductionYear
        {
            set { productionYear = value; }
        }

        public int EngineCapacity { get; private set; }

        public Car(string brand, string model, int productionYear)
        {
            this.brand = brand;
            this.model = model;
            this.productionYear = productionYear;
            this.EngineCapacity = 6000;
        }
    }
}
