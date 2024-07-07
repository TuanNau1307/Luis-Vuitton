using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NowSaiGon.Models;

namespace NowSaiGon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TblProductsController : Controller
    {
        private readonly lvVietNamContext _context;

        public TblProductsController(lvVietNamContext context)
        {
            _context = context;
        }

        // GET: Admin/TblProducts
        public async Task<IActionResult> Index()
        {
            var lvVietNamContext = _context.TblProducts.Include(t => t.IdNavigation);
            return View(await lvVietNamContext.ToListAsync());
        }

        // GET: Admin/TblProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProduct = await _context.TblProducts
                .Include(t => t.IdNavigation)
                .FirstOrDefaultAsync(m => m.ProId == id);
            if (tblProduct == null)
            {
                return NotFound();
            }

            return View(tblProduct);
        }

        // GET: Admin/TblProducts/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.TblCategories, "Id", "Id");
            return View();
        }

        // POST: Admin/TblProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProId,ProName,Id,Decription,Detail,Avatar,Price,PriceSale,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblProduct tblProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.TblCategories, "Id", "Id", tblProduct.Id);
            return View(tblProduct);
        }

        // GET: Admin/TblProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProduct = await _context.TblProducts.FindAsync(id);
            if (tblProduct == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.TblCategories, "Id", "Id", tblProduct.Id);
            return View(tblProduct);
        }

        // POST: Admin/TblProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProId,ProName,Id,Decription,Detail,Avatar,Price,PriceSale,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblProduct tblProduct)
        {
            if (id != tblProduct.ProId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblProductExists(tblProduct.ProId))
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
            ViewData["Id"] = new SelectList(_context.TblCategories, "Id", "Id", tblProduct.Id);
            return View(tblProduct);
        }

        // GET: Admin/TblProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProduct = await _context.TblProducts
                .Include(t => t.IdNavigation)
                .FirstOrDefaultAsync(m => m.ProId == id);
            if (tblProduct == null)
            {
                return NotFound();
            }

            return View(tblProduct);
        }

        // POST: Admin/TblProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblProduct = await _context.TblProducts.FindAsync(id);
            _context.TblProducts.Remove(tblProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblProductExists(int id)
        {
            return _context.TblProducts.Any(e => e.ProId == id);
        }
    }
}
