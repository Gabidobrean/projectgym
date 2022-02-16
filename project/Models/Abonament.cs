using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class Abonament
    {
        public int ID { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]

        [Display(Name = "Tipul abonamentului")]
        public string Tip { get; set; }
        [Range(100, 300)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [Required]
        [Display(Name = "Data creării abonamentului")]
        [DataType(DataType.Date)]
        public DateTime DataCreareAbonament { get; set; }
        public int AntrenorID { get; set; }
        public Antrenor Antrenor { get; set; }
        public int CursID { get; set; }
        public Curs Curs { get; set; }
    }
}
