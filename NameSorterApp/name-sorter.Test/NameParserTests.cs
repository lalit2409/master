using NameSorterApp.Contract;
using NameSorterApp.Implementation;

namespace name_sorter.Test
{
    [TestFixture]
    public class NameParserTests
    {
        [Test]
        public void ParseNames_WhenGivenUnsortedNames_ReturnsSameNames()
        {
            // Arrange
            string[] unsortedNames = new[]
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer"
            };
            INameParser nameParser = new NameParser();

            // Act
            var parsedNames = nameParser.ParseNames(unsortedNames).ToArray();

            // Assert
            Assert.AreEqual(unsortedNames, parsedNames);
        }
    }
}