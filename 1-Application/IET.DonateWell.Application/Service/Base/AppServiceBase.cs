using IET.Comum.Patterns.DomainDriver.Contracts.EFCore.Services;
using IET.DonateWell.Application.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Application.Service.Base
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity>
        where TEntity : class
    {
        private IServiceBase<TEntity> _service;
        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public Task<TEntity> Add(TEntity model) => 
            _service.Add(model);

        public Task AddRange(params TEntity[] models) => 
            _service.AddRange(models);

        public void Dispose() => 
            _service.Dispose();

        public Task<List<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties) => 
            _service.GetAll(navigationProperties);

        public Task<IList<TEntity>> GetList(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties) => 
            _service.GetList(where, navigationProperties);

        public Task<TEntity> GetSingle(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties) => 
            _service.GetSingle(where, navigationProperties);

        public Task Remove(TEntity model) => 
            _service.Remove(model);

        public Task RemoveRange(params TEntity[] models) => 
            _service.RemoveRange(models);

        public Task Update(TEntity model) => 
            _service.Update(model);

        public Task UpdateRange(params TEntity[] models) => 
            _service.UpdateRange(models);
    }
}
