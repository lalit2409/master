using NameSorterApp.Contract;
using NameSorterApp.Implementation;

namespace name_sorter.Test
{
    [TestFixture]
    public class NameSorterTests
    {
        [Test]
        public void SortNames_WhenGivenUnsortedNames_ReturnsSortedNames()
        {
            // Arrange
            string[] unsortedNames = new[]
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer"
            };
            INameSorter nameSorter = new NameSorter();

            // Act
            var sortedNames = nameSorter.SortNames(unsortedNames).ToArray();

            // Assert
            Assert.AreEqual(new[]
            {
                "Adonis Julius Archer",
                "Vaughn Lewis",
                "Janet Parsons"
            }, sortedNames);
        }
    }
}
