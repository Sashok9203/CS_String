namespace CS_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++)
            {
                Console.Clear();
                Console.WriteLine($"  Task {i}");
                switch (i)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    case 6: Task6(); break;
                    case 7: Task7(); break;
                    case 8: Task8(); break;
                }
                Console.ReadKey();
            }
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

        static void Task1()
        {
            string[] words = getString(" Enter words : ").Split(' ');
            Array.Reverse(words);
            Console.Write(" Reversed words : ");
            foreach (var val in words)
                Console.Write($"{val} ");
        }

        static void Task2()
        {
            string[] words = getString(" Enter string with dots : ").Split('.');
            if (words.Length > 2 && !string.IsNullOrWhiteSpace(words[1])) Console.Write($" String between dots : {words[1]}");
            else Console.Write(" The string does not contain a dots or there are no characters between the dots");
        }

        static void Task3()
        {
            string? str = getString(" Enter string : ");
            Console.WriteLine($" String \"{str}\" is{(new string(str.Reverse().ToArray()) == str ? "" : " not")} a palindrom...");
        }

        static void Task4()
        {
            int lowerCount = 0;
            float lcPer;
            string? str = getString(" Enter string : ");
            foreach (char ch in str)
                if (Char.IsLower(ch)) ++lowerCount;
            lcPer = (float)Math.Round(100f / str.Length * lowerCount, 2);
            Console.WriteLine($" In string \"{str}\" {lcPer}% a lowercase letters and {100 - lcPer}% uppercase letters...");
        }

        static void Task5()
        {
            int ind;
            string[] words = getString(" Enter text : ").Split(new char[] { '.', ' ', ',', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                words[i].TrimStart();
            Console.Write($" Index of word (1..{words.Length}): ");
            do
            {
                try { ind = int.Parse(Console.ReadLine() ?? "0"); }
                catch { ind = 0; }
            } while (ind < 1 || ind > words.Length);
            Console.WriteLine($" The first letter in the word \"{words[ind - 1]}\"  is \"{words[ind - 1][0]}\"");
        }

        static void Task6()
        {
            string[] words = getString(" Enter text : ").Split(new char[] { '.', ' ', ',', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Clear();
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
        }

        static void Task7()
        {
            string? str = "";
            string[] words = getString(" Enter text : ").Split(new char[] { '.', ' ', ',', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var val in words)
                for (int i = 0; i < val.Length - 1; i++)
                    if (val.Length > 1 && Char.IsUpper(val[i]) && Char.IsUpper(val[i + 1]))
                    {
                        str += val + " ";
                        break;
                    }
            if (!string.IsNullOrEmpty(str)) Console.WriteLine($" Abbreviations : {str}");
            else Console.WriteLine($" No abbreviations in text...");
        }

        static void Task8()
        {
            string? str = "";
            string []words = getString(" Enter text : ").Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                str += words[i].Trim() + (i != words.Length - 1 ? '*' : ' ');
            Console.Write($" Result text :\n {str}");
        }
    }
}