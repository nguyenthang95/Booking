using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Model.Common
{
    public interface IApiResponse<T> where T : new()
    {
        ApiHeader Header { get; set; }
        ApiMetaForResponse Meta { get; set; }

        T Data { get; set; }
    }
}
