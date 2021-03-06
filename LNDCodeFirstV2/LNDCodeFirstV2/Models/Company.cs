﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirstV2.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public IList<FieldOfActivity> FieldOfActivities { get; set; }

        public IList<Person> Persons { get; set; }

        public IList<TelNumber> TelNumbers { get; set; }
    }
}