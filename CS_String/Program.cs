namespace CS_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter words : ");
            string? str = Console.ReadLine();
            string[] words = StringRevers(ref str);
            Console.Write(" Reversed words : ");
            foreach (var val in words)
                Console.Write($"{val} ");
        }

        static string[] StringRevers( ref string str)
        {
            string[] words = str.Split(' ');
            Array.Reverse(words);
            return words;   
        }
    }
}