using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NowSaiGon.Models;
using PagedList.Core;

namespace NowSaiGon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TblCategoriesController : Controller
    {
        private readonly lvVietNamContext _context;

        public TblCategoriesController(lvVietNamContext context)
        {
            _context = context;
        }

        // GET: Admin/TblCategories
        public async Task<IActionResult> Index(int? page)
        {
           // return View(await _context.TblCategories.ToListAsync());

            //Nếu page = null thì là 1,ngược laijthif bằng giá trị values
            var pageNumber = page == null || page < 1 ? 1 : page.Value;
            //var pageSize = Utilities.PAGE_SIZE;
            var pageSize = 5;
            //Lấy ra danh sách danh mục,sawpsxeeps bằng CatId
            var lsCategories = _context.TblCategories.OrderByDescending(x => x.Id);
            //Phân trang bằng thư viện có sẵn
            PagedList<TblCategory> models = new PagedList<TblCategory>(lsCategories, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        // GET: Admin/TblCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.TblCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblCategory == null)
            {
                return NotFound();
            }

            return View(tblCategory);
        }

        // GET: Admin/TblCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TblCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CatName,Description,Position,Levels,Parent,Image,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblCategory tblCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblCategory);
        }

        // GET: Admin/TblCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.TblCategories.FindAsync(id);
            if (tblCategory == null)
            {
                return NotFound();
            }
            return View(tblCategory);
        }

        // POST: Admin/TblCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CatName,Description,Position,Levels,Parent,Image,Published,IsNew,IsHot,CreatedDate,CreatedBy,ModifierDate,ModifierBy")] TblCategory tblCategory)
        {
            if (id != tblCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCategoryExists(tblCategory.Id))
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
            return View(tblCategory);
        }

        // GET: Admin/TblCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.TblCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblCategory == null)
            {
                return NotFound();
            }

            return View(tblCategory);
        }

        // POST: Admin/TblCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblCategory = await _context.TblCategories.FindAsync(id);
            _context.TblCategories.Remove(tblCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblCategoryExists(int id)
        {
            return _context.TblCategories.Any(e => e.Id == id);
        }
    }
}
