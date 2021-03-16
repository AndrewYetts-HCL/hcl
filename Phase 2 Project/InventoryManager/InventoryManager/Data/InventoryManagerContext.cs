using InventoryManager.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Data
{
    public class InventoryManagerContext : DbContext
    {
        public InventoryManagerContext(DbContextOptions<InventoryManagerContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryItem> InventoryItem { get; set; }
    }
}