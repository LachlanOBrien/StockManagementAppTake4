using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockManagementApp.Areas.Identity.Data;
using StockManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StockManagementApp.Models.Order;

namespace StockManagementApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly StockManagementAppContext _context;

        public OrdersController(StockManagementAppContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Order.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            //ViewData["ItemStatus"] = new SelectList(Enum.GetValues(typeof(ItemStatus)));
            //ViewData["ItemStatus"] = new SelectList(new List<SelectListItem>
            //{
            //    new SelectListItem { Value = "Pending", Text = "Pending" },
            //    new SelectListItem { Value = "Shipped", Text = "Shipped" },
            //    new SelectListItem { Value = "Delivered", Text = "Delivered" },
            //    new SelectListItem { Value = "Cancelled", Text = "Cancelled" }
            //}, "Value", "Text");
            var statuses = Enum.GetValues(typeof(ItemStatus))
                            .Cast<ItemStatus>()
                            .Select(s => new SelectListItem { Value = s.ToString(), Text = s.ToString() })
                            .ToList();
            ViewBag.StatusList = statuses;
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,ItemID,LocationID,SupplierID,OrderName,QuantityOrdered,EstimatedTimeOfArrival,Status")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var statuses = Enum.GetValues(typeof(ItemStatus))
                             .Cast<ItemStatus>()
                             .Select(s => new SelectListItem { Value = s.ToString(), Text = s.ToString() })
                             .ToList();
            ViewBag.StatusList = statuses;
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            var statuses = Enum.GetValues(typeof(ItemStatus))
                             .Cast<ItemStatus>()
                             .Select(s => new SelectListItem { Value = s.ToString(), Text = s.ToString() })
                             .ToList();
            ViewBag.StatusList = statuses;
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,ItemID,LocationID,SupplierID,OrderName,QuantityOrdered,EstimatedTimeOfArrival,Status")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
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
            var statuses = Enum.GetValues(typeof(ItemStatus))
                 .Cast<ItemStatus>()
                 .Select(s => new SelectListItem { Value = s.ToString(), Text = s.ToString() })
                 .ToList();
            ViewBag.StatusList = statuses;
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order != null)
            {
                _context.Order.Remove(order);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderID == id);
        }
    }
}
