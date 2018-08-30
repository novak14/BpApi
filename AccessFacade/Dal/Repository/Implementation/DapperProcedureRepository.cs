﻿using AccessFacade.Configuration;
using AccessFacade.Dal.Repository.Abstraction;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class DapperProcedureRepository : IDapperProceudureRepository
    {
        public readonly AccessFacadeOptions options;

        public DapperProcedureRepository(IOptions<AccessFacadeOptions> options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            this.options = options.Value;
        }

        public string Select()
        {
            throw new NotImplementedException();
        }

        public string Insert()
        {
            throw new NotImplementedException();
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}
