using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Bajje
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Branch Branch { get; set; }

        public int BranchId { get; set; }

        public IpRange IpRange { get; set; }

        public int? IpRangeId { get; set; }

        public IList<Atm> Atms { get; set; }

        public IList<Person> Persons { get; set; }

        public IList<TelNumber> TelNumbers { get; set; }
    }
}