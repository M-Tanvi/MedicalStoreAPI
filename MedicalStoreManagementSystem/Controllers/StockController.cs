using MedicalStoreManagementSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
    private readonly MedicalContext context;

    public StockController(MedicalContext context)
    {
        this.context = context;
    }
    // POST: StockController/Edit/5
    [HttpPut("{id:int}")]
        public async Task<ActionResult> ManageStock(int id,Stock stock)
        {
            
            
            
            var stockval = await context.Stock.FirstOrDefaultAsync(x => x.StockID == id);
            if (stockval == null)
            {
                return NotFound();
            }
            stockval.Quantity = stock.Quantity;
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
