using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential16._4
{

    class Date
    {
        public int Day
        {
            get => day;
            set
            {
                if (value<=0)
                {
                    throw new Exception("Day cant be <=0");
                }
                if (value > 31)
                {
                    throw new Exception("Day cant be >31");
                }
                day = value;
            }
        }
        private int day;
        private int month;
        public int Month
        {
            get => month;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Month cant be <=0");
                }
                if (value > 12)
                {
                    throw new Exception("Month cant be >12");
                }
                month = value;
            }
        }

        public int Year { get; set; }
        public Date(int day,int month,int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public static int operator -(Date date1,Date date2)
        {

            TimeSpan timeSpan = new DateTime(date1.Year, date1.Month, date1.Day)
                - new DateTime(date2.Year, date2.Month, date2.Day);

            return timeSpan.Days;
        }

        public static Date operator +(Date date,int days)
        {
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day).AddDays(days);
            return new Date(dateTime.Day, dateTime.Month, dateTime.Year);
        }

        public override string ToString()
        {
            return $"Year: {Year}, Month: {Month}, Day: {Day}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Date date1 = new Date(32, 5, 2018);
                Date date2 = new Date(10, 6, 2018);
                Console.WriteLine(date1 + 11);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();

        }
    }
}
