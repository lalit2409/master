using NameSorterApp.Contract;
using NameSorterApp.Implementation;

namespace NameSorterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please provide input file.");
                return;
            }

            string inputFile = args[0];
            string outputFile = "sorted-names-list.txt";

            INameParser nameParser = new NameParser();
            INameSorter nameSorter = new NameSorter();
            NameSorterService app = new NameSorterService(nameParser, nameSorter);

            app.Run(inputFile, outputFile);
        }
    }
}