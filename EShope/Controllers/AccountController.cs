using EShope.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EShope.Controllers
{
    public class AccountController : Controller

    {
        // [Route("register")]   //برای آدرس دستی دادن به دلخواه

        [HttpGet("register")] //اگر بخواهیم بگوییم براساس نوع متد که get یا post باشد اجرا شود وآدرس دلبخواه بدهیم
        public IActionResult Register()
        {
            return View();
        }



        /*
         *  پارامتر فیلد ثبت نام را میتوان بدون ایجاد کردن ویو مدل مستقیما به این صورت دریافت کرد ولی اصولی نیست 
         *  زیرا هیچ کنترل و اعتبار سنجی سمت سرور روی این فیلد ها نخواهیم داشت و کاربر حتی می تواند دیتا اینجکشن انجام دهد
         * در پایین به صورت اصولی و با استفاده از ویو مدل پیاده سازی شده
       

        [HttpPost("register")]
        public IActionResult Register(string email,string password,string confirmPassword) 
        {
            return View();
        }
        */

        [HttpPost("register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
              
            }
            else
            {


            }
            return View();
        }


    }
}
