using NameSorterApp.Contract;

namespace NameSorterApp.Implementation
{
    public class NameSorter : INameSorter
    {
        public IEnumerable<string> SortNames(IEnumerable<string> unsortedNames)
        {
            return unsortedNames.OrderBy(name => name, new LastNameFirstComparer());
        }
    }
}
