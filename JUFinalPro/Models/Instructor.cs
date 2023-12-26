using JUFinalPro.Models.SharedPorp;
using System.ComponentModel.DataAnnotations;

namespace JUFinalPro.Models
{
    public class Instructor: CommonProp
    {
        public int InstructorId { get; set; }
        [Required]
        public string InstructorName { get; set; }
        public string Position { get; set; }
        public string LinkedIn { get; set;}

    }
}
