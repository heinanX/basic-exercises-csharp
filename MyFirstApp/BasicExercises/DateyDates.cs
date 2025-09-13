using static MyFirstApp.BasicExercises.RecurringMethods;
namespace MyFirstApp.BasicExercises
{
    public static class DateyDates
    {
        public static void RunDateyDates()
        {

            //# ----------------------- 1. Printing Date of Birth
            // Console.Write("Enter your date of birth (MM/DD/YYYY)? ");

            // if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthDate)){
            //     Log("Incorrect format");
            //     return;
            // }
            // string dayIndicator = (birthDate.Day % 10) switch
            // {
            //     1 when birthDate.Day != 11 => "st",
            //     2 when birthDate.Day != 12 => "nd",
            //     3 when birthDate.Day != 13 => "rd",
            //     _ => "th"
            // };
            // string monthIndicator = (birthDate.Month % 10) switch
            // {
            //     1 when birthDate.Month != 11 => "st",
            //     2 when birthDate.Month != 12 => "nd",
            //     3 => "rd",
            //     _ => "th"
            // };

            // Log($"You are {DateTime.Now.Year - birthDate.Year}. Your date of birth is {birthDate.Year}, on the {birthDate.Month}{monthIndicator} month, and the {birthDate.Day}{dayIndicator} day.");

            //# ----------------------- 2. Adding time to entered date
            // Console.Write("Enter a date (MM/DD/YYYY)? ");

            // if (!DateTime.TryParse(Console.ReadLine(), out DateTime date)){
            //     Log("Incorrect format");
            //     return;
            // }
            // Log(date.AddMonths(4).AddYears(1).ToShortDateString());


            //# ----------------------- 3. Comparing dates
            Console.Write("Enter a date (MM/DD/YYYY)? ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date1))
            {
                Log("Incorrect format");
                return;
            }
            ;
            Console.Write("Enter a date (MM/DD/YYYY)? ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date2))
            {
                Log("Incorrect format");
                return;
            }


            int compare = DateTime.Compare(date1, date2);
            if (compare == 0)
            {
                Log($"Nice one. The dates are the same.");
                return;
            }

            TimeSpan interval = date1 > date2 ? date1 - date2 : date2 - date1;
            if (compare < 0)
            {
                Log($"{date2.ToShortDateString()} is later than {date1.ToShortDateString()} by {interval.Days} days.");
            }
            else if (compare > 0)
            {
                Log($"{date1.ToShortDateString()} is later than {date2.ToShortDateString()} by {interval.Days} days.");
            }


            Console.ReadLine();
        }
    }
}