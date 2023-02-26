using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Entities
{
    public class AccountCategory:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
