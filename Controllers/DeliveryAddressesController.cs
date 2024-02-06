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
    public class DeliveryAddressesController : ControllerBase
    {
        private readonly DataContext _context;

        public DeliveryAddressesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<DeliveryAddress>>> getDeliveryAddresses()
        {
            var deliveryAddresses = await _context.deliveryAddress.ToListAsync();
            return Ok(deliveryAddresses);
        }
        /*
        // GET: DeliveryAddresses
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.deliveryAddress.ToListAsync());
        }

        // GET: DeliveryAddresses/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryAddress = await _context.deliveryAddress
                .FirstOrDefaultAsync(m => m.DeliveryId == id);
            if (deliveryAddress == null)
            {
                return NotFound();
            }

            return View(deliveryAddress);
        }

        // GET: DeliveryAddresses/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeliveryId,AddLine1,AddLine2,City,State,ZipCode")] DeliveryAddress deliveryAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryAddress);
        }

        // GET: DeliveryAddresses/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryAddress = await _context.deliveryAddress.FindAsync(id);
            if (deliveryAddress == null)
            {
                return NotFound();
            }
            return View(deliveryAddress);
        }

        // POST: DeliveryAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeliveryId,AddLine1,AddLine2,City,State,ZipCode")] DeliveryAddress deliveryAddress)
        {
            if (id != deliveryAddress.DeliveryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryAddressExists(deliveryAddress.DeliveryId))
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
            return View(deliveryAddress);
        }

        // GET: DeliveryAddresses/Delete/5
        [HttpGet]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryAddress = await _context.deliveryAddress
                .FirstOrDefaultAsync(m => m.DeliveryId == id);
            if (deliveryAddress == null)
            {
                return NotFound();
            }

            return View(deliveryAddress);
        }

        // POST: DeliveryAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryAddress = await _context.deliveryAddress.FindAsync(id);
            if (deliveryAddress != null)
            {
                _context.deliveryAddress.Remove(deliveryAddress);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryAddressExists(int id)
        {
            return _context.deliveryAddress.Any(e => e.DeliveryId == id);
        }*/
    }
}
