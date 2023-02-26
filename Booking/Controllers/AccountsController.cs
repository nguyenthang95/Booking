using Booking.Model.Common;
using Booking.Model.DTO;
using Booking.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        public AccountsController()
        {

        }

        [ActionName("Authenticate")]
        [HttpPost]
        public async Task<ApiResponse<Account>> Authenticate([FromBody] ApiRequest<AccountLoginRequest> request)
        {

            return null;
        }
    }
}
