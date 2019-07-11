using System.ComponentModel.DataAnnotations;

namespace MVC_HW.Models
{
    public class AccountBookViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Amount { get; set; }
    }
}