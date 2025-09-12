using System.Diagnostics.Metrics;

namespace BasicExercises
{
    public static class ArrayRays
    {

        //Lists: Your go-to for dynamic, ordered collections where elements can grow and shrink effortlessly.

        // Arrays: The efficient choice for fixed-size collections with predictable memory usage and blazing-fast indexing.

        // Dictionaries: Perfect for quick lookups and managing key-value pairs with unmatched speed and clarity.

        // Stacks: Ideal for last-in-first-out (LIFO) operations, like tracking history or nested structures.

        // Queues: Best for first-in-first-out (FIFO) tasks, like processing jobs or managing sequential workflows.

        // HashSets: The choice for collections where uniqueness matters and fast lookups are key.
        //ref: https://www.freecodecamp.org/news/how-to-use-collections-in-csharp/

        public static void RunArrayRays()
        {
            //# 1. ------------------------------------------------------------------------ Save a customers information.

            // string[] customer = new string[6];
            // bool allFieldsCompleted = true;

            // while (allFieldsCompleted)
            // {
            //     if (string.IsNullOrEmpty(customer[0]))
            //     {
            //         Console.Write("Name: ");
            //         customer[0] = Console.ReadLine() ?? "";
            //     }
            //     if (string.IsNullOrEmpty(customer[1]))
            //     {
            //         Console.Write("Last Name: ");
            //         customer[1] = Console.ReadLine() ?? "";
            //     }
            //     if (string.IsNullOrEmpty(customer[2]))
            //     {
            //         Console.Write("Address: ");
            //         customer[2] = Console.ReadLine() ?? "";
            //     }
            //     if (string.IsNullOrEmpty(customer[3]))
            //     {
            //         Console.Write("City: ");
            //         customer[3] = Console.ReadLine() ?? "";
            //     }

            //     if (string.IsNullOrEmpty(customer[4]))
            //     {
            //         Console.Write("Phone: ");
            //         customer[4] = Console.ReadLine() ?? "";
            //     }

            //     if (string.IsNullOrEmpty(customer[5]))
            //     {
            //         Console.Write("Email: ");
            //         customer[5] = Console.ReadLine() ?? "";
            //     }

            //     if (!string.IsNullOrEmpty(customer[0]) && !string.IsNullOrEmpty(customer[1]) && !string.IsNullOrEmpty(customer[2]) && !string.IsNullOrEmpty(customer[3]) && !string.IsNullOrEmpty(customer[4]) && !string.IsNullOrEmpty(customer[5]))
            //     {
            //         Console.WriteLine("");
            //         Console.WriteLine("");
            //         Console.WriteLine($"You've entered the following information: \n\nName: {customer[0]} \nLast Name: {customer[1]} \nAddress: {customer[2]}");
            //         Console.WriteLine($"City: {customer[3]} \nPhone: {customer[4]} \nEmail: {customer[5]} \nIs this correct (y/n)?");
            //         if ((Console.ReadLine() ?? "") == "y")
            //         {
            //             allFieldsCompleted = false;
            //         }
            //         else
            //         {
            //             Console.WriteLine("Too bad you're stuck with it P:");
            //             allFieldsCompleted = false;
            //         }
            //     }
            // }



            //# 2. ------------------------------------------------------------------------ Log Largest Number

            // int[] numbers = new int[4];
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write("Enter a number: ");
            //     if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //     {
            //         Console.WriteLine("Invalid number.");
            //         return;
            //     }
            // }

            // int largestNo = numbers[0];
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     if (largestNo < numbers[i]) largestNo = numbers[i];
            // }
            // Console.WriteLine(largestNo);


            //# 3. ------------------------------------------------------------------------ Log Largest Number with Custom Entries            

            // Console.Write("Enter how many times to enter a number: ");
            // if (!int.TryParse(Console.ReadLine(), out int iterator))
            // {
            //     Console.WriteLine("Invalid number.");
            //     return;
            // }
            // int[] numbers = new int[iterator];

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write("Enter number: ");
            //     if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //     {
            //         Console.WriteLine("Invalid number. Exiting program.");
            //         return;
            //     }
            // }

            // int largestNumber = numbers[0];
            // foreach (var n in numbers)
            // {
            //     if (n > largestNumber) largestNumber = n;
            // }
            // Console.WriteLine(largestNumber);


            // # ------------------------------------------------------------------------ 4. Odd Numbers' Out

            // int[] numbers = [2, 5, 8, 9, 12];

            // for (int i = 0; i < 5; i++)
            // {
            //     if ((numbers[i] % 2) != 0) numbers[i] = 0;
            // }
            // foreach (int n in numbers) Console.WriteLine(n);


            // # ------------------------------------------------------------------------ 5. Temperature Tracking

            // Console.Write("How many entries would you like to make? ");
            // if (!int.TryParse(Console.ReadLine(), out int n))
            // {
            //     Console.WriteLine("Invalid number. Exiting program.");
            //     return;
            // }
            // double[] temperatures = new double[n];
            // double highestTemp = double.MinValue;
            // double allTemps = 0;
            // for (int i = 0; i < temperatures.Length; i++)
            // {
            //     Console.Write("Enter temperature: ");
            //     if (!double.TryParse(Console.ReadLine(), out double degree))
            //     {
            //         Console.WriteLine("Invalid number. Exiting program.");
            //         return;
            //     }
            //     temperatures[i] = degree;
            //     allTemps += degree;
            //     if (degree > highestTemp) highestTemp = degree;
            // }
            // foreach (double t in temperatures)
            // {
            //     Console.WriteLine(t);
            // }
            // Console.WriteLine("");
            // Console.WriteLine($"Average temperature was: {allTemps / temperatures.Length:F1}, with {highestTemp} being the highest on record.");


            // # ------------------------------------------------------------------------ 6. Temperature Tracking with Dates

            // Console.Write("How many entries would you like to make? ");
            // if (!int.TryParse(Console.ReadLine(), out int n))
            // {
            //     Console.WriteLine("Invalid number. Exiting program.");
            //     return;
            // }
            // double[] temperatures = new double[n];
            // DateTime[] dates = new DateTime[n];
            // double highestTemp = double.MinValue;
            // double allTemps = 0;
            // for (int i = 0; i < temperatures.Length; i++)
            // {
            //     Console.Write("Enter day (MM/dd/yyyy): ");
            //     if (!DateTime.TryParse(Console.ReadLine(), out dates[i]))
            //     {
            //         Console.WriteLine("Invalid date. Exiting program.");
            //         return;
            //     }
            //     Console.Write("Enter temperature: ");
            //     if (!double.TryParse(Console.ReadLine(), out double degree))
            //     {
            //         Console.WriteLine("Invalid number. Exiting program.");
            //         return;
            //     }
            //     temperatures[i] = degree;
            //     allTemps += degree;
            //     if (degree > highestTemp) highestTemp = degree;
            // }
            // for (int i = 0; i < temperatures.Length; i++)
            // {
            //     Console.WriteLine($"{dates[i]:MM/dd/yyyy}: {temperatures[i]}");
            // }
            // Console.WriteLine("");
            // Console.WriteLine($"Average temperature was: {allTemps / temperatures.Length:F1}, with {highestTemp} being the highest on record.");


            // # ------------------------------------------------------------------------ 7. Shopping List using 2D Array

            // Console.Write("How many items do you want on your shopping list? ");
            // if (!int.TryParse(Console.ReadLine(), out int n))
            // {
            //     Console.WriteLine("Invalid number. Exiting program.");
            //     return;
            // }

            // string[,] shoppingList = new string[n, 3];
            // double sum = 0;

            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("\nEnter item: ");
            //     shoppingList[i, 0] = Console.ReadLine() ?? "";

            //     Console.Write("Enter price: ");
            //     shoppingList[i, 1] = Console.ReadLine() ?? "";
            //     sum += double.Parse(shoppingList[i, 1]);

            //     Console.Write("Enter item type: ");
            //     shoppingList[i, 2] = Console.ReadLine() ?? "";
            // }

            // Console.WriteLine("\nYour shopping list:");
            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"{shoppingList[i, 2]}, {shoppingList[i, 0]} - {shoppingList[i, 1]} kr");
            // }
            // Console.WriteLine($"\ntotal cost: {sum}");


