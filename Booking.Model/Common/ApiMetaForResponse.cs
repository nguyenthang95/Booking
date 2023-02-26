using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Common
{
   public class ApiMetaForResponse
    {
        public List<ApiMessage> Messages { get; set; } = new List<ApiMessage>();
        public DateTime? Timestamp { get; set; } = DateTime.Now;
    }
}
