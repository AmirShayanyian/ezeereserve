using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Entities
{
    public class Artist
    {
        public string UserName { get; set; }
        public Genre Genre { get; set; }
        
        public List<Concert> ConcertList { get; set; }
    }
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(p => p.Genre)
                .HasMaxLength(20);
        }
    }
}
