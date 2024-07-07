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
    public class TblProductImagesController : Controller
    {
        private readonly lvVietNamContext _context;

        public TblProductImagesController(lvVietNamContext context)
        {
            _context = context;
        }

        // GET: Admin/TblProductImages
        public async Task<IActionResult> Index()
        {
            var lvVietNamContext = _context.TblProductImages.Include(t => t.Pro);
            return View(await lvVietNamContext.ToListAsync());
        }

        // GET: Admin/TblProductImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductImage = await _context.TblProductImages
                .Include(t => t.Pro)
                .FirstOrDefaultAsync(m => m.ImgId == id);
            if (tblProductImage == null)
            {
                return NotFound();
            }

            return View(tblProductImage);
        }

        // GET: Admin/TblProductImages/Create
        public IActionResult Create()
        {
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId");
            return View();
        }

        // POST: Admin/TblProductImages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImgId,ProId,Image,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblProductImage tblProductImage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblProductImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId", tblProductImage.ProId);
            return View(tblProductImage);
        }

        // GET: Admin/TblProductImages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductImage = await _context.TblProductImages.FindAsync(id);
            if (tblProductImage == null)
            {
                return NotFound();
            }
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId", tblProductImage.ProId);
            return View(tblProductImage);
        }

        // POST: Admin/TblProductImages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImgId,ProId,Image,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblProductImage tblProductImage)
        {
            if (id != tblProductImage.ImgId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblProductImage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblProductImageExists(tblProductImage.ImgId))
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
            ViewData["ProId"] = new SelectList(_context.TblProducts, "ProId", "ProId", tblProductImage.ProId);
            return View(tblProductImage);
        }

        // GET: Admin/TblProductImages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProductImage = await _context.TblProductImages
                .Include(t => t.Pro)
                .FirstOrDefaultAsync(m => m.ImgId == id);
            if (tblProductImage == null)
            {
                return NotFound();
            }

            return View(tblProductImage);
        }

        // POST: Admin/TblProductImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblProductImage = await _context.TblProductImages.FindAsync(id);
            _context.TblProductImages.Remove(tblProductImage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblProductImageExists(int id)
        {
            return _context.TblProductImages.Any(e => e.ImgId == id);
        }
    }
}
