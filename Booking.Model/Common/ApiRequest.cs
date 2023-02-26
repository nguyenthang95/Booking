using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Common
{
    public class ApiRequest<T> : IApiRequest<T> where T : new()
    {
        public ApiHeader Header { get; set; } = new ApiHeader();
        public ApiMetaForRequest Meta { get; set; } = new ApiMetaForRequest();
        public T Data { get; set; } = new T();
    }
}
