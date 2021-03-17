using InventoryManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace InventoryManager.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void AboutTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }




    }
}
