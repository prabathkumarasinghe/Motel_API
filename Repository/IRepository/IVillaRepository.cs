﻿using MagicVilla.Model;
using System.Linq.Expressions;

namespace MagicVilla.Repository.IRepository
{
    public interface IVillaRepository
    {

        Task<List<Villa>> GetAllAsync(Expression<Func<Villa, bool>> filter = null);
        Task<Villa> GetAsync(Expression<Func<Villa, bool>> filter = null, bool tracked=true);
        Task CreateAsync(Villa entity);
        Task SaveAsync();
        Task RemoveAsync(Villa entity);
        Task UpdateAsync(Villa entity);


        
      


    }
}
