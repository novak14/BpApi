﻿using BpApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Dal.Repository.Abstraction
{
    public interface IDapperSyncRepository : BusinessObject
    {
        string SelectTest();
        string InsertTest(string FirstName, int id);
    }
}
