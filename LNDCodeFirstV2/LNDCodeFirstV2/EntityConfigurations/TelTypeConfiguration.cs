﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class TelTypeConfiguration : EntityTypeConfiguration<TelType>
    {
        public TelTypeConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(8);
        }
    }
}