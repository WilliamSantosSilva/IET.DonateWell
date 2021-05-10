using IET.Comum.Model;
using IET.Comum.Patterns.DomainNotification.Api;
using IET.DonateWell.Application.Interface;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IET.DonateWell.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ApiController
    {
        private readonly IAddressAppService _appService;
        protected AddressController(IAddressAppService appService,INotificationHandler<DomainNotifications> notification) : base(notification)
        {
            _appService = appService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Application.Model.AddressModel model) => CreatedHasNotification(await _appService.Add(model));
    }
}
