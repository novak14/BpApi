using AccessFacade.Configuration;
using AccessFacade.Dal.Entities;
using AccessFacade.Dal.Repository.Abstraction;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class TestRepository : BusinessObject, ITestRepository
    {
        public readonly AccessFacadeOptions options;

        public TestRepository(IOptions<AccessFacadeOptions> options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            this.options = options.Value;
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
            throw new NotImplementedException();
        }

        public string SelectTest()
        {
            return "Jsem tu";
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}
