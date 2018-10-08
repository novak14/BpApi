using AccessFacade.Configuration;
using AccessFacade.Dal.Context;
using AccessFacade.Dal.Entities;
using AccessFacade.Dal.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class EFCoreSyncRepository : IEFCoreSyncRepository
    {
        private readonly EfCoreDbContext context;

        public EFCoreSyncRepository(EfCoreDbContext context)
        {
            this.context = context;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert(UserTestInsert userTestInsert)
        {
            context.UserTestInsert.Add(userTestInsert);
            context.SaveChanges();
        }

        public void Insert(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            #region normalSelect
            var normalSelect = context.UserTest.ToList();
            #endregion

            #region oneToMany
            //var test = context.UserTest
            //    .Include(one => one.OneToTest)
            //    .ToList();
            #endregion
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
