using IET.Comum.Patterns.DomainDriver.Contracts.EFCore.Services;
using IET.DonateWell.Application.Interface;
using IET.DonateWell.Domain.Entities;
using IET.DonateWell.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Application.Service
{
    public class AddressAppService : Base.AppServiceBase<Model.AddressModel>, IAddressAppService
    {
        private readonly IAddressService _service;

        public AddressAppService(IAddressService service) : base(service)
        {
            _service = service;
        }
    }
}
