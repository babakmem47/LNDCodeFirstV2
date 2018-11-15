using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class FieldOfActivity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Company> Companies { get; set; }

    }
}
