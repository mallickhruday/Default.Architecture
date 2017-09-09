﻿using DefaultArchitecture.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DefaultArchitecture.Persistence.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.Property(x => x.ID).HasColumnName("UserID");
            builder.Property(x => x.Name).HasColumnName("Name");
            builder.Property(x => x.Password).HasColumnName("Password");

            builder.HasKey(x => x.ID);
        }
    }
}
