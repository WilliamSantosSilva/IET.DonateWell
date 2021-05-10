using IET.Comum.Patterns.DomainDriver.Contracts.EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Domain.Interface.Repository
{
    public interface IAddressRepository : IRepositoryBase<Domain.Entities.Address>
    {
    }
}
