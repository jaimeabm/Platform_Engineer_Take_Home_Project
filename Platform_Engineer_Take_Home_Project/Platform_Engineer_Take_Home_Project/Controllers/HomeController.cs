using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Platform_Engineer_Take_Home_Project.Models;

using CustomComponents;

namespace Platform_Engineer_Take_Home_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly GmailSender _gmailSender;
        private readonly ZillowRentEstimate _zillowRentEstimate;
        private readonly ApplicationDbContext _db;
        private IHttpContextAccessor _accessor;

        public HomeController(ApplicationDbContext db, IHttpContextAccessor accessor, ZillowRentEstimate zillowRentEstimate, GmailSender gmailSender)
        {
            _db = db;
            _accessor = accessor;
            _zillowRentEstimate = zillowRentEstimate;
            _gmailSender = gmailSender;
        }

        //GET: Create Action Method
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(User user)
        {
            if(ModelState.IsValid)
            {
                var ip = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
                if (Request.Headers.ContainsKey("X-Forwarded-For"))
                    ip = Request.Headers["X-Forwarded-For"];
                user.IP = ip;

                var rentAmount = await _zillowRentEstimate.GetRentEstimateAsync(user.Address, user.City, user.State, user.Zip);

                user.RentEstimated = Decimal.Parse(rentAmount.RentPrice);
                user.PropertyPrice = Decimal.Parse(rentAmount.PropertyCost);
                    
                _db.Add(user);
                await _db.SaveChangesAsync();
                _gmailSender.PrepareSMTPClient();
                _gmailSender.SendMessage(_gmailSender.UserName, user.Email, "Your free rent estimate value", (user.RentEstimated == 0 ? "Unable to get estimated": $"{user.RangeRentEstimated}"));
                return RedirectToAction(nameof(Dashboard),new { id= user.Id });
            }
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard(int? id)
        {
            if(id == null)  return NotFound();

            var user = await _db.Users.FindAsync(id);
            if (user == null) return NotFound();

            return View(user);
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
