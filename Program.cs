namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = GetStringFromUser("Please enter a sentence and I will tell you how many characters the last word has.");
            string lastWord = GetLastWord(s);
            Console.WriteLine(lastWord.Length);

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

        static string GetLastWord(string s)
        {
            string[] words = s.Split(' ');

            if (words.Length > 0)
            {
                return words[words.Length -1];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