            // # ------------------------------------------------------------------------ 8. Saving Contacts Using 2D Array

            // string[,] contacts = new string[5, 4];
            // int counter = 0;

            // while (counter < 5)
            // {
            //     Console.Write("Enter name:  ");
            //     contacts[counter, 0] = Console.ReadLine() ?? "";

            //     Console.Write("Enter address:  ");
            //     contacts[counter, 1] = Console.ReadLine() ?? "";

            //     Console.Write("Enter zip code:  ");
            //     contacts[counter, 2] = Console.ReadLine() ?? "";

            //     Console.Write("Enter city:  ");
            //     contacts[counter, 3] = Console.ReadLine() ?? "";

            //     counter++;
            //     if (counter == 5)
            //     {
            //         Console.WriteLine("");
            //         Console.WriteLine("Contacts full");
            //         Console.WriteLine("");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Do you want to register another contact (y/n)? [{counter}/{contacts.GetLength(0)}]");
            //         string answer = (Console.ReadLine() ?? "").ToLower();

            //         if (answer != "yes" && answer != "y") break;
            //     }

            // }

            // for (int i = 0; i < contacts.GetLength(0); i++)
            // {
            //     if (string.IsNullOrEmpty(contacts[i, 0]))
            //     {
            //         continue;
            //     }
            //     else
            //     {
            //         Console.WriteLine($"\nName:{contacts[i, 0]},\nAddress: {contacts[i, 1]},\nZip Code: {contacts[i, 2]},\nCity: {contacts[i, 3]}");
            //     }
            // }

            Console.ReadLine(); // Don't comment out or console window will close immediately.
        }

        public static void RunArrayRaysHardMode()
        {
            // # ------------------------------------------------------------------------ 1. Saving (the right) numbers
            // int[] numbers = new int[10];
            // int index = 0;
            // int guess = 0;
            // while (index < 10)
            // {
            //     guess++;
            //     Console.WriteLine("Enter a number: ");
            //     if (!int.TryParse(Console.ReadLine(), out int number))
            //     {
            //         Console.WriteLine("Input not a number. Try again!");
            //         continue;
            //     }
            //     else if (number > 30)
            //     {
            //         numbers[index] = number;
            //         index++;
            //         Console.WriteLine($"index: {index}");

            //     }
            //     else
            //     {
            //         continue;
            //     }
            // }
            // Console.WriteLine($"It took you {guess} guesses to finish!");


            // # ------------------------------------------------------------------------ 2. Saving words
            // string[] words = new string[5];
            // string longestWord = "";

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write("Write a word: ");
            //     words[i] = Console.ReadLine() ?? "";
            // }

            // foreach (var w in words)
            // {
            //     if (w.Length >= longestWord.Length)
            //     {
            //         longestWord = w;
            //     }
            // }
            // Console.WriteLine("");
            // Console.WriteLine($"Out of all words {longestWord} was the longest with {longestWord.Length} characters!");

            Console.ReadLine(); // Don't comment out or console window will close immediately
        }
    }
}