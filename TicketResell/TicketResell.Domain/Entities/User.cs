using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketResell.Domain.Entities
{
    public class User : GenericEntity
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
