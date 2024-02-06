using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerceSamotNet8.Data;
using eCommerceSamotNet8.Entities;

namespace eCommerceSamotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext _context;

        public OrdersController(DataContext context)
        {
            _context = context;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<List<Orders>>> getOrders()
        {
            var orders = await _context.orders.ToListAsync();
            return Ok(orders);
        }

        #endregion

        #region Post

        [HttpPost]
        public async Task<ActionResult<Orders>> CreateOrder(int OrderId, int UserId, int SellerId, int DeliveryAddressId, string Contact, DateTime DateTime, string Status)
        {
            Orders orders = new Orders
            {
                OrderId = OrderId,
                UserId = UserId,
                SellerId = SellerId,
                DeliveryAddressId = DeliveryAddressId,
                Contact = Contact,
                DateTime = DateTime,
                Status = Status
            };

            _context.orders.Add(orders);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(getOrders), new { id = orders.OrderId }, orders);
        }

        #endregion

        #region put function

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, Orders order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        #endregion

        #region Delete function

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        #endregion

        #region functions

        private bool OrderExists(int id)
        {
            return _context.orders.Any(e => e.OrderId == id);
        }

        #endregion
    }
}
