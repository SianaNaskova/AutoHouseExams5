using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohouse
{
    public class Dzhip : Car
    {
        private string driveType;

        public string DriveType
        {
            get { return driveType; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Drive type cannot be empty!");
                driveType = value;
            }
        }

        public Dzhip(string name, string address, string ownerNumber,
                     string carNumber, string engineNumber, string chassisNumber,
                     string brand, double price, int year, string driveType)
            : base(name, address, ownerNumber, carNumber, engineNumber, chassisNumber, brand, price, year)
        {
            DriveType = driveType;
        }



        public override void Info()
        {
            Console.WriteLine(" Type: ");
            base.Info();
            Console.WriteLine("=== Dzhip ===");
            Console.WriteLine();
        }
    }

}
