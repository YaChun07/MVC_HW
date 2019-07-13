using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVC_HW.Models;
using MVC_HW.Models.Enum;

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
            var accountBookEntity = new AccountBookEntity();
            var accountBook = accountBookEntity.AccountBook.ToList();
            foreach (var book in accountBook)
            {
                accountBooks.Add(new AccountBookViewModel()
                {
                    Amount = book.Amounttt,
                    Type = ((Category)book.Categoryyy).ToString(),
                    Date = book.Dateee.ToString("yyyy-MM-dd")
                });
            }
            return accountBooks;
        }
    }
}