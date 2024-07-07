using Microsoft.AspNetCore.Mvc;
using NowSaiGon.Models;
using System.Collections.Generic;
using NowSaiGon.Helpers;
using System.Linq;

namespace NowSaiGon.Controllers
{
    public class CartController : Controller
    {
        private readonly lvVietNamContext _lvVietNamContext;
        public CartController(lvVietNamContext _context)
        {
            _lvVietNamContext = _context;

        }
        public List<CartItem> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if(data != null)
                {
                    data = new List<CartItem>();
                }
                return data;
            }
        }
        public IActionResult Index()
        {
            return View(Carts);
        }
        public IActionResult AddToCart(int id)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p=>p.proId == id);
            if(item == null)
            {
                var product = _lvVietNamContext.TblProducts.SingleOrDefault(p => p.ProId == id);
                item = new CartItem()
                {
                    proId = id,
                    proName = product.ProName,
                    Price=product.Price.Value,
                    Quantity =1,
                    Image = product.Avatar
                    
                };
                myCart.Add(item);
            }
            else
            {
                item.Quantity++;
            }
            HttpContext.Session.Set("GioHang", myCart);
            return RedirectToAction("Index");
        }
    }
}
