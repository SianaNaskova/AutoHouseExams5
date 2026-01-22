using Autohouse;

namespace Autohouse
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<Car> cars = new List<Car>();

                Console.Write("Enter number of cars: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Car #{i + 1}");
                    Console.Write("Type (1 - Passenger, 2 - Dzhip): ");
                    int type = int.Parse(Console.ReadLine());

                    Console.Write("Auto house name: ");
                    string name = Console.ReadLine();

                    Console.Write("Address: ");
                    string address = Console.ReadLine();

                    Console.Write("Owner number: ");
                    string owner = Console.ReadLine();

                    Console.Write("Car number: ");
                    string carNum = Console.ReadLine();

                    Console.Write("Engine number: ");
                    string engNum = Console.ReadLine();

                    Console.Write("Chassis number: ");
                    string chNum = Console.ReadLine();

                    Console.Write("Brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());

                    if (type == 1)
                    {
                        Console.Write("Doors: ");
                        int doors = int.Parse(Console.ReadLine());

                        cars.Add(new LekAvtomobil(name, address, owner, carNum, engNum, chNum, brand, price, year, doors));
                    }
                    else
                    {
                        Console.Write("Drive type (AWD/FWD/RWD): ");
                        string drive = Console.ReadLine();

                        cars.Add(new Dzhip(name, address, owner, carNum, engNum, chNum, brand, price, year, drive));
                    }
                }

                Console.WriteLine("--- All cars ---");
                cars.ForEach(c => c.Info());

                Console.Write("Enter brand for search: ");
                string searchBrand = Console.ReadLine();
                cars.Where(c => c.Brand == searchBrand).ToList().ForEach(c => c.Info());

                double avgAge = cars.Average(c => DateTime.Now.Year - c.Year);
                Console.WriteLine($"Average age: {avgAge:F2}");

                Console.WriteLine("Newest car by brand:");
                var newest = cars.GroupBy(c => c.Brand)
                                 .Select(g => g.OrderByDescending(c => c.Year).First());
                foreach (var c in newest) c.Info();

                Console.WriteLine("Sorted by price:");
                cars.OrderBy(c => c.Price).ToList().ForEach(c => c.Info());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
