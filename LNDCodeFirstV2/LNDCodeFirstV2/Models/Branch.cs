using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Branch
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Shakhes { get; set; }

        public bool IsMomtaz { get; set; }

        public string Address { get; set; }

        public Setad Setad { get; set; }

        public int? SetadId { get; set; }

        public IpRange IpRange { get; set; }

        public int IpRangeId { get; set; }

        public IList<Bajje> Bajjes { get; set; }

        public IList<Atm> Atms { get; set; }

    }
}