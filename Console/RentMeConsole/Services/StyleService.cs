using System;
using System.Text;

namespace RentMeConsole.Services
{
    public static class StyleService
    {
        public static string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        public static string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
        public static string MAGENTA = Console.IsOutputRedirected ? "" : "\x1b[95m";
        public static string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
        public static string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";

        public static void AppTitle()
        {
            string appTitle = "rentme console";
            int length = appTitle.Length;
            string hr = new string('=', length);
            Console.WriteLine($"\n{hr}\n{CYAN}{appTitle.ToUpper()}{NORMAL}\n{hr}");
        }

        public static void AppInfo()
        {
            Console.WriteLine("This console application facilitates creation of rentme data.");
            Console.WriteLine("");
            Console.WriteLine(Left("Powered by", 40, '.') + Right(".NET Framework 4.8", 40, '.'));
            Console.WriteLine(Left("App name", 40, '.') + Right("RentMeConsole", 40, '.'));
            Console.WriteLine(Left("App version", 40, '.') + Right("1.0", 40, '.'));
            Console.WriteLine(Left("Last app update", 40, '.') + Right("March 26, 2024", 40, '.'));
            Console.WriteLine("");
        }

        public static string Right(string text, int length, char paddingChar = ' ')
        {
            int paddingLength = Math.Max(length - text.Length, 0);
            return $"{new string(paddingChar, paddingLength)}{text}";
        }

        public static string Left(string text, int length, char paddingChar = ' ')
        {
            int paddingLength = Math.Max(length - text.Length, 0);
            return $"{text}{new string(paddingChar, paddingLength)}";
        }

        public static string MultiLine(string text, int length)
        {
            StringBuilder result = new StringBuilder();
            int currentLength = 0;

            text.ToString().Trim().Replace(Environment.NewLine, " ");
            text.Replace("  ", " ");

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (currentLength + word.Length + 1 <= length)
                {
                    result.Append(word + " ");
                    currentLength += word.Length + 1;
                }
                else
                {
                    result.AppendLine();
                    result.Append(word + " ");
                    currentLength = word.Length + 1;
                }
            }

            return result.ToString();
        }

        public static string Center(string text, int length, char paddingChar = ' ')
        {
            int paddingLength = Math.Max(length - text.Length, 0);
            int leftPaddingLength = paddingLength / 2;
            int rightPaddingLength = paddingLength - leftPaddingLength;

            string leftPadding = new string(paddingChar, leftPaddingLength);
            string rightPadding = new string(paddingChar, rightPaddingLength);

            return $"{leftPadding}{text}{rightPadding}";
        }

        public static string HeadingFormat(string text)
        {
            int length = text.Length;
            string hr = new string('=', length);
            return $"\n{hr}\n{text.ToUpper()}\n{hr}";
        }

        public static string H2Format(string text)
        {
            int length = text.Length;
            string hr = new string('=', length);
            return $"\n{CapitalizeWords(text)}\n{hr}";
        }

        public static string H3Format(string text)
        {
            int length = text.Length;
            string hr = new string('-', length);
            return $"\n{CapitalizeWords(text)}\n{hr}";
        }

        public static string PromptFormat(string text)
        {
            return $"{CYAN}{text}{NORMAL}:";
        }

        public static string WarningFormat(string text)
        {
            return $"{MAGENTA}{MultiLine(text, 80)}{NORMAL}\n";
        }

        public static string SuccessFormat(string text)
        {
            return $"{GREEN}{MultiLine(text, 80)}{NORMAL}\n";
        }

        public static string CapitalizeWords(string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
        }

        public static bool IsAlphaNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
