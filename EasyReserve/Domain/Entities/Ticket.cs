using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{ 
    public class Ticket:BaseEntity
    {
        public string TicketNr { get; set; }
        public Decimal Price { get; set; }
        public string SeatNr { get; set; }
        public TicketStatus Status { get; set; }
        public Concert Concert { get; set; }

    }
    public class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(p => p.TicketNr)
                .IsRequired();
            builder.Property(p => p.Concert)
                .IsRequired();
        }
    }
}
