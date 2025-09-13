using System.Runtime.CompilerServices;
using static MyFirstApp.BasicExercises.RecurringMethods;
namespace MyFirstApp.BasicExercises2
{
    public static class PracticingMethods
    {
        //# 1.
        public static string PrintMessage()
        {
            return "Hello World!";
        }

        //# 2.
        public static double ToPercentage(double decimalInput)
        {
            return decimalInput * 100;

        }

        //# 3.
        public static string CombineStrings(string msg1, string msg2)
        {
            return msg1 + msg2;
        }

        //# 4.

        public static double AddTaxes(double sum, double tax)
        {
            return sum + (sum * (tax / 100));
        }

        //# 5.
        public static double SalesTax(int sum)
        {
            double tax = sum * 0.25;
            return tax;
        }

        //# 6.
        public static bool ValidateAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // # 7. ----------------------------------------------------------------

        public static int MaxValue2(int num, int num2)
        {
            int largestnum = num > num2 ? num : num2;
            return largestnum;
        }
        public static int MaxValue3(int num, int num2, int num3)
        {
            int largestnum = num;
            if (num2 > num3 && num2 > num)
            {
                largestnum = num2;
            }
            else if (num3 > num && num3 > num2)
            {
                largestnum = num3;
            }
            return largestnum;
        }
        public static int CheckMaxValue(int num, int num2, int num3)
        {
            int sum = 0;
            if (num == 0)
            {
                sum = MaxValue2(num2, num3);
            }
            else if (num2 == 0)
            {
                sum = MaxValue2(num, num3);
            }
            else if (num3 == 0)
            {
                sum = MaxValue2(num, num2);
            }
            else
            {
                sum = MaxValue3(num, num2, num3);
            }
            return sum;
        }

        // ----------------------------------------------------------------

        //# 8.
        public static string FindLongestWord(string[] words)
        {
            string longestword = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= longestword.Length)
                {
                    longestword = words[i];
                }
            }
            return longestword;
        }

        //# 9.

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var a in numbers)
            {
                sum += a;
            }
            return sum;
        }
        public static int Multiply(int[] numbers)
        {
            int sum = 1;
            foreach (var n in numbers)
            {
                sum *= n;
            }
            return sum;
        }

        //# 9.
        public static bool IsLetterAVocal(string letter)
        {
            bool isVocal = false;
            string[] vocals = ["a", "i", "e", "u", "o"];
            if (vocals.Contains(letter))
            {
                isVocal = true;
            }
            return isVocal;
        }

        //# 10.
        public static void Translate(ref string text)
        {
            char[] vocals = ['a', 'i', 'e', 'u', 'o'];
            string[] splitText = text.Split();

            for (int i = 0; i < splitText.Length; i++)
            {
                splitText[i] = string.Concat(splitText[i].Select(c =>
                        vocals.Contains(c) ? c.ToString() : $"{c}o{c}"
                    ));
            }
            text = string.Join(" ", splitText);
        }

        public static void ReferenceOut(ref int num, out int num2)
        {
            num = +5;
            num2 = 50;
        }



    }

}