using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ExampleDtoTests
    {
        [TestMethod]
        public void ExampleDto_Constructor()
        {
            // Act
            var result = new ExampleDto(0);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ExampleDto));
        }
    }
}