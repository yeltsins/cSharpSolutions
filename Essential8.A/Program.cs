using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential8.A
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeWorker dateTimeWorker = new DateTimeWorker()
            { BirthdayDate = new DateTime(1993, 5, 22) };
            Console.WriteLine(dateTimeWorker.DaysToNextBirthday().Days);
            Console.ReadLine();
        }
    }

    class DateTimeWorker
    {
        public DateTime BirthdayDate { get; set; }
        public TimeSpan DaysToNextBirthday()
        {
            DateTime now = DateTime.Now;
            return new DateTime((BirthdayDate.Month<now.Month)||(BirthdayDate.Month== now.Month&&BirthdayDate.Day<=now.Day) ?now.Year+1:now.Year
                , BirthdayDate.Month
                , BirthdayDate.Day) - now;
        }
    }
}
