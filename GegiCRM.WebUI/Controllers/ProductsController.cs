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
    public class ProductsController : Controller
    {
        private readonly CrmDbContext _context;

        public ProductsController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var context = _context.Products.Include(p => p.AddedBy).Include(p => p.ModifiedBy).Include(p => p.PorductBrand).Include(p => p.ProductGroup);
            return View(await context.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.AddedBy)
                .Include(p => p.ModifiedBy)
                .Include(p => p.PorductBrand)
                .Include(p => p.ProductGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["PorductBrandId"] = new SelectList(_context.Brands, "Id", "Name");
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductName,ProductDescription,ProductGroupId,StockCount,PorductBrandId,KdvOrani,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Product product)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", product.AddedById);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", product.ModifiedById);
                ViewData["PorductBrandId"] = new SelectList(_context.Brands, "Id", "Name", product.PorductBrandId);
                ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", product.ProductGroupId);
                return View(product);
            }
              
            //}
          
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", product.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", product.ModifiedById);
            ViewData["PorductBrandId"] = new SelectList(_context.Brands, "Id", "Name", product.PorductBrandId);
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", product.ProductGroupId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductName,ProductDescription,ProductGroupId,StockCount,PorductBrandId,KdvOrani,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            try
            {
                //{
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
                //}
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", product.AddedById);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", product.ModifiedById);
                ViewData["PorductBrandId"] = new SelectList(_context.Brands, "Id", "Name", product.PorductBrandId);
                ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", product.ProductGroupId);
                return View(product);
            }
           
          
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.AddedBy)
                .Include(p => p.ModifiedBy)
                .Include(p => p.PorductBrand)
                .Include(p => p.ProductGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'Context.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
