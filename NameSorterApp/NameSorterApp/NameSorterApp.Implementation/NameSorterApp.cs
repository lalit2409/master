using NameSorterApp.Contract;

namespace NameSorterApp.Implementation
{
    public class NameSorterService
    {
        private readonly INameParser _nameParser;
        private readonly INameSorter _nameSorter;

        public NameSorterService(INameParser nameParser, INameSorter nameSorter)
        {
            _nameParser = nameParser;
            _nameSorter = nameSorter;
        }

        public void Run(string inputFile, string outputFile)
        {
            string[] unsortedNames = File.ReadAllLines(inputFile);
            IEnumerable<string> parsedNames = _nameParser.ParseNames(unsortedNames);
            IEnumerable<string> sortedNames = _nameSorter.SortNames(parsedNames);

            foreach (string name in sortedNames)
            {
                Console.WriteLine(name);
            }

            File.WriteAllLines(outputFile, sortedNames);
        }
    }
}
