using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoKyshta
{
    public class CarDealerShip
    {
        private int numberOfOwner;
        public int NumberOfOwner
        {
            get { return numberOfOwner; }
            set { numberOfOwner = value; }
        }

        private string licensePlate;
        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        private string engineNumber;

        public string EngineNumber
        {
            get { return engineNumber; }
            set { engineNumber = value; }
        }

        private string compartmentNumber;

        public string CompartmentNumber
        {
            get { return compartmentNumber; }
            set { compartmentNumber = value; }
        }

        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void Input()
        {
            Console.Write($"Номер на собственика: ");
            this.NumberOfOwner = int.Parse(Console.ReadLine());
            Console.Write($"Номер на автомобил: ");
            this.LicensePlate = Console.ReadLine();
            Console.Write($"Номер на двигател: ");
            this.EngineNumber = Console.ReadLine();
            Console.Write($"Номер на купе: ");
            this.CompartmentNumber = Console.ReadLine();
            Console.Write($"Марка: ");
            this.Brand = Console.ReadLine();
            Console.Write($"Цена: ");
            this.Price = double.Parse(Console.ReadLine());
            Console.Write($"Година: ");
            this.Year = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine($"Номер на собственик: 0{this.NumberOfOwner} Номер на автомобил: {this.LicensePlate} Номер на двигател: {this.EngineNumber}" +
                $" Номер на купе: {this.CompartmentNumber} Марка: {this.Brand} Цена: {this.Price}лв. Година: {this.Year}");            
        }
    }
}
