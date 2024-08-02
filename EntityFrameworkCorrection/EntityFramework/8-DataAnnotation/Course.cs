using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DataAnnotation
{
    //[Table("t_course")]
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        public float Price { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<Tag> Tags { get; set; }

        //Bonne pratique: les attributs de type collection doivent être initialisées dans le contructeur
        public Course()
        {
            Tags = new List<Tag>();
        }
    }
}
