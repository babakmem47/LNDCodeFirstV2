﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Section
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Setad> Setads { get; set; }

        public IpRange IpRange { get; set; }

        public int? IpRangeId { get; set; }

        public IList<Person> Persons { get; set; }

        public IList<TelNumber> TelNumbers { get; set; }

    }
}