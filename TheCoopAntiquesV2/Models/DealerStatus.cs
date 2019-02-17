using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoopAntiquesV2.Models
{
    public class DealerStatus
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }


    }
}
