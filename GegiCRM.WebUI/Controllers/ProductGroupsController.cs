using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Utils.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;

namespace GegiCRM.WebUI.Controllers
{

    [Authorize]
    [ActivityLogger]
    public class ProductGroupsController : Controller
    {
        private readonly CrmDbContext _context;

        public ProductGroupsController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: ProductGroups
        public async Task<IActionResult> Index()
        {
            var context = _context.ProductGroups.Include(p => p.AddedBy).Include(p => p.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: ProductGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductGroups == null)
            {
                return NotFound();
            }

            var productGroup = await _context.ProductGroups
                .Include(p => p.AddedBy)
                .Include(p => p.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productGroup == null)
            {
                return NotFound();
            }

            return View(productGroup);
        }

        // GET: ProductGroups/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: ProductGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupName,GroupDescription,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] ProductGroup productGroup)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(productGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", productGroup.AddedById);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", productGroup.ModifiedById);
                return View(productGroup);
            }

            //}
        }

        // GET: ProductGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductGroups == null)
            {
                return NotFound();
            }

            var productGroup = await _context.ProductGroups.FindAsync(id);
            if (productGroup == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", productGroup.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", productGroup.ModifiedById);
            return View(productGroup);
        }

        // POST: ProductGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupName,GroupDescription,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] ProductGroup productGroup)
        {
            if (id != productGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductGroupExists(productGroup.Id))
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
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", productGroup.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", productGroup.ModifiedById);
            return View(productGroup);
        }

        // GET: ProductGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductGroups == null)
            {
                return NotFound();
            }

            var productGroup = await _context.ProductGroups
                .Include(p => p.AddedBy)
                .Include(p => p.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productGroup == null)
            {
                return NotFound();
            }

            return View(productGroup);
        }

        // POST: ProductGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductGroups == null)
            {
                return Problem("Entity set 'Context.ProductGroups'  is null.");
            }
            var productGroup = await _context.ProductGroups.FindAsync(id);
            if (productGroup != null)
            {
                _context.ProductGroups.Remove(productGroup);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductGroupExists(int id)
        {
            return (_context.ProductGroups?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
