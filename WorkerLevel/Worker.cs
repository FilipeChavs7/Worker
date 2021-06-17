using System;
using System.Collections.Generic;
namespace WorkerLevel
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLVL Level { get; set; }
        public double baseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLVL level, double baseSalary, Departament departament) : this(name, level, baseSalary)
        {
            Departament = departament;
        }

        public Worker(string name, WorkerLVL level, double baseSalary)
        {
            Name = name;
            Level = level;
            this.baseSalary = baseSalary;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int month, int year)
        {
            double sum = baseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}