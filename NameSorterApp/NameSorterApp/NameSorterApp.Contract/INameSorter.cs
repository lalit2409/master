namespace NameSorterApp.Contract
{
    public interface INameSorter
    {
        IEnumerable<string> SortNames(IEnumerable<string> unsortedNames);
    }
}
