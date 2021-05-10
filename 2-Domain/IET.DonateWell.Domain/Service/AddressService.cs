using IET.Comum.Patterns.DomainDriver.Contracts.EFCore.Repositories;
using IET.Comum.Patterns.DomainDriver.Services.EFCore;
using IET.Comum.Patterns.DomainNotification.Interface;
using IET.DonateWell.Domain.Entities;
using IET.DonateWell.Domain.Interface.Repository;
using IET.DonateWell.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Service
{
    public class AddressService : ServiceBase<Domain.Entities.Address>, IAddressService
    {
        public AddressService(IAddressRepository context, INotify notify) : base(context, notify)
        {
        }
    }
}
