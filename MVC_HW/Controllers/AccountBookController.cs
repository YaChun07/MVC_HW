using System.Collections.Generic;
using System.Web.Mvc;
using MVC_HW.Models;
using MVC_HW.Models.Service;

namespace MVC_HW.Controllers
{
    public class AccountBookController : Controller
    {
        private readonly AccountService _accountService = new AccountService();

        // GET: AccountBook
        public ActionResult Index()
        {
            return View("accountBook", InitAccountBookData());
        }

        private List<AccountBookViewModel> InitAccountBookData()
        {
            return _accountService.GetAccountBooks();
        }
    }
}