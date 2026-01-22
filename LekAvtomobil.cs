using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohouse
{
    public class LekAvtomobil : Car
    {
        private int doors;

        public int Doors
        {
            get { return doors; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Doors must be positive!");
                doors = value;
            }
        }

        public LekAvtomobil(string name, string address, string ownerNumber,
                       string carNumber, string engineNumber, string chassisNumber,
                       string brand, double price, int year, int doors)
       : base(name, address, ownerNumber, carNumber, engineNumber, chassisNumber, brand, price, year)
        {
            Doors = doors;
        }

        public override void Info()
        {
            Console.WriteLine("=== Lek Avtomobil ===");
            base.Info();
            Console.WriteLine($"Doors: {Doors}");
            Console.WriteLine();
        }
    }

}
