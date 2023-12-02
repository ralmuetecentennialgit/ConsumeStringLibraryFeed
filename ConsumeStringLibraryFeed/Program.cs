using UtilityLibraries;

namespace ConsumeStringLibraryFeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hello = "Hello, World!";
            var newhello = "hello World!";

            // Function using the StringLibrary
            void CheckAndPrintStartsWithUpper(string str)
            {
                if (StringLibrary.StartsWithUpper(str))
                {
                    Console.WriteLine($"{str} starts with an uppercase string");
                }
                else
                {
                    Console.WriteLine($"{str} starts with a lowercase string");
                }
            }

            // Check the strings
            CheckAndPrintStartsWithUpper(hello);
            CheckAndPrintStartsWithUpper(newhello);

        }
    }
}