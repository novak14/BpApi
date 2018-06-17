using AccessFacade.Dal.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Business
{
    public class DapperService
    {
        private IDapperSyncRepository dapperSync;
        private ITestRepository testRepository;

        public DapperService(IDapperSyncRepository dapperSync, ITestRepository testRepository)
        {
            this.dapperSync = dapperSync;
            this.testRepository = testRepository;
        }

        // Synchronize Dapper
        public string SelectDapperSync()
        {
            var test = dapperSync.Select();
            return dapperSync.SelectTest();
        }

        public string UpdateDapperSync()
        {
            return "test";
        }

        public string InsertDapperSync(string time)
        {
            DateTime date = DateTime.Now;
            dapperSync.InsertTest(date, time);
            return "test";
        }

        public string DeleteDapperSync()
        {
            return "test";
        }

        // Asychronize Dapper
        public string SelectDapperASync()
        {
            return "test";
        }

        public string UpdateDapperASync()
        {
            return "test";
        }

        public string InsertDapperASync()
        {
            return "test";
        }

        public string DeleteDapperASync()
        {
            return "test";
        }

        // Procedure Dapper
        public string SelectDapperProcedure()
        {
            return "test";
        }

        public string UpdateDapperProcedure()
        {
            return "test";
        }

        public string InsertDapperProcedure()
        {
            return "test";
        }

        public string DeleteDapperProcedure()
        {
            return "test";
        }

        public string SelectTest()
        {
            return testRepository.SelectTest();
        }
    }
}
