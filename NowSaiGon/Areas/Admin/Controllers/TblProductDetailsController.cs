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
    public class TblProductDetailsController : Controller
    {
        private readonly lvVietNamContext _context;

        public TblProductDetailsController(lvVietNamContext context)
        {
            _context = context;
        }

        // GET: Admin/TblProductDetails
        public async Task<IActionResult> Index()
        {
            var lvVietNamContext = _context.TblProductDetails.Include(t => t.Pro);
            return View(await lvVietNamContext.ToListAsync());
        }

        // GET: Admin/TblProductDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductDetail = await _context.TblProductDetails
                .Include(t => t.Pro)
                .FirstOrDefaultAsync(m => m.ProDeId == id);
            if (tblProductDetail == null)
            {
                return NotFound();
            }

            return View(tblProductDetail);
        }

        // GET: Admin/TblProductDetails/Create
        public IActionResult Create()
        {
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId");
            return View();
        }

        // POST: Admin/TblProductDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProDeId,ProId,Size,Quantity,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblProductDetail tblProductDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblProductDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId", tblProductDetail.ProId);
            return View(tblProductDetail);
        }

        // GET: Admin/TblProductDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductDetail = await _context.TblProductDetails.FindAsync(id);
            if (tblProductDetail == null)
            {
                return NotFound();
            }
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId", tblProductDetail.ProId);
            return View(tblProductDetail);
        }

        // POST: Admin/TblProductDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProDeId,ProId,Size,Quantity,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblProductDetail tblProductDetail)
        {
            if (id != tblProductDetail.ProDeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblProductDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblProductDetailExists(tblProductDetail.ProDeId))
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
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId", tblProductDetail.ProId);
            return View(tblProductDetail);
        }

        // GET: Admin/TblProductDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductDetail = await _context.TblProductDetails
                .Include(t => t.Pro)
                .FirstOrDefaultAsync(m => m.ProDeId == id);
            if (tblProductDetail == null)
            {
                return NotFound();
            }

            return View(tblProductDetail);
        }

        // POST: Admin/TblProductDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblProductDetail = await _context.TblProductDetails.FindAsync(id);
            _context.TblProductDetails.Remove(tblProductDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblProductDetailExists(int id)
        {
            return _context.TblProductDetails.Any(e => e.ProDeId == id);
        }
    }
}
