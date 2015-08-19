using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HorecaVlaanderenOpleidingen.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Kantoor Locatie")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}