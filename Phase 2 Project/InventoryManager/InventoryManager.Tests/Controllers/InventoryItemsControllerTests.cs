using InventoryManager.Data;
using InventoryManager.Models;
using InventoryManager.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace InventoryManager.Tests
{
    public class InventoryManagerControllerTests
    {
        [Fact]
        public void IndexTest()
        {
            // Arrange
            InventoryItemsController controller = GetTestController();

            // Act
            var result = controller.Index("item", "category");

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void DeleteTest()
        {
            // Arrange
            InventoryItemsController controller = GetTestController();

            // Act
            var result = controller.Delete(1);

            // Assert
            Assert.NotNull(result);
        }

        private InventoryItemsController GetTestController()
        {
            InventoryItemsController controller;

            var options = new DbContextOptionsBuilder<InventoryManagerContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using (var context = new InventoryManagerContext(options))
            {
                context.InventoryItem.Add(new InventoryItem());
                context.SaveChanges();
                controller = new InventoryItemsController(context);
            }

            return controller;
        }
    }
}
