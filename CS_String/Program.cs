namespace CS_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Clear();
            Console.WriteLine("  Task 1");
            Console.Write(" Enter words : ");
            string? str = Console.ReadLine();
            string[] words = str.Split(' ');
            Array.Reverse(words);
            Console.Write(" Reversed words : ");
            foreach (var val in words)
                Console.Write($"{val} ");
            Console.ReadKey();

            //Task 2
            Console.Clear();
            Console.WriteLine("  Task 2");
            Console.Write(" Enter string with dots : ");
            str = Console.ReadLine();
            words = str.Split('.');
            if(words.Length > 1)Console.Write($" String between dots : {words[1]}");
            Console.ReadKey();

            //Task 3
            Console.Clear();
            Console.WriteLine("  Task 3");
            Console.Write(" Enter string : ");
            str = Console.ReadLine();
            Console.WriteLine($" String \"{str}\" is{(new string(str.Reverse().ToArray()) == str ? "" : " not")} a palindrom...");
            Console.ReadKey();

            //Task 4
            int lowerCount = 0;
            float lcPer;
            Console.Clear();
            Console.WriteLine("  Task 4");
            Console.Write(" Enter string : ");
            str = Console.ReadLine();
            foreach (char ch in str)
                if (Char.IsLower(ch)) ++lowerCount;
            lcPer = (float)Math.Round(100f / str.Length * lowerCount,2);
            Console.WriteLine($" In string \"{str}\" {lcPer}% a lowercase letters and {100 - lcPer }% uppercase letters...");
            Console.ReadKey();

            //Task 5
            Console.Clear();
            Console.WriteLine("  Task 5");
            Console.Write(" Enter text : ");
            str = Console.ReadLine();
            words = str.Split(new char[] { '.',' ',',',':','-'},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                words[i].TrimStart();
            Console.Write(" Index of word (1...): ");
            int ind = int.Parse(Console.ReadLine());
            Console.WriteLine($" The first letter in the word \"{words[ind - 1]}\"  is \"{words[ind - 1][0]}\"");
            Console.ReadKey();

            //Task 6
            Console.Clear();
            Console.WriteLine("  Task 6");
            Console.Write(" Words: ");
            foreach(var val in words)
                Console.Write($"{val} ");
            Console.WriteLine();
            for (int i = 0; i < words.Length; i++)
            {
                int len = words[i].Length;
                if (len > 5)
                   words[i] = words[i][..(len - 3)]+ "$$$";
            }
            Console.Write(" Result words: ");
            foreach (var val in words)
                Console.Write($"{val} ");
            Console.ReadKey();

            //Task 7
            Console.Clear();
            Console.WriteLine("  Task 7");
           

            Console.ReadKey();

            //Task 8
            string result = "";
            Console.Clear();
            Console.WriteLine("  Task 8");
            Console.Write(" Enter text : ");
            str = Console.ReadLine();
            words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                 result += words[i].Trim() + (i!= words.Length-1 ? '*' : ' ');
            Console.WriteLine($" Result text :\n {result}");
            Console.ReadKey();


        }


    }
}