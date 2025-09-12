namespace BasicExercises
{
    public static class Variables
    {
        public static void RunVariables()
        {
            // Console.WriteLine("What's your name?");
            // var name = Console.ReadLine();
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine} Hello, {name}! Today is {currentDate}");
            // Console.ReadKey(true);

            // # Assign 1
            // string name = "Linda";
            // Console.WriteLine($"Hello {name}");

            //# Assign 2
            // string name = "Linda";
            // int age = 35;
            // Console.WriteLine($"My name is {name} and I'm {age} years old.");

            //# Assign 3
            // Console.WriteLine("this is the what");
            // Console.WriteLine("this is the who");
            // Console.Write("this is the why");
            // Console.Write("this is the who knows what");

            //# Assign 4
            // Console.Write("What's your name? ");
            // string firstName = Console.ReadLine() ?? "No input";
            // Console.Write("What's your last name? ");
            // string? lastName = Console.ReadLine() ?? "No input";
            // Console.WriteLine($"Your name is: {lastName} {firstName}");

            //# Assign 5
            // Console.Write("Write a number: ");
            // var num1 = int.Parse(Console.ReadLine() ?? "0");
            // Console.Write("What's the operator? ");
            // string op = Console.ReadLine() ?? "+";
            // while (op != "+" && op != "-" && op != "*")
            // {
            //     Console.WriteLine("Accepted operators: + or - or *");
            //     Console.Write("What's the operator? ");
            //     op = Console.ReadLine() ?? "+";
            // }
            // Console.Write("Write a second number: ");
            // var num2 = int.Parse(Console.ReadLine() ?? "0");
            // int sum;
            // if (op == "+")
            // {
            //     sum = num1 + num2;
            // }
            // else if (op == "-")
            // {
            //     sum = num1 - num2;
            // }
            // else
            // {
            //     sum = num1 * num2;
            // }

            // Console.WriteLine($"the sum of {num1} {op} {num2} is {sum}.");

            //# Assign 6
            // Console.Write("What year were you born: ");
            // var num1 = int.Parse(Console.ReadLine() ?? "0");
            // int currentAge = DateTime.Now.Year - num1;
            // Console.WriteLine($"Your age is: {currentAge}");

            //# Assign 7

            // Console.Write("Write a number: ");
            // var num1 = int.Parse(Console.ReadLine() ?? "0");
            // Console.Write("Write a second number: ");
            // var num2 = int.Parse(Console.ReadLine() ?? "0");
            // Console.WriteLine($"Sum: {num1 + num2}");
            // Console.WriteLine($"Difference: {Math.Abs(num1 - num2)}");
            // Console.WriteLine($"Median: {(num1 + num2) / 2.0}");

            // Lesson: C# int / int = int 3/2 = 1
            //         JS number is a float by default hence 3/2 = 1.5

            //# Assign 8
            // Console.Write("Enter sum: ");
            // var num1 = int.Parse(Console.ReadLine() ?? "0");
            // double total = num1 * 1.25;
            // Console.WriteLine($"Price including tax: {total}");

            //# Assign 9
            Console.Write("Enter total of minutes: ");
            var enteredInput = int.Parse(Console.ReadLine() ?? "0");
            while (enteredInput < 60)
            {
                Console.Write("Enter total of minutes: ");
                enteredInput = int.Parse(Console.ReadLine() ?? "0");
            }
            int hours = enteredInput / 60;
            int minutes = enteredInput % 60; //REMINDER: modulus gives leftover value


            Console.WriteLine($"This is: {hours} hours and {minutes} minutes");

            Console.ReadLine(); // Don't comment out or console window will close immediately.
        }
    }
}
