using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public  class Concert : BaseEntity
    {
        public Artist Artist { get; set; }
        
        public Venue Venue { get; set; }
        
        public Ticket Ticket { get; set; }
        public long ConcertId { get; set; }
        public Genre Genre { get; set; }

    }
}
