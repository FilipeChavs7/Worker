using System;
using System.Globalization;
namespace WorkerLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLVL level = Enum.Parse<WorkerLVL>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Departament dep = new Departament(deptName);
            Worker worker = new Worker(name, level, salary, dep);

            Console.Write("How many contracts are? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerH, duration);
                worker.addContract(contract);
            }
            Console.WriteLine("Enter mouth and year to calculate income (MM/YYYY): ");
            string mounthAndYear = Console.ReadLine();
            int mounth = int.Parse(mounthAndYear.Substring(0, 2));
            int year = int.Parse(mounthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine($"Income for {mounthAndYear}: " + worker.Income(mounth, year).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
