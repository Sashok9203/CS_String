namespace CS_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Clear();
            Console.WriteLine("  Task 1");
           
            string[] words = getString(" Enter words : ").Split(' ');
            Array.Reverse(words);
            Console.Write(" Reversed words : ");
            foreach (var val in words)
                Console.Write($"{val} ");
            Console.ReadKey();

            //Task 2
            Console.Clear();
            Console.WriteLine("  Task 2");
            Console.Write(" Enter string with dots : ");
            words = getString(" Enter string with dots : ").Split('.');
            if (words.Length > 1)Console.Write($" String between dots : {words[1]}");
            Console.ReadKey();

            //Task 3
            Console.Clear();
            Console.WriteLine("  Task 3");
            string? str = getString(" Enter string : ");
            Console.WriteLine($" String \"{str}\" is{(new string(str.Reverse().ToArray()) == str ? "" : " not")} a palindrom...");
            Console.ReadKey();

            //Task 4
            int lowerCount = 0;
            float lcPer;
            Console.Clear();
            Console.WriteLine("  Task 4");
            str = getString(" Enter string : ");
            foreach (char ch in str)
                if (Char.IsLower(ch)) ++lowerCount;
            lcPer = (float)Math.Round(100f / str.Length * lowerCount,2);
            Console.WriteLine($" In string \"{str}\" {lcPer}% a lowercase letters and {100 - lcPer }% uppercase letters...");
            Console.ReadKey();

            //Task 5
            int ind = 0;
            Console.Clear();
            Console.WriteLine("  Task 5");
            words = getString(" Enter text : ").Split(new char[] { '.',' ',',',':','-'},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                words[i].TrimStart();
            Console.Write($" Index of word (1..{words.Length}): ");
            do
            {
              ind = int.Parse(Console.ReadLine() ?? "0");
            } while (ind < 1 || ind > words.Length);
            Console.WriteLine($" The first letter in the word \"{words[ind - 1]}\"  is \"{words[ind - 1][0]}\"");
            Console.ReadKey();

            //Task 6
            Console.Clear();
            Console.WriteLine("  Task 6");
            Console.Write(" Words: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{words[i]} ");
                int len = words[i].Length;
                if (len > 5)
                   words[i] = words[i][..(len - 3)] + "$$$";
            }
            Console.WriteLine();
            Console.Write(" Result words: ");
            foreach (var val in words)
                Console.Write($"{val} ");
            Console.ReadKey();

            //Task 7
            Console.Clear();
            Console.WriteLine("  Task 7");
           

            Console.ReadKey();

            //Task 8
            str = "";
            Console.Clear();
            Console.WriteLine("  Task 8");
            words = getString(" Enter text : ").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                str += words[i].Trim() + (i != words.Length-1 ? '*' : ' ');
            Console.WriteLine($" Result text :\n {str}");
            Console.ReadKey();
        }

        static string getString(string message)
        {
            string? str = "";
            Console.Write(message);
            do
            {
                str = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(str));
            return str;
        }
    }
}