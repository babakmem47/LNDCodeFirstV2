using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Atm
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Shakhes { get; set; }

        public bool IsInsideBranch { get; set; }
        
        public string Address { get; set; }

        public Bajje Bajje { get; set; }

        public int? BajjeId { get; set; }

        public Branch Branch { get; set; }

        public int BranchId { get; set; }

        public IpRange IpRange { get; set; }

        public int IpRangeId { get; set; }

    }
}