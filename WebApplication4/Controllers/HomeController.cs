using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CreditContext db;

        public HomeController(ILogger<HomeController> logger, CreditContext creditContext)
        {
            _logger = logger;
            db = creditContext;
        }

        public ActionResult Index()
        {
            GiveCredits();
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;

            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, <b>" + newBid.Name + "</b>, за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";
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

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }
    }
}