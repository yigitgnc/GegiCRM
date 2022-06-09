using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Concrete;

namespace GegiCRM.WebUI.Controllers
{
    public class BankInformationsController : Controller
    {
        private readonly Context _context;

        public BankInformationsController(Context context)
        {
            _context = context;
        }

        // GET: BankInformations
        public async Task<IActionResult> Index()
        {
            var context = _context.BankInformations.Include(b => b.AddedBy).Include(b => b.Bank).Include(b => b.Company).Include(b => b.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: BankInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BankInformations == null)
            {
                return NotFound();
            }

            var bankInformation = await _context.BankInformations
                .Include(b => b.AddedBy)
                .Include(b => b.Bank)
                .Include(b => b.Company)
                .Include(b => b.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankInformation == null)
            {
                return NotFound();
            }

            return View(bankInformation);
        }

        // GET: BankInformations/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName");
            ViewData["CompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: BankInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,BankId,Ttile,HesapNo,Sube,SubeNo,Iban,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] BankInformation bankInformation)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(bankInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", bankInformation.AddedById);
                ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName", bankInformation.BankId);
                ViewData["CompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName", bankInformation.CompanyId);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", bankInformation.ModifiedById);
                return View(bankInformation);
            }
              
            //}
          
        }

        // GET: BankInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BankInformations == null)
            {
                return NotFound();
            }

            var bankInformation = await _context.BankInformations.FindAsync(id);
            if (bankInformation == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", bankInformation.AddedById);
            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName", bankInformation.BankId);
            ViewData["CompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName", bankInformation.CompanyId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", bankInformation.ModifiedById);
            return View(bankInformation);
        }

        // POST: BankInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,BankId,Ttile,HesapNo,Sube,SubeNo,Iban,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] BankInformation bankInformation)
        {
            if (id != bankInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankInformationExists(bankInformation.Id))
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
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", bankInformation.AddedById);
            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "BankName", bankInformation.BankId);
            ViewData["CompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName", bankInformation.CompanyId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", bankInformation.ModifiedById);
            return View(bankInformation);
        }

        // GET: BankInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BankInformations == null)
            {
                return NotFound();
            }

            var bankInformation = await _context.BankInformations
                .Include(b => b.AddedBy)
                .Include(b => b.Bank)
                .Include(b => b.Company)
                .Include(b => b.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankInformation == null)
            {
                return NotFound();
            }

            return View(bankInformation);
        }

        // POST: BankInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BankInformations == null)
            {
                return Problem("Entity set 'Context.BankInformations'  is null.");
            }
            var bankInformation = await _context.BankInformations.FindAsync(id);
            if (bankInformation != null)
            {
                _context.BankInformations.Remove(bankInformation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankInformationExists(int id)
        {
          return (_context.BankInformations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
