using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Setad
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Shakhes { get; set; }

        public byte IsModiriatShoab { get; set; }
        
        public string Address { get; set; }

        public IList<Section> Sections { get; set; }

    }
}