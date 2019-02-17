using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoopAntiquesV2.Models
{
    public class Booth
    {
        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public string Name { get; set; }

        public string Desctiption { get; set; }

        public List<DealerBooth> DealerBooth { get; set; }
    }
}
