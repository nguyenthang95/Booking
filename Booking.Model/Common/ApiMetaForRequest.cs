using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Common
{
    public class ApiMetaForRequest
    {
        public ApiPaginationRequest Pagination { get; set; } = new ApiPaginationRequest();
        public string SortBy { get; set; }
        public string OrderBy { get; set; }
        public string Search { get; set; }
    }
}
