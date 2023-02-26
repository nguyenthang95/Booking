using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Common
{
    public class ApiResponse<T> : IApiResponse<T> where T : new()
    {
        public ApiHeader Header { get; set; } = new ApiHeader();
        public ApiMetaForResponse Meta { get; set; } = new ApiMetaForResponse();
        public T Data { get; set; } = new T();
    }
}
