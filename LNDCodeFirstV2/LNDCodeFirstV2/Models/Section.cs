using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Section
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SetadId { get; set; }

        public Setad Setad { get; set; }

    }
}