using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Semat Semat { get; set; }

        public int? SematId { get; set; }

        public Company Company { get; set; }

        public int? CompanyId { get; set; }

        public Section Section { get; set; }

        public int? SectionId { get; set; }

        public Branch Branch { get; set; }

        public int? BranchId { get; set; }

        public Bajje Bajje { get; set; }

        public int? BajjeId { get; set; }


    }
}