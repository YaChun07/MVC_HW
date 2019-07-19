using System.Collections.Generic;
using System.Linq;
using MVC_HW.Models.Enum;

namespace MVC_HW.Models.Service
{
    public class AccountService
    {
        public List<AccountBookViewModel> GetAccountBooks()
        {
            var accountBooks = new List<AccountBookViewModel>();
            var accountBook = new AccountBookEntity().AccountBook.ToList();

            foreach (var book in accountBook)
            {
                accountBooks.Add(new AccountBookViewModel
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