using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryManager.Data;
using InventoryManager.Models;

namespace InventoryManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly InventoryManagerContext _context;

        public ValuesController(InventoryManagerContext context)
        {
            _context = context;
        }

        // GET: api/Values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryItem()
        {
            return await _context.InventoryItem.ToListAsync();
        }

        // GET: api/Values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryItem>> GetInventoryItem(int id)
        {
            var inventoryItem = await _context.InventoryItem.FindAsync(id);

            if (inventoryItem == null)
            {
                return NotFound();
            }

            return inventoryItem;
        }
    }
}
