using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NowSaiGon.Models;
using NowSaiGon.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NowSaiGon.Controllers
{
    public class AccountsController : Controller
    {
        private readonly lvVietNamContext _context;
        public AccountsController(lvVietNamContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangKyTaiKhoan()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangKyTaiKhoan(RegisterViewModel taikhoan)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    TblCustomer tk = new TblCustomer
                    {
                        CustomerName = taikhoan.CustomerName,
                        Phone = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),
                        Pass = taikhoan.Pass.Trim().ToLower(),
                        Address = taikhoan.Andress.Trim().ToLower()
                    };
                    try
                    {
                        _context.Add(tk);
                        await _context.SaveChangesAsync();
                        //Lưu session Makh
                        HttpContext.Session.SetString("CusId", tk.CusId.ToString());
                        var taikhoanID = HttpContext.Session.GetString("CusId");
                        //Identity
                        var claim = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,tk.CustomerName),
                            new Claim("CusId",tk.CusId.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claim, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    catch
                    {
                        return RedirectToAction("DangKyTaiKhoan", "Accounts");
                    }

                }
                else
                {
                    return View(taikhoan);
                }    
                }  
            catch
            {
                return View(taikhoan);
            }
            }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer,string returnUrl = null)
        {
            try
            {
               
                if (ModelState.IsValid)
                {
                    var khachhang = _context.TblCustomers.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == customer.Username);
                    if (khachhang == null) return RedirectToAction("DangKyTaiKhoan");
                    string pass = customer.Password;
                    if(khachhang.Pass !=pass)
                    {
                        ViewBag.Error = "+ Sai thông tin đăng nhập";
                        return View(customer);
                    }
                    //Lưu session Makh
                    HttpContext.Session.SetString("CusId", khachhang.CusId.ToString());
                    var taikhoanID = HttpContext.Session.GetString("CusId");
                    //Identity
                    var claim = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,khachhang.CustomerName),
                            new Claim("CusId",khachhang.CusId.ToString())
                        };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claim, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    return RedirectToAction("Dashboard", "Accounts");
                }    

            }
            catch
            {
                return RedirectToAction("DangKyTaiKhoan", "Accounts");

            }
            return View(customer);
        }
        }
    
}
