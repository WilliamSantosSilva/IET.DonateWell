using IET.Comum.Patterns.DomainDriver.Contracts.EFCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Interface.Service
{
    public interface IAddressService : IServiceBase<Domain.Entities.Address>
    {
    }
}
