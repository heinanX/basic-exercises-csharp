namespace MyFirstApp.BasicExercises
{
    public static class StringyStrings
    {

        public static void RunStringyStrings()
        {
            //# ----------------------- 1. 3 strings into one
            // string combinedWords = "";
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.Write("Write a word: ");
            //     string word = Console.ReadLine() ?? "";
            //     word += " ";
            //     combinedWords += word;
            // }
            // Console.WriteLine(combinedWords);
            //# ----------------------- 1. 3 strings into one - with Array
            // string[] words = new string[3];
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.Write("Write a word: ");
            //     words[i] = Console.ReadLine() ?? "";

            // }
            //#1
            // string combinedWords = string.Concat(words[0], " ", words[1], " ", words[2]);
            //#2
            // string combinedWords = string.Concat($"{words[0]} {words[1]} {words[2]}");
            //#3
            // string combinedWords = string.Join(" ", words[0], words[1], words[2]);

            // Console.WriteLine(combinedWords);

            //# ----------------------- 2.  find character's index inside string
            // string word = "Hello world!";
            // string character = "w";
            // int characterIndex = word.IndexOf(character);

            // Console.WriteLine($"{character} holds positon {characterIndex}");

            //# ----------------------- 2.  String handlers
            // string b = "I am a C# hacker.";

            // int lastIndex = b.LastIndexOf('a');
            // Console.WriteLine($"last index of the letter 'a' is {lastIndex}");
            // Console.WriteLine(" ");

            // int positionOfC = b.IndexOf('c');
            // Console.WriteLine($"the letter 'C' has position {positionOfC} inside the string that is {b.Length} characters long.");
            // Console.WriteLine(" ");

            // string[] words = b.Split(' ');
            // foreach (string w in words) Console.WriteLine(w);
            // Console.WriteLine(" ");

            // string subString = "hacker";
            // int firstI = b.IndexOf("hacker");

            // string getWord = b.Substring(firstI, subString.Length);
            // Console.WriteLine(getWord);
            // Console.WriteLine(" ");

            // char[] chars = b.ToCharArray();

            // for (int i = 0; i < chars.Length; i++)
            // {
            //     if (i % 2 == 0)
            //         chars[i] = char.ToLower(chars[i]);
            //     else
            //         chars[i] = char.ToUpper(chars[i]);
            // }

            // string result = new string(chars);
            // Console.WriteLine(result);

            //# ----------------------- 4. Pascal casing
            // string name = "kurt andersson";
            // string[] nameArr = name.Split(' ');
            // string firstName = "K" + nameArr[0].Substring(1);
            // string lastName = "A" + nameArr[1].Substring(1);
            // name = string.Join(' ', firstName, lastName);

            // Console.WriteLine(name);

            //# ----------------------- 5. switch out blank space
            // string text = "This is a string you need to change";
            // string newText = text.Replace(' ', '*');
            // int no = 0;
            // foreach (char c in newText)
            // {
            //     if (c == '*') no++;
            // }
            // Console.WriteLine(newText);
            // Console.WriteLine($"the character '*' appears {no}");

            //# ----------------------- 6. Make an Array
            // string text = "one,two,three,four,five,six,seven";
            // string[] numbers = text.Split(',');
            // foreach (var n in numbers)
            // {
            //     Console.WriteLine(n);
            // }

            //# ----------------------- 7. Validate an email
            Console.WriteLine("Enter mail: ");
            string email = Console.ReadLine() ?? "";
            if (string.IsNullOrEmpty(email)) Console.WriteLine("Unvalid entry");

            bool validateEmail = email.Contains('@');
            int periodIndex = email.LastIndexOf('.');
            string validateDomain = email.Substring(periodIndex);

            if (validateEmail && validateDomain.Length > 1 && validateDomain.Length < 4)
            {
                Console.WriteLine("Email has been validated");
            }
            else
            {
                string msg;
                if (!validateEmail)
                {
                    msg = "Email is missing '@'.";
                }
                else
                {
                    msg = "Email is missing a valid domain.";
                }
                Console.WriteLine($"Unable to validate email. {msg}");
            }

            Console.ReadLine();
        }

        public static void RunStringyStringsHardMode()
        {
            //# ----------------------- 1. Sorting numbers from a string
            // string numbers = "231596874";
            // char[] stringNumberArr = numbers.ToCharArray();

            // int[] numberArr = new int[stringNumberArr.Length];

            // for (int i = 0; i < stringNumberArr.Length; i++)
            // {
            //     int.TryParse(stringNumberArr[i].ToString(), out int num);
            //     numberArr[i] = num;
            // }
            // Array.Sort(numberArr);


            // foreach (var n in numberArr)
            // {
            //     Console.WriteLine(n);
            // }


            //# ----------------------- 2. Word Count
            // Console.WriteLine("Enter a random short text: ");
            // string randomTxt = Console.ReadLine() ?? "";
            // string[] stringArr = randomTxt.Split(' ');
            // Console.WriteLine($"Your sentence contains {stringArr.Length} words.");

            //Pro tip: randomTxt.Split(' ').Length would've been a faster way with less steps and conversion.


            //# ----------------------- 3. Are you a Palladdin?? Nah, just a Palindrome.

            Console.WriteLine("Enter a word or a sentence to see if it's a palindrome): ");
            string text = Console.ReadLine() ?? "";
            string strippedTxt = text.Replace(" ", "").ToLower();

            int lastIndex = strippedTxt.Length;

            for (int i = 0; i < strippedTxt.Length; i++)
            {
                if (strippedTxt[i] == strippedTxt[lastIndex - 1])
                {
                    lastIndex--;
                }
                else
                {
                    Console.WriteLine($"{text} is not a palindrome.");
                    return;
                }
            }
            Console.WriteLine($"{text} is a palindrome.");

            Console.ReadLine();
        }
    }
}
