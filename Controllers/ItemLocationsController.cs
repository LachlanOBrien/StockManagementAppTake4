using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockManagementApp.Areas.Identity.Data;
using StockManagementApp.Models;

namespace StockManagementApp.Controllers
{
    public class ItemLocationsController : Controller
    {
        private readonly StockManagementAppContext _context;

        public ItemLocationsController(StockManagementAppContext context)
        {
            _context = context;
        }

        // GET: ItemLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemLocation.ToListAsync());
        }

        // GET: ItemLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemLocation = await _context.ItemLocation
                .FirstOrDefaultAsync(m => m.ItemLocationID == id);
            if (itemLocation == null)
            {
                return NotFound();
            }

            return View(itemLocation);
        }

        // GET: ItemLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemLocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemLocationID,ItemID,SupplierID,LocationID,Quantity")] ItemLocation itemLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemLocation);
        }

        // GET: ItemLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemLocation = await _context.ItemLocation.FindAsync(id);
            if (itemLocation == null)
            {
                return NotFound();
            }
            return View(itemLocation);
        }

        // POST: ItemLocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemLocationID,ItemID,SupplierID,LocationID,Quantity")] ItemLocation itemLocation)
        {
            if (id != itemLocation.ItemLocationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemLocationExists(itemLocation.ItemLocationID))
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
            return View(itemLocation);
        }

        // GET: ItemLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemLocation = await _context.ItemLocation
                .FirstOrDefaultAsync(m => m.ItemLocationID == id);
            if (itemLocation == null)
            {
                return NotFound();
            }

            return View(itemLocation);
        }

        // POST: ItemLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemLocation = await _context.ItemLocation.FindAsync(id);
            if (itemLocation != null)
            {
                _context.ItemLocation.Remove(itemLocation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemLocationExists(int id)
        {
            return _context.ItemLocation.Any(e => e.ItemLocationID == id);
        }
    }
}
