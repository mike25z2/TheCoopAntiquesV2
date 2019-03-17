using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoopAntiquesV2.Models
{
    public class TaxRate
    {
        public int Id { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:d}")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float Amount { get; set; }
    }
}
