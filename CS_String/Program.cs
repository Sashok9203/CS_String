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
            //char[] reverse = str.ToCharArray();
            //Array.Reverse(reverse);
            Console.WriteLine($" String \"{str}\" is{(new string(str.Reverse().ToArray()) == str ? "" : " not")} a palindrom...");
            Console.ReadKey();

        }


    }
}