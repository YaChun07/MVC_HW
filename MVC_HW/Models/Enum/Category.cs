using System.ComponentModel.DataAnnotations;

namespace MVC_HW.Models.Enum
{
    public enum Category
    {
        [Display(Name = "收入")]
        Income,

        [Display(Name = "花費")]
        Expense
    }
}