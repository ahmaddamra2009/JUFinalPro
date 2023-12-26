using JUFinalPro.Models.SharedPorp;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JUFinalPro.Models
{
    public class Course: CommonProp
    {
        public int CourseId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string CoursesName { get; set; }
        [Required]
        public string CoursesDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime SDate { get; set; }
        public TimeSpan STime { get; set; }
        public decimal Price { get; set; }
        public int DisPerc { get; set; }
        public int Hours { get; set; }
        public string UrlVideo { get; set; }
        public Venus Venu { get; set; }
        [ForeignKey("Category")]
        [DisplayName("Category Name")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public enum Venus
        {
            Online,Offline,Recorded
        }

    }
}
