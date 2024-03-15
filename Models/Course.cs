﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NC_24.Models
{
    [Table("Courses")]
    public class Course
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Przedmiot")]
        public string? Name { get; set; }

        [Display(Name = "Opis")]
        public string? Description { get; set; }

        [Display(Name = "ECTS")]
        [Range(1, 12)]
        public int? ECTS { get; set; }

        [Display(Name = "Grupy")]
        public virtual ICollection<Group>? Groups { get; set; }

        [Display(Name ="Oceny")]
        public ICollection<Grade>? Grades { get; set;}
    }
}
