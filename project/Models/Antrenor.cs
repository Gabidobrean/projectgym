using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class Antrenor
    {
        public int ID { get; set; }
        [Display(Name = "Nume Antrenor")]
        public string NumeAntrenor { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+$"), Required, StringLength(50,
MinimumLength = 3)]
        [Display(Name = "Prenume Antrenor")]
        public string PrenumeAntrenor { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+$"), Required,
StringLength(50, MinimumLength = 3)]
        public string Ziua { get; set; }
        public string Ora { get; set; }
    }
}
