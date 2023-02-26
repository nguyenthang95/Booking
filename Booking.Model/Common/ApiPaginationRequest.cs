using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Common
{
    public class ApiPaginationRequest
    {
        public int PageOffset { get; set; } = 0;
        public int PageLimit { get; set; } = 0;
    }
}
