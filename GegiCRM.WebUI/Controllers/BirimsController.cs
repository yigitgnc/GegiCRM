using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using GegiCRM.BLL.Generic;

namespace GegiCRM.WebUI.Controllers
{
    public class BirimsController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly GenericManager<Birim> _birimGenericManager;
        public BirimsController(Context context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _birimGenericManager = new GenericManager<Birim>(_userManager,new EfBirimRepository());
        }

        // GET: Birims
        public async Task<IActionResult> Index()
        {
            var context = _context.Birims.Include(b => b.AddedBy).Include(b => b.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: Birims/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Birims == null)
            {
                return NotFound();
            }

            var birim = await _context.Birims
                .Include(b => b.AddedBy)
                .Include(b => b.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (birim == null)
            {
                return NotFound();
            }

            return View(birim);
        }

        // GET: Birims/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: Birims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Short,IsDeleted,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById")] Birim birim)
        {
            birim.AddedBy = null;
            var errors = string.Join("; ", ModelState.Values
                 .SelectMany(x => x.Errors)
                 .Select(x => x.ErrorMessage));
            try
            {
                _birimGenericManager.Create(birim);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", birim.AddedById);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", birim.ModifiedById);
                return View(birim);
            }
        }

        // GET: Birims/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Birims == null)
            {
                return NotFound();
            }

            var birim = await _context.Birims.FindAsync(id);
            if (birim == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", birim.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", birim.ModifiedById);
            return View(birim);
        }

        // POST: Birims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Short,IsDeleted,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById")] Birim birim)
        {
            if (id != birim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(birim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BirimExists(birim.Id))
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
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", birim.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", birim.ModifiedById);
            return View(birim);
        }

        // GET: Birims/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Birims == null)
            {
                return NotFound();
            }

            var birim = await _context.Birims
                .Include(b => b.AddedBy)
                .Include(b => b.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (birim == null)
            {
                return NotFound();
            }

            return View(birim);
        }

        // POST: Birims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Birims == null)
            {
                return Problem("Entity set 'Context.Birims'  is null.");
            }
            var birim = await _context.Birims.FindAsync(id);
            if (birim != null)
            {
                _context.Birims.Remove(birim);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BirimExists(int id)
        {
            return (_context.Birims?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
