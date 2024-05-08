using NameSorterApp.Contract;

namespace NameSorterApp.Implementation
{
    public class NameParser : INameParser
    {
        public IEnumerable<string> ParseNames(string[] unsortedNames)
        {
            foreach (string name in unsortedNames)
            {
                yield return name;
            }
        }
    }
}
