using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoHtmlHelper.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public decimal Salaire { get; set; }
        public bool IsActif { get; set; }
        public string Email { get; set; }
        public DateTime DateEntree { get; set; }
        public EmployeType Type { get; set; }
        //L'employé est lié à un département
        public int DepartementId { get; set; }
        public enum EmployeType
        {
            DEBUTANT = 1,
            JUNIOR = 2,
            SENIOR = 3
        }
    }
}