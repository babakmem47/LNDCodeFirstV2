using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class IpRange
    {
        public int Id { get; set; }

        public string Range { get; set; }

        public string Mask { get; set; }

        public IList<Setad> Setads { get; set; }

        public IList<Section> Sections { get; set; }

    }
}