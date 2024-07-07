using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NowSaiGon.Models;
using System.Linq;

namespace NowSaiGon.Controllers
{
    public class AccountController : Controller
    {
        lvVietNamContext db = new lvVietNamContext();
        [HttpGet]
        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("Email")==null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Home");
            }    
        }
        [HttpPost]
        public IActionResult Login(TblCustomer customer)
        {
            if(HttpContext.Session.GetString("Email")==null)
            {
                var u=db.TblCustomers.Where(x=>x.Email.Equals(customer.Email) && x.Pass.Equals(customer.Pass)).FirstOrDefault();
                if(u!=null)
                {
                    HttpContext.Session.SetString("Email", u.Email.ToString());
                    //string email = customer.Email;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("Email");
            return RedirectToAction("Login", "Account");
        }
    }
}
