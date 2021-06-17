using System;
namespace WorkerLevel
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int horas)
        {
            this.Date = date;
            this.valuePerHour = valuePerHour;
            this.Hours = horas;
        }
        public double TotalValue()
        {
            return valuePerHour * Hours;
        }
    }
}
