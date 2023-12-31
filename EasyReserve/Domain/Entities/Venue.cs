using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Venue :BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; } = default;
        public long Cpacity { get; set; }
    }
}
