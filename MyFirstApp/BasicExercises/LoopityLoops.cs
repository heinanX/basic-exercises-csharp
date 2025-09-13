namespace MyFirstApp.BasicExercises
{
    public static class LoopityLoops
    {

        public static void RunLoopityLoops()
        {
            //# ----------- 1. Write a program that logs 0 - 10

            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }


            //# ----------- 2. Write a program that logs numbers between two numbers.

            // Console.Write("Enter a number: ");
            // if (!int.TryParse(Console.ReadLine(), out int firstNumber))
            // {
            //     Console.WriteLine("Invalid number.");
            //     return;
            // }

            // Console.Write("Enter a second number: ");
            // if (!int.TryParse(Console.ReadLine(), out int secondNumber))
            // {
            //     Console.WriteLine("Invalid number.");
            //     return;
            // }

            // for (int i = firstNumber + 1; i < secondNumber; i++)
            // {
            //     Console.WriteLine(i);
            // }


            //# ----------- 3. Calculus Nonstop

            // bool play = true;
            // while (play)
            // {
            //     Console.Write("Enter a number: ");
            //     if (!int.TryParse(Console.ReadLine(), out int firstNumber)) return;

            //     Console.Write("Enter a second number: ");
            //     if (!int.TryParse(Console.ReadLine(), out int secondNumber)) return;

            //     int sum = firstNumber + secondNumber;

            //     Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");

            //     Console.Write("Do you want to continue (y/n)? ");
            //     string? answer = Console.ReadLine()?.ToLower();
            //     if (answer != "y" && answer != "yes")
            //     {
            //         play = false;
            //     }
            // }


            //# ----------- 4. Adding numbers 10 times

            // int sum = 0;
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.Write("Enter number: ");
            //     if (!int.TryParse(Console.ReadLine(), out int incomingNumber)) return;
            //     sum += incomingNumber;
            // }
            // Console.WriteLine(sum);


            //# ----------- 5. Subtraction

            // Console.Write("Enter number: ");
            // if (!int.TryParse(Console.ReadLine(), out int incomingNumber)) return;
            // for (int i = incomingNumber - 1; i > 0; i--)
            // {
            //     Console.WriteLine(i);
            // }


            //# ----------- 6. Crack the Secret Code or stay stuck

            // bool exitKey = true;

            // while (exitKey)
            // {
            //     Console.Write("Enter a number: ");
            //     if (!int.TryParse(Console.ReadLine(), out int incomingNumber)) return;

            //     if (incomingNumber < 10)
            //     {
            //         Console.WriteLine("Number is too low");
            //     }
            //     else if (incomingNumber > 10)
            //     {
            //         Console.WriteLine("Number is too high");
            //     }
            //     else
            //     {
            //         exitKey = false;
            //     }
            // }

            // Console.WriteLine("You cracked the code!");


            //# ----------- 7. Odd one out

            // #1.
            // for (int i = 100; i > 0; i--)
            // {
            //     if (int.IsOddInteger(i)) Console.WriteLine(i);
            // }

            //#2.
            // for (int i = 1; i < 100; i++)
            // {
            //     if (i % 2 != 0) Console.WriteLine(i);
            // }


            //# ----------- 8. Following the instructions

            // Console.Write("Enter a number: ");
            // if (!int.TryParse(Console.ReadLine(), out int incomingNumber)) return;
            // if (incomingNumber > 30)
            // {
            //     Console.WriteLine("Wrong number, pal!");
            // }
            // else
            // {
            //     for (int i = incomingNumber + 1; i <= 30; i++)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            //# ----------- 9. Entering Contact Info

            // bool allFieldsCompleted = true;
            // string name = "", address = "", zipCode = "", city = "";
            // while (allFieldsCompleted)
            // {
            //     if (name == "")
            //     {
            //         Console.Write("Name: ");
            //         name = Console.ReadLine() ?? "";
            //     }
            //     if (string.IsNullOrEmpty(address))
            //     {
            //         Console.Write("Address: ");
            //         address = Console.ReadLine() ?? "";
            //     }
            //     if (string.IsNullOrEmpty(zipCode))
            //     {
            //         Console.Write("Zip code: ");
            //         zipCode = Console.ReadLine() ?? "";
            //     }
            //     if (string.IsNullOrEmpty(city))
            //     {
            //         Console.Write("City: ");
            //         city = Console.ReadLine() ?? "";
            //     }

            //     if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(zipCode) && !string.IsNullOrEmpty(city))
            //     {
            //         Console.WriteLine("All fields completed!");
            //         allFieldsCompleted = false;
            //     }
            // }


            //# ----------- 10 Credentials and 
            // string username = "abc123";
            // string password = "password";
            // bool loggedOut = true;

            // while (loggedOut)
            // {
            //     Console.Write("Enter username: ");
            //     string inputUsername = Console.ReadLine() ?? "";
            //     Console.Write("Enter password: ");
            //     string inputPassword = Console.ReadLine() ?? "";
            //     if (username == inputUsername && password == inputPassword)
            //     {
            //         Console.WriteLine("You're logged in!");
            //         loggedOut = false;
            //     }
            //     else
            //     {
            //         if (username != inputUsername)
            //         {
            //             Console.WriteLine("Wrong Username!");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Wrong Password!");
            //         }
            //         Console.WriteLine("Do you want to try again (y/n)?");
            //         string answer = (Console.ReadLine() ?? "").ToLower();
            //         if (answer != "y" && answer != "yes") loggedOut = false;
            //     }
            // }

            Console.ReadLine(); // Don't comment out or console window will close immediately.
        }

        public static void RunLoopityLoopsHardMode()
        {
            //# 1. Division with the Magic No 17!
            // int result = 0;
            // for (int i = 1; i <= 1000; i++)
            // {
            //     if (i % 17 == 0) result++;
            // }
            // Console.Write(result);


            //# 2. What's the Average?

            int sum = 0;
            int count = 0;
            for (int i = 265; i <= 290; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            Console.WriteLine($"Average is {sum / count}");

            Console.ReadLine(); // Don't comment out or console window will close immediately.
        }
    }
}