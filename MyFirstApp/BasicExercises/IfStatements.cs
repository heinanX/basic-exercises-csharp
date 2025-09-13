namespace MyFirstApp.BasicExercises
{
    public static class IfStatements
    {
        public static void RunIfStatements()
        {
            //----------------------## IF-statements

            //# 1. smaller than 10

            // Console.Write("Enter a number: ");
            // int enteredNumber = int.Parse(Console.ReadLine() ?? "0");
            // if (enteredNumber > 10)
            // {
            //     Console.WriteLine($"{enteredNumber} is bigger than 10");
            // }
            // else
            // {
            //     Console.WriteLine($"{enteredNumber} if smaller than 10");
            // }

            //# 2. Got milk?
            // Console.Write("Number of milk cartons left: ");
            // int milk = int.Parse(Console.ReadLine() ?? "0");
            // if (milk < 10)
            // {
            //     Console.WriteLine("Order 30 more");
            // }
            // else if (milk >= 10 && milk <= 20)
            // {
            //     Console.WriteLine("Order 20 more");
            // }
            // else
            // {
            //     Console.WriteLine("You don't need to order any milk today!");
            // }

            //# 3. Got a fever?
            // Console.Write("What's your temperature: ");
            // double temp = double.Parse(Console.ReadLine() ?? "0");
            // if (temp <= 39.6)
            // {
            //     Console.WriteLine("Hon, you've got a fever.");
            // }
            // else if (temp > 37.8)s
            // {
            //     Console.WriteLine("Dude, you need a doctor!");
            // }
            // else
            // {
            //     Console.WriteLine("You don't have a fever!");
            // }


            //# 4. What's your age again?
            // Console.Write("What's your age: ");
            // string input = Console.ReadLine() ?? "";
            // if (input == "" || !double.TryParse(input, out _))
            // {
            //     Console.WriteLine("I think you forgot to enter a number");
            // }
            // else
            // {
            //     double age = double.Parse(input);

            //     if (age < 18)
            //     {
            //         Console.WriteLine("You're not of age!");
            //     }
            //     else if (age > 65)
            //     {
            //         Console.WriteLine("You're an oldie!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("You're perfect working age according to society!");
            //     }
            // }

            //# 5. Which fare?
            // Console.Write("Enter your category: ");
            // string input = Console.ReadLine() ?? "";
            // if (input == "student" || input == "Retired")
            // {
            //     Console.WriteLine("That'll be €20 for the fare, please.");
            // }
            // else if (input == "adult")
            // {
            //     Console.WriteLine("That'll be €30 for the fare, please.");

            // }
            // else
            // {
            //     Console.WriteLine("You've entered a category that doesn't exist.");

            // }


            //# 6. What's your era?
            // Console.Write("Enter the year you were born: ");
            // int input = int.Parse(Console.ReadLine() ?? "");
            // if (input >= 1980 && input < 1990)
            // {
            //     Console.WriteLine("You were born in the 80's!");

            // }
            // else if (input < 2000 && input >= 1990)
            // {
            //     Console.WriteLine("You're a 90's kid!");
            // }
            // else
            // {
            //     Console.WriteLine("Sorry, you're neither a cool 80's or 90's kid!");
            // }

            //# 7. Create a login?
            // string realUser = "helen";
            // string realPass = "passwrd";
            // Console.Write("Enter username: ");
            // string username = Console.ReadLine() ?? "";
            // Console.Write("Enter password: ");
            // string password = Console.ReadLine() ?? "";
            // if (username != realUser || realPass != password)
            // {
            //     Console.WriteLine("You've entered incorrect username or password");
            // }
            // else
            // {
            //     Console.WriteLine("You're logged in");
            // }

            //# 8. Are you Scandinavian or not?
            // Console.Write("Which country do you live in: ");
            // string country = (Console.ReadLine() ?? "").ToLower();
            // if (country == "sweden" || country == "norway" || country == "denmark")
            // {
            //     Console.WriteLine("Congrats! You're a part of Scandinavia!");
            // }
            // else
            // {
            //     Console.WriteLine("Sorry, mate! You're not a part of Scandinavia.");
            // }

            // # 9. Car brands (following instructions)
            // Console.Write("Enter a car brand: ");
            // string carBrand = (Console.ReadLine() ?? "").ToLower();

            // if (carBrand == "volvo")
            // {
            //     return;
            // }
            // else
            // {
            //     if (carBrand == "renault" || carBrand == "peugeot" || carBrand == "citroen")
            //     {
            //         return;
            //     }
            //     else if (carBrand == "volkswagen" || carBrand == "bmw" || carBrand == "audi")
            //     {
            //         Console.WriteLine($"Hey, that's a German car!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("That brand is neither German, French or Swedish.");
            //     }
            // }


            // # 9. Alternative solve using a switch
            // Console.Write("Enter a car brand: ");
            // string carBrand = (Console.ReadLine() ?? "").ToLower();
            // switch (carBrand)
            // {
            //     case "audi":
            //     case "bmw":
            //     case "volkswagen":
            //         Console.WriteLine("Hey, that's a German car!");
            //         break;

            //     case "volvo":
            //         break;

            //     case "renault":
            //      case "citroen":
            //      case "peugeot":
            //         Console.WriteLine("Ugh, Frenchy huh.");
            //         break;

            //     default:
            //         Console.WriteLine("That brand's neither German, French or Swedish.");
            //         break;
            // }

            // but after the 8+ version, we could also use a switch expression:

            // string message = carBrand switch
            // {
            //     "volkswagen" or "audi" or "bmw" => "Hey, that's German!",
            //     "volvo" => "",
            //     "renault" or "peugeot" or "citroen" => "Ugh, Frenchy huh.",
            //     _ => "That brand's neither German, French or Swedish."
            // };

            // Console.WriteLine(message);

            //# 10. Place your order.

            // Console.Write("Enter your amount of money: ");
            // string? input = Console.ReadLine();
            // if (!int.TryParse(input, out int money))
            // {
            //     Console.WriteLine("invalid amount.");
            //     return;
            // }

            // Console.Write("Do you have a discount? y/n ");
            // string discount = (Console.ReadLine() ?? "").ToLower();
            // bool haveDiscount = discount == "y" || discount == "yes";

            // if (money >= 15 && money <= 25)
            // {
            //     if (haveDiscount)
            //     {
            //         Console.WriteLine("You can buy a small fries and burger.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("You can buy a small burger.");
            //     }
            // }
            // else if (money > 25 && money <= 50)
            // {
            //     if (haveDiscount)
            //     {
            //         Console.WriteLine("You can buy a large fries and burger.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("You can buy a large burger.");
            //     }
            // }
            // else
            // {
            //     if ((haveDiscount && money > 50) || money > 60)
            //     {
            //         Console.WriteLine("You can buy a complete meal.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("You can buy a large burger.");
            //     }
            // }

            Console.ReadLine(); // Don't comment out or console window will close immediately.
        }
        public static void RunIfStatementsHardMode()
        {
            //# 1. Time converter

            // Console.Write("Enter total of minutes: ");
            // string? enteredMinutes = Console.ReadLine();
            // if (!int.TryParse(enteredMinutes, out int minutes))
            // {
            //     Console.WriteLine("invalid number.");
            //     return;
            // }
            // if (minutes < 60)
            // {
            //     Console.WriteLine($"{minutes} minutes");
            // }
            // else if (minutes > 60 && minutes < 24 * 60)
            // {
            //     int hours = minutes / 60;
            //     int mins = minutes % 60;
            //     Console.WriteLine($"This is: {hours} hours and {mins} minutes");
            // }
            // else
            // {
            //     int days = minutes / (24 * 60);
            //     int remainingMinutes = minutes % (24 * 60);
            //     int hours = remainingMinutes / 60;
            //     int mins = remainingMinutes % 60;
            //     Console.WriteLine($"This is: {days} days {hours} hours and {mins} minutes");
            // }

            //# 2. Exchanging Money

            Console.Write("Enter paid amount: ");
            string? enteredAmount = Console.ReadLine();
            if (!int.TryParse(enteredAmount, out int remainingAmount))
            {
                Console.WriteLine("invalid number.");
                return;
            }

            int fiveHundred = 0, oneHundred = 0, fifty = 0, twenty = 0, ten = 0, five = 0; // LESSON: In C# it's possible to declare multiple variables of the same type

            if (remainingAmount > 500)
            {
                fiveHundred = remainingAmount / 500;
                remainingAmount %= 500;
            }

            if (remainingAmount > 100)
            {
                oneHundred = remainingAmount / 100;
                remainingAmount %= 100;
            }

            if (remainingAmount > 50)
            {
                fifty = remainingAmount / 50;
                remainingAmount %= 50;
            }

            if (remainingAmount > 20)
            {
                twenty = remainingAmount / 20;
                remainingAmount %= 20;
            }

            if (remainingAmount > 10)
            {
                ten = remainingAmount / 10;
                remainingAmount %= 10;
            }

            if (remainingAmount > 5)
            {
                five = remainingAmount / 5;
                remainingAmount %= 5;
            }

            Console.WriteLine($"500: {fiveHundred},\n100: {oneHundred},\n50: {fifty},\n20: {twenty},\n10: {ten},\n5: {five},\n1: {remainingAmount}");

            Console.ReadLine(); // Don't comment out or console window will close immediately.
        }
    }
}
