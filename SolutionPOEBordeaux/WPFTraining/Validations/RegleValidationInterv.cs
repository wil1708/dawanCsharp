using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFTraining.Validations
{
    // <prefix:RegleValidationInterv Min="0" Max="300"/>

    public class RegleValidationInterv : ValidationRule
    {
        public int? Min { get; set; }
        public int? Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int v;
            bool result = int.TryParse((string)value, out v);

            if (!result)
                return new ValidationResult(false, "Erreur : Vous devez saisir un entier !");

            if (!Min.HasValue && Max.HasValue && v > Max)
                return new ValidationResult(false, $"Erreur : Vous devez saisir un entier <= {Max}");

            if (!Max.HasValue && Min.HasValue && v < Min)
                return new ValidationResult(false, $"Erreur : Vous devez saisir un entier >= {Min}");

            if (Min.HasValue && Max.HasValue && (v < Min || v > Max))
                return new ValidationResult(false, $"Erreur : Vous devez saisir un entier entre {Min} et {Max}");

            return new ValidationResult(true, null);
        }

    }

}

