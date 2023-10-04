using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExceptionHandling;
using System.Globalization;

namespace Week7
{
    class CallExceptionClass
    {
        static void Main()
        {
            var currentDate = DateTime.Now;
            string strarDateOfCurrentMonth = currentDate.ToString("yyyy-MM-") + "01";

            string endDateOfCurrentMonth = currentDate.Year + "-" + currentDate.Month + "-" + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            var dt = DateTime.Now.AddYears(-1);
            var minDate = DateTime.MinValue;
            var maxDate = DateTime.MaxValue;
            decimal num = 1459.25m;
            CultureInfo culInfo = new CultureInfo("en-US");
            string usDateTimeFormat = currentDate.ToString("D", culInfo);
            string usAmount = num.ToString("C", culInfo);
            CultureInfo culInfoFr = new CultureInfo("fr-FR");
            string frDateTimeFormat = currentDate.ToString("D", culInfoFr);
            string frAmount = num.ToString("C", culInfoFr);
            Console.WriteLine(dt);
            try
            {
                //Console.WriteLine("Enter Age");
                //int age;
                //int.TryParse(Console.ReadLine(), out age);
                //ExceptionExercie.ValidateAge(age);

                //ExceptionExercie.TestIndexOutOfRangeException();
            }
            catch (Exception exception)
            {
                FileHelper.WriteFile("log.txt", exception.ToString(), "====================");
            }
            finally
            {
               
            }

            Console.WriteLine("Press any key to stop the application.");
            Console.ReadKey();
        }
    }
}
