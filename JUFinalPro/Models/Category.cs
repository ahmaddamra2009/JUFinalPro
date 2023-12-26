using JUFinalPro.Models.SharedPorp;
using System.ComponentModel.DataAnnotations;

namespace JUFinalPro.Models
{
    public class Category: CommonProp
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
