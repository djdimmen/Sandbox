using System;

namespace NestedDateLoop
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startYear = 2000;
            int totalNumYears = DateTime.Today.Year - startYear;
            int yearCounter = 0;
            int month;
            int numOfDays;
            string modDateFrom;
            string ToDate;

            //while (yearCounter <= totalNumYears)
            //{
            //    month = 1;
            //    while (month <= 12)
            //    {
            //        numOfDays = DateTime.DaysInMonth(startYear + yearCounter, month);

            //        if (month < 10)
            //        {
            //            modDateFrom = ("Start of Month is: " + (startYear + yearCounter) + "-0" + (month) + "-01");
            //            ToDate = ("End of Month is: " + (startYear + yearCounter) + "-0" + (month) + "-" + numOfDays);
            //        }
            //        else
            //        {
            //            modDateFrom = ("Start of Month is: " + (startYear + yearCounter) + "-" + (month) + "-01");
            //            ToDate = ("End of Month is: " + (startYear + yearCounter) + "-" + (month) + "-" + numOfDays);
            //        }

            //        Console.WriteLine(modDateFrom);
            //        Console.WriteLine(ToDate);
            //        Console.WriteLine();

            //        month++;
            //    }

            //    yearCounter++;

            //}

            //Console.ReadLine();

            //// Clean up
            //strRequestXML = "";

            //Get Last modified date from SQL database for incremental load
            int CurrentYear = DateTime.Now.Year;
            string CurrentFiscal = CurrentYear.ToString().Substring(2, 2);
            month = 0;
            numOfDays = DateTime.DaysInMonth(CurrentYear, month+1 );
            string FromDt = new DateTime(CurrentYear, month+1 , 1).ToString("yyyy-MM-dd");
            string ToDt = new DateTime(CurrentYear, month+1 , numOfDays).ToString("yyyy-MM-dd");

            while (month < 12)
            {
                numOfDays = DateTime.DaysInMonth(CurrentYear, month+1);
                FromDt = new DateTime(CurrentYear, month + 1, 1).ToString("yyyy-MM-dd");
                ToDt = new DateTime(CurrentYear, month + 1, numOfDays).ToString("yyyy-MM-dd");
                
                Console.WriteLine(FromDt);
                Console.WriteLine(ToDt);
                Console.WriteLine();

                month++;
            }

            Console.ReadLine();
        }
    }
}