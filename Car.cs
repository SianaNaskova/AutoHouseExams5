using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohouse
{
    public abstract class Car : AutoHouse
    {
        private string carNumber;
        private string engineNumber;
        private string chassisNumber;
        private string brand;
        private double price;
        private int year;

        public string CarNumber
        {
            get { return carNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Car number cannot be empty!");
                carNumber = value;
            }
        }

        public string EngineNumber
        {
            get { return engineNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Engine number cannot be empty!");
                engineNumber = value;
            }
        }

        public string ChassisNumber
        {
            get {return chassisNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Chassis number cannot be empty!");
                chassisNumber = value;
            }
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Brand cannot be empty!");
                brand = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price must be positive!");
                price = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1950 || value > DateTime.Now.Year)
                    throw new ArgumentException("Invalid year!");
                year = value;
            }
        }

        protected Car(string name, string address, string ownerNumber,
            string carNumber, string engineNumber, string chassisNumber,
            string brand, double price, int year)
            : base(name, address, ownerNumber)
        {
            CarNumber = carNumber;
            EngineNumber = engineNumber;
            ChassisNumber = chassisNumber;
            Brand = brand;
            Price = price;
            Year = year;
        }

        public override void Info()
        {
            Console.WriteLine($"Car number: {CarNumber}");
            Console.WriteLine($"Engine number: {EngineNumber}");
            Console.WriteLine($"Chassis number: {ChassisNumber}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: {Price} euro");
            Console.WriteLine($"Year: {Year}");
        }
    }
}
