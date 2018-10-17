﻿using AccessFacade.Configuration;
using AccessFacade.Dal.Context;
using AccessFacade.Dal.Entities;
using AccessFacade.Dal.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class EFCoreASyncRepository : IEFCoreASyncRepository
    {
        private readonly EfCoreDbContext context;

        public EFCoreASyncRepository(EfCoreDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteAsync(UserTestDelete userTestDelete)
        {
            context.UserTestDelete.Remove(userTestDelete);
            await context.SaveChangesAsync();
        }       

        public async Task InsertAsync(UserTestInsert userTestInsert)
        {
            context.UserTestInsert.Add(userTestInsert);
            await context.SaveChangesAsync();
        }

        public async Task SelectAsync()
        {
            var normalSelect = await context.UserTest.ToListAsync();
        }

        public async Task UpdateAsync(UserTestUpdate userTestUpdate)
        {
            context.UserTestUpdate.Update(userTestUpdate);
            await context.SaveChangesAsync();
        }

        public Task UpdateAsync(string FirstName, int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            throw new NotImplementedException();
        }
    }
}
