using System;
using System.Collections.Generic;

public class Car
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public int Year { get; private set; }

    public string Color { get; private set; }
    public int HorsePower { get; private set; }

    public Car(string brand, string model, int year, string color, int horsePower)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        HorsePower = horsePower;
    }
}

public class Program
{
    public static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Ford", "Mustang", 1963, "Red", 430),
            new Car("Toyota", "Camry", 2020, "Blue", 200),
            new Car("Chevrolet", "Corvette", 2022, "Silver", 650),
            new Car("Honda", "Civic", 2018, "Black", 174),
            new Car("BMW", "M3", 2021, "White", 503),
            new Car("Mercedes-Benz", "C-Class", 2019, "Gray", 255),
            new Car("Audi", "A4", 2020, "Silver", 201),
            new Car("Volkswagen", "Golf", 2019, "Blue", 228),
            new Car("Tesla", "Model S", 2022, "Black", 1020),
            new Car("Kia", "Sorento", 2021, "Red", 191),
            new Car("Hyundai", "Elantra", 2020, "Green", 147),
            new Car("Mazda", "CX-5", 2021, "White", 187),
            new Car("Nissan", "Altima", 2018, "Gray", 182),
            new Car("Jeep", "Wrangler", 2022, "Yellow", 285),
            new Car("Subaru", "Outback", 2019, "Blue", 182),
            new Car("Ford", "Explorer", 2020, "Black", 300),
            new Car("Chevrolet", "Malibu", 2018, "White", 160),
            new Car("Toyota", "Highlander", 2021, "Silver", 295),
            new Car("Honda", "Pilot", 2022, "Gray", 280),
            new Car("Lexus", "RX", 2020, "Blue", 295),
            new Car("Infiniti", "Q50", 2019, "Red", 300),
            new Car("Cadillac", "Escalade", 2021, "Black", 420),
            new Car("Acura", "TLX", 2020, "Silver", 272),
            new Car("GMC", "Sierra", 2018, "White", 355),
            new Car("Dodge", "Charger", 2019, "Black", 292),
            new Car("Ram", "1500", 2021, "Gray", 305),
            new Car("Tesla", "Model X", 2022, "White", 1020),
            new Car("Ford", "Bronco", 2021, "Yellow", 300),
            new Car("Chevrolet", "Impala", 2020, "Blue", 305),
            new Car("Toyota", "Tacoma", 2019, "Silver", 278),
            new Car("Mazda", "Mazda3", 2021, "Red", 186),
            new Car("Hyundai", "Tucson", 2020, "Green", 187),
            new Car("Subaru", "Impreza", 2018, "Blue", 152),
            new Car("Nissan", "Maxima", 2022, "Gray", 300),
            new Car("Volkswagen", "Passat", 2019, "White", 174),
            new Car("Jeep", "Cherokee", 2021, "Silver", 271),
            new Car("Honda", "Accord", 2020, "Red", 192),
            new Car("Toyota", "Corolla", 2019, "Blue", 169),
            new Car("Audi", "Q5", 2021, "Black", 261),
            new Car("BMW", "X5", 2020, "White", 335),
            new Car("Mercedes-Benz", "GLC", 2022, "Gray", 255),
            new Car("Lexus", "ES", 2019, "Silver", 203),
            new Car("Chevrolet", "Blazer", 2020, "Red", 308),
            new Car("Ford", "F-150", 2021, "Blue", 400),
            new Car("Kia", "Telluride", 2022, "White", 291),
            new Car("Mazda", "MX-5 Miata", 2018, "Black", 181),
            new Car("Nissan", "Pathfinder", 2020, "Silver", 284),
            new Car("Subaru", "Forester", 2019, "Green", 182),
            new Car("Honda", "Ridgeline", 2021, "Gray", 280),
            new Car("Acura", "RDX", 2022, "Blue", 272),
            new Car("Genesis", "G80", 2019, "Red", 300),
            new Car("Toyota", "4Runner", 2020, "Black", 270),
            new Car("Volkswagen", "Atlas", 2021, "White", 276),
            new Car("GMC", "Acadia", 2022, "Blue", 310),
            new Car("Dodge", "Durango", 1987, "Gray", 293),
            new Car("Lexus", "NX", 2021, "Silver", 235),
            new Car("Audi", "A6", 1988, "Blue", 335),
            new Car("Ford", "Edge", 2020, "Black", 250),
            new Car("Chevrolet", "Traverse", 2021, "White", 310),
            new Car("Hyundai", "Palisade", 2022, "Gray", 291),
            new Car("Tesla", "Model Y", 2020, "Red", 456),
            new Car("BMW", "7 Series", 2021, "Silver", 335),
            new Car("Mercedes-Benz", "S-Class", 2019, "Black", 362),
            new Car("Cadillac", "XT6", 2022, "Blue", 310),
            new Car("Ram", "2500", 2021, "White", 410),
            new Car("Nissan", "Titan", 2020, "Gray", 400),
            new Car("Toyota", "Sequoia", 2019, "Silver", 381),
            new Car("Jeep", "Gladiator", 2020, "Blue", 285),
            new Car("Chevrolet", "Silverado", 2021, "Red", 420),
            new Car("Honda", "Odyssey", 1999, "White", 280),
            new Car("Ford", "Transit", 1998, "Black", 275),
            new Car("Subaru", "Ascent", 1985, "Gray", 260),
            new Car("Mazda", "CX-9", 2021, "Blue", 250),
            new Car("Genesis", "GV80", 2022, "Red", 300),
            new Car("Audi", "Q7", 2020, "White", 335),
            new Car("BMW", "X7", 2021, "Black", 523),
            new Car("Mercedes-Benz", "GLS", 2019, "Silver", 362),
            new Car("Volkswagen", "Tiguan", 2022, "Blue", 184),
            new Car("Toyota", "Land Cruiser", 2021, "Gray", 381),
            new Car("Honda", "HR-V", 2020, "Red", 141),
            new Car("Kia", "Seltos", 1982, "Blue", 175),
            new Car("Hyundai", "Venue", 2022, "White", 121),
            new Car("Nissan", "Kicks", 1984, "Gray", 122),
            new Car("Ford", "Escape", 2021, "Silver", 250),
            new Car("Chevrolet", "Equinox", 2022, "Red", 252),
            new Car("Subaru", "Crosstrek", 2019, "Green", 182),
            new Car("Mazda", "CX-3", 2020, "Blue", 148),
            new Car("Tesla", "Model 3", 2021, "White", 450),
            new Car("Lexus", "GX", 2022, "Gray", 301),
            new Car("Acura", "MDX", 2020, "Black", 290),
            new Car("Genesis", "G70", 2021, "Silver", 365),
        };


        Console.Write("Enter a car brand to search: ");
        string brandToSearch = Console.ReadLine();
        Console.Write("Enter a color ");
        string ColorSearch = Console.ReadLine();
        Console.Write("Enter Hoursepower ");
        string HoursePower = Console.ReadLine();

        int Brands = 0;
        int Colors = 0;
        int Power = 0;
        int First = 0;
        int Year = 0;
        int biller = 0;

        string firstCarBrand = cars[0].Brand;


        Console.WriteLine($"\nCars that share the same brand as the first car: '{firstCarBrand}':\n ");


        foreach (var car in cars)
        {
            if (car.Brand == firstCarBrand)
            {
                Console.WriteLine($"- {car.Year} {car.Brand} {car.Model} ({car.Color}, {car.HorsePower} HP)");
            }
        }
        foreach (var car in cars)
        {
            if (car.Brand == firstCarBrand)
            {
                First++;
            }
        }


        foreach (var car in cars)
        {
            if (car.Brand == brandToSearch)
            {
                Brands++;
            }
        }



        foreach (var car in cars)
        {
            if (car.Color == ColorSearch)
            {
                Colors++;
            }
        }
        

        foreach (var car in cars)
        {
            if (car.HorsePower > 200)
            {
                Power++;

            }
        }
        Console.WriteLine("\nhow many cars from 1980 to 1999\n");
        foreach (var car in cars)
        {
            if (car.Year >= 1980 && car.Year <= 1999)
            {
                Console.WriteLine($"- {car.Year} {car.Brand} {car.Model} ({car.Color}, {car.HorsePower} HP) \n");
                Year++;
            }
        }
        foreach (var car in cars)
        {
            if (car.Year > 100)
            {
                biller++;
            }
        }
        Console.WriteLine($"how many cars from 1980-1999: {Year} \n");



        // Output the result
        Console.WriteLine($"Number of cars with brand: '{brandToSearch}': {Brands}\n");
        Console.WriteLine($"How many cars with over 200 HorsePower: {Power} \n");
        Console.WriteLine($"How many cars with the same brand as the first car: {First} \n");
        Console.WriteLine($"how many cars there are {biller}\n");
        Console.WriteLine($"Number of Colors: '{ColorSearch}': {Colors}\n");
    }
}