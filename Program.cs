namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = GetStringFromUser("Please enter a sentence and I will tell you how many characters the last word has.");
            int lastWord = GetLastWord(s);
            Console.WriteLine(lastWord);

        }

        static string GetStringFromUser(string s)
        {
            string userInput = "";

            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine().Trim();
            } while (userInput == "");
            return userInput;
        }

        static int GetLastWord(string s)
        {
            int counter = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    return counter;
                }
                else
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
