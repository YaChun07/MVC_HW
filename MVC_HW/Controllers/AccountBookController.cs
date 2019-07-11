using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MVC_HW.Models;

namespace MVC_HW.Controllers
{
    public class AccountBookController : Controller
    {
        // GET: AccountBook
        public ActionResult Index()
        {
            return View("accountBook", InitAccountBookData());
        }

        private List<AccountBookViewModel> InitAccountBookData()
        {
            var accountBooks = new List<AccountBookViewModel>();

            var random = new Random();
            var consumeType = new List<string>
            {
                "支出","收入"
            };

            for (var i = 0; i < 100; i++)
            {
                accountBooks.Add(new AccountBookViewModel()
                {
                    Id = i + 1,
                    Type = consumeType[random.Next(0, 2)],
                    Amount = random.Next(1, 3000),
                    Date = DateTime.Now.AddMinutes(random.Next(1, 3000)).ToString("yyyy-MM-dd")
                });
            }

            return accountBooks;
        }
    }
}