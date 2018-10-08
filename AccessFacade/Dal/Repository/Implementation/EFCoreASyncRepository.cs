using AccessFacade.Configuration;
using AccessFacade.Dal.Repository.Abstraction;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class EFCoreASyncRepository : IEFCoreASyncRepository
    {
        public readonly AccessFacadeOptions options;

        public EFCoreASyncRepository(IOptions<AccessFacadeOptions> options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            this.options = options.Value;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
