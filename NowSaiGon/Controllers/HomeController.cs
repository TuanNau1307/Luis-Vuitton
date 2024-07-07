using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NowSaiGon.Models;
using NowSaiGon.ViewModels;
//using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace NowSaiGon.Controllers
{
	public class HomeController : Controller
	{
		lvVietNamContext db = new lvVietNamContext();
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			

			//code moi
			//var lstProduct = db.TblProducts.AsNoTracking().OrderBy(x=>x.CreatedDate).ToList();

			//List<HomeViewModel> lstProductViews = new List<HomeViewModel>();
			//var lsCats = db.TblCategories.AsNoTracking().ToList();
			//foreach (var cat in lsCats)
			//{
			//	HomeViewModel view = new HomeViewModel();
			//	view.Category = cat;
			//	view.Products = lstProduct.Where(x=>x.Id == cat.Id).ToList();
			//	lstProductViews.Add(view);
			//}	

			//var lstProduct = db.TblProducts.AsNoTracking().OrderBy(x=>x.ProId);
			
            var lsCats = db.TblCategories.AsNoTracking().ToList();
            var lstProduct = db.TblProducts.AsNoTracking().OrderBy(x => x.CreatedDate).ToList();

            var homeViewModel = new HomeViewModel
			{
				Category = lsCats,
				Products = lstProduct,

			};
            
			return View(homeViewModel);
		}
		public IActionResult ShowAllProduct(int? page)
		{
            //HomeViewModel model = new HomeViewModel();
            int pageSize = 6;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstProduct = db.TblProducts.AsNoTracking().OrderBy(x => x.CreatedDate).ToList();
            PagedList<TblProduct> lst = new PagedList<TblProduct>(lstProduct, pageNumber, pageSize);
            return View(lst);
		}
		//public IActionResult ProductDetail(int? productId)
		//{
		//	var product =db.TblProducts.SingleOrDefault(x=>x.ProId == productId);
		//	var img=db.TblProductImages.Where(x=>x.ProId==productId).ToList();
		//	ViewBag.img = img;
		//	return View(product);
		//}
		public IActionResult ProductDetails(int? productId)
		{
            var product = db.TblProducts.SingleOrDefault(x => x.ProId == productId);
            var img = db.TblProductImages.Where(x => x.ProId == productId).ToList();
			var size = db.TblProductDetails.Where(x=>x.ProId == productId).ToList();
			var relatedProduct = db.TblProducts.Where(x=>x.Id ==product.Id&&x.ProId != productId).Take(4).ToList();
			var homeProductDetailViewModel = new HomeProductDetailViewModel
			{
				product = product,
				proImg = img,
				productDetails = size,
				relatedProduct = relatedProduct
			};
			return View(homeProductDetailViewModel);

        }
		public IActionResult ShowProductByCategory(int id,int? page)
		{
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstProduct = db.TblProducts.AsNoTracking().Where(x=>x.Id==id).OrderBy(x => x.CreatedDate);
			ViewBag.Id = id;
            PagedList<TblProduct> lst = new PagedList<TblProduct>(lstProduct, pageNumber, pageSize);
           // List<TblProduct> lstProducts=db.TblProducts.Where(x=>x.Id==id).OrderBy(x=>x.CreatedDate).ToList();
			return View(lst);
		}

		public IActionResult Privacy()
		{
            

            return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
