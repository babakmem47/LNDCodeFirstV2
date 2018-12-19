using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class TelType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<TelNumber> TelNumbers { get; set; }

    }
}