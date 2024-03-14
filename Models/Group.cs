using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using NuGet.Protocol.Plugins;

namespace NC_24.Models
{
    [Table("Groups")]
    public class Group
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nazwa")]
        public string? Name { get; set; }

        [Display(Name = "Grupa")]
        public string? Sname { get; set; }

        [Display(Name = "Lista studentów")]
        public virtual ICollection<Student>? Students { get; }

        [ForeignKey("FieldId")]
        public int? FieldId { get; set; }

        [Display(Name = "Kierunek")]
        public Field? Field { get; set; }

        [Display(Name = "Przedmioty")]
        public ICollection<Course>? Courses { get; set; }
    }
}
