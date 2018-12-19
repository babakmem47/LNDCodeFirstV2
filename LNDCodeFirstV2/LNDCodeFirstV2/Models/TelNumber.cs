using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class TelNumber
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public TelType TelType { get; set; }

        public int TelTypeId { get; set; }

        public Company Company { get; set; }

        public int? CompanyId { get; set; }

        public Section Section { get; set; }

        public int? SectionId { get; set; }

        public Branch Branch { get; set; }

        public int? BranchId { get; set; }

        public Bajje Bajje { get; set; }

        public int? BajjeId { get; set; }

        public IList<Person> Persons { get; set; }

    }
}