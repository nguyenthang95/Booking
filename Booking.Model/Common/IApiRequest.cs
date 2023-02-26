using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Common
{
    public interface IApiRequest<T> where T : new()
    {
        ApiHeader Header { get; set; }
        ApiMetaForRequest Meta { get; set; }
        T Data { get; set; }
    }
}
