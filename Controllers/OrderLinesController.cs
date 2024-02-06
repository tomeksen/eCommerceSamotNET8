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
    public class OrderLinesController : ControllerBase
    {
        private readonly DataContext _context;

        public OrderLinesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<OrderLines>>> getOrderLines()
        {
            var orderLines = await _context.orderLines.ToListAsync();
            return Ok(orderLines);
        }
        /*
        // GET: OrderLines
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.orderLines.Include(o => o.Order).Include(o => o.Product);
            return View(await dataContext.ToListAsync());
        }

        // GET: OrderLines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderLines = await _context.orderLines
                .Include(o => o.Order)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.LineId == id);
            if (orderLines == null)
            {
                return NotFound();
            }

            return View(orderLines);
        }

        // GET: OrderLines/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.orders, "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_context.products, "ProductId", "Name");
            return View();
        }

        // POST: OrderLines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LineId,OrderId,ProductId,Quantity,Status")] OrderLines orderLines)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderLines);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.orders, "OrderId", "OrderId", orderLines.OrderId);
            ViewData["ProductId"] = new SelectList(_context.products, "ProductId", "Name", orderLines.ProductId);
            return View(orderLines);
        }

        // GET: OrderLines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderLines = await _context.orderLines.FindAsync(id);
            if (orderLines == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.orders, "OrderId", "OrderId", orderLines.OrderId);
            ViewData["ProductId"] = new SelectList(_context.products, "ProductId", "Name", orderLines.ProductId);
            return View(orderLines);
        }

        // POST: OrderLines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LineId,OrderId,ProductId,Quantity,Status")] OrderLines orderLines)
        {
            if (id != orderLines.LineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderLines);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderLinesExists(orderLines.LineId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.orders, "OrderId", "OrderId", orderLines.OrderId);
            ViewData["ProductId"] = new SelectList(_context.products, "ProductId", "Name", orderLines.ProductId);
            return View(orderLines);
        }

        // GET: OrderLines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderLines = await _context.orderLines
                .Include(o => o.Order)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.LineId == id);
            if (orderLines == null)
            {
                return NotFound();
            }

            return View(orderLines);
        }

        // POST: OrderLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderLines = await _context.orderLines.FindAsync(id);
            if (orderLines != null)
            {
                _context.orderLines.Remove(orderLines);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderLinesExists(int id)
        {
            return _context.orderLines.Any(e => e.LineId == id);
        }*/

    }
}
