using static MyFirstApp.BasicExercises.RecurringMethods;
using static MyFirstApp.BasicExercises2.PracticingMethods;

// DateyDates.RunDateyDates();


// ----------------------- Basic Exercises 2

// # 1.
// Console.Write(PrintMessage());


// # 2.
// Console.Write("Enter a decimal between 1 and 0: ");
// if (!double.TryParse(Console.ReadLine(), out double decimalInput))
// {
//     return;
// }
// double percentage = ToPercentage(decimalInput);
// Console.WriteLine($"Percenteage is {percentage} %");


//# 3.
// Console.Write("Enter a word to combine: ");
// string word1 = Console.ReadLine() ?? "";
// Console.Write("Enter the second word to combine: ");
// string word2 = Console.ReadLine() ?? "";
// RecurringMethods.Log($"{CombineStrings(word1, word2)}");


//# 4.
// Console.WriteLine(AddTaxes(200, 25));

// Console.WriteLine(SalesTax(200));


//# 5.
// Console.Write("Enter your age: ");
// if (!int.TryParse(Console.ReadLine(), out int age)) return;

// bool isEighteen = ValidateAge(age);
// if (isEighteen)
// {
//     Console.WriteLine("Congrats you're over 18!");
// }
// else
// {
//     Console.WriteLine("Sorry! You're not of legal age.");
// }


//# 6.
// Console.WriteLine(CheckMaxValue(8, 3, 4));


//# 7.
// string[] arr = ["Naruto", "Sasuke", "Tanjiro", "Nezuko", "Inosuke"];
// Console.WriteLine(FindLongestWord(arr));


//# 8.
// int[] numArr = [1, 2, 3, 4];
// int number = Multiply(numArr);
// Console.WriteLine(number);


//# 9. Is it a Vocal?
// IsLetterAVocal("Hello");


//# 10.
// string text = "this is fun";
// Translate(ref text);
// Console.WriteLine(text);


//# 11.
// int num = 10;
// ReferenceOut(ref num, out int num2);
// Console.WriteLine(num);
// Console.WriteLine(num2);

// generate assets for build and debug