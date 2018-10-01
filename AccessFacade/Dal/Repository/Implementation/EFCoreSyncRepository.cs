using AccessFacade.Configuration;
using AccessFacade.Dal.Context;
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

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public string Insert()
        {
            throw new NotImplementedException();
        }

        public string Select()
        {
            //#region normalSelect
            //var normalSelect = context.UserTest;
            //#endregion

            #region oneToMany
            var test = context.UserTest
                .Include(one => one.OneToTest);
            #endregion
            return "ahoj";
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}
