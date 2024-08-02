using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_FluentApi
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        //Le mot clé virtual désactive le mode LAZY (chargement tardif) - Mode EAGER (chargement immédiat)

        //Si la collection est virtual = mode EAGER

        public  List<Tag> Tags { get; set; }

        public Cover Cover { get; set; }

        //Bonne pratique: les attributs de type collection doivent être initialisées dans le contructeur
        public Course()
        {
            Tags = new List<Tag>();
        }
    }
}
