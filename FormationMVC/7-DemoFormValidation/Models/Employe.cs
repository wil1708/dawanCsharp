using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _7_DemoFormValidation.Models
{
    public class Employe
    {
        [Required] //exige que l'utilisateur rentre une valeur sinon la validation du formulaire ne se fera pas
        [Display(Name = "User Name:")] //Display permet de personaliser le label pour les champs de saisie

            
        public string UserName { get; set; }
        [DataType(DataType.Password)] //DataType permet de personaliser le type de l'input
        [Required(ErrorMessage = "Mot de passe obligatoire")] //Indique que le champs Password est requis
        public string Password { get; set; }

        [Required(ErrorMessage = "Date de naissance obligatoire")]
        [DataType(DataType.Date)]
        [Display(Name ="Date de naissance: ")]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "Email obligatoire")]
        [EmailAddress(ErrorMessage ="Format adresse mail invalide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Evaluation obligatoire")]
        [Range(1,10)]
        public int Evaluation { get; set; }

        [Required(ErrorMessage = "Numéro de téléphone obligatoire")]
        [Display(Name = "Numéro de téléphone: ")]
        //[Regular Expression]
        public int NumeroTelephone { get; set; }

        [Required(ErrorMessage = "Commentaire obligatoire")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }

        [FileExtensions(Extensions ="png, jpg, jpeg")]
        public string Photo { get; set; }
    }
}