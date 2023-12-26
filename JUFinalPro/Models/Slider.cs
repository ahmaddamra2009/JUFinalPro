using JUFinalPro.Models.SharedPorp;
using System.ComponentModel.DataAnnotations;

namespace JUFinalPro.Models
{
    public class Slider: CommonProp
    {
        public Guid SliderId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string SliderTitle { get; set; } = string.Empty;
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string SliderSubTitle { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; }
        public decimal Price { get; set; }
        [Required]
        public int DiscountPer { get; set; }
        [Required]
        public string SliderImg { get; set; }

    }
}
