using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoopAntiquesV2.Models
{
    public class DealerBooth
    {
        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }

        public int BoothId { get; set; }
        public Booth Booth { get; set; }
    }
}
