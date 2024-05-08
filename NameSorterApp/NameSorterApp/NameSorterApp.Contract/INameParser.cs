
namespace NameSorterApp.Contract
{
    public interface INameParser
    {
        IEnumerable<string> ParseNames(string[] unsortedNames);
    }
}
