using System.ComponentModel.DataAnnotations;

namespace MyTasks.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 11, ErrorMessage = "Must be more than 10 charector long.")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Target Date")]
        public DateTime TargetDate {  get; set; }
        public string Status { get; set; } = "Started";
    }
}
