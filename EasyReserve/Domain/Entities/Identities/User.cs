using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Identities
{
   public class User : IdentityUser<long>, IBaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }

        
    }

   public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.FirstName)
                .HasMaxLength(20);
            builder.Property(p => p.LastName)
                .HasMaxLength(20);
            builder.Property(p => p.UserName)
                .IsRequired();
            builder.Property(p => p.Address)
                .HasMaxLength(200);
            builder.Property(p => p.UserName)
                .HasMaxLength(25);
        }
    }
}
