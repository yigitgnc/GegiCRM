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
    public class SegmentOransController : Controller
    {
        private readonly CrmDbContext _context;

        public SegmentOransController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: SegmentOrans
        public async Task<IActionResult> Index()
        {
            var context = _context.SegmentOrans.Include(s => s.AddedBy).Include(s => s.Currency).Include(s => s.ModifiedBy).Include(s => s.Segment);
            return View(await context.ToListAsync());
        }

        // GET: SegmentOrans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SegmentOrans == null)
            {
                return NotFound();
            }

            var segmentOran = await _context.SegmentOrans
                .Include(s => s.AddedBy)
                .Include(s => s.Currency)
                .Include(s => s.ModifiedBy)
                .Include(s => s.Segment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (segmentOran == null)
            {
                return NotFound();
            }

            return View(segmentOran);
        }

        // GET: SegmentOrans/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["CurrencyID"] = new SelectList(_context.Currencies, "Id", "Code");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description");
            return View();
        }

        // POST: SegmentOrans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StartPrice,EndPrice,Oran,CurrencyID,SegmentId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] SegmentOran segmentOran)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(segmentOran);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", segmentOran.AddedById);
                ViewData["CurrencyID"] = new SelectList(_context.Currencies, "Id", "Code", segmentOran.CurrencyID);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", segmentOran.ModifiedById);
                ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description", segmentOran.SegmentId);
                return View(segmentOran);
            }
           
            //}
         
        }

        // GET: SegmentOrans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SegmentOrans == null)
            {
                return NotFound();
            }

            var segmentOran = await _context.SegmentOrans.FindAsync(id);
            if (segmentOran == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", segmentOran.AddedById);
            ViewData["CurrencyID"] = new SelectList(_context.Currencies, "Id", "Code", segmentOran.CurrencyID);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", segmentOran.ModifiedById);
            ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description", segmentOran.SegmentId);
            return View(segmentOran);
        }

        // POST: SegmentOrans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StartPrice,EndPrice,Oran,CurrencyID,SegmentId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] SegmentOran segmentOran)
        {
            if (id != segmentOran.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            try
            {
                try
                {
                    _context.Update(segmentOran);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SegmentOranExists(segmentOran.Id))
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
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", segmentOran.AddedById);
                ViewData["CurrencyID"] = new SelectList(_context.Currencies, "Id", "Code", segmentOran.CurrencyID);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", segmentOran.ModifiedById);
                ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description", segmentOran.SegmentId);
                return View(segmentOran);
            }
               
            //}
          
        }

        // GET: SegmentOrans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SegmentOrans == null)
            {
                return NotFound();
            }

            var segmentOran = await _context.SegmentOrans
                .Include(s => s.AddedBy)
                .Include(s => s.Currency)
                .Include(s => s.ModifiedBy)
                .Include(s => s.Segment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (segmentOran == null)
            {
                return NotFound();
            }

            return View(segmentOran);
        }

        // POST: SegmentOrans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SegmentOrans == null)
            {
                return Problem("Entity set 'Context.SegmentOrans'  is null.");
            }
            var segmentOran = await _context.SegmentOrans.FindAsync(id);
            if (segmentOran != null)
            {
                _context.SegmentOrans.Remove(segmentOran);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SegmentOranExists(int id)
        {
          return (_context.SegmentOrans?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
