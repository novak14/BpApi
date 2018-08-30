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
        private IDapperAsyncRepository dapperAsyncRepository;
        private IDapperProceudureRepository dapperProcedureRepository;
        

        public DapperService(
            IDapperSyncRepository dapperSync, 
            ITestRepository testRepository,
            IDapperAsyncRepository dapperAsyncRepository,
            IDapperProceudureRepository dapperProcedureRepository)
        {
            this.dapperSync = dapperSync;
            this.testRepository = testRepository;
            this.dapperAsyncRepository = dapperAsyncRepository;
            this.dapperProcedureRepository = dapperProcedureRepository;
        }

        // Synchronize Dapper
        public string SelectDapperSync()
        {
            var test = dapperSync.Select();
            return dapperSync.Select();
        }

        public string UpdateDapperSync()
        {
            var test = dapperSync.Update();

            return "test";
        }

        public string InsertDapperSync()
        {
            var test = dapperSync.Insert();

            return "test";
        }

        public string DeleteDapperSync()
        {
            var test = dapperSync.Delete();

            return "test";
        }

        // Asychronize Dapper
        public string SelectDapperASync()
        {
            var test = dapperAsyncRepository.Select();
            return "test";
        }

        public string UpdateDapperASync()
        {
            var test = dapperAsyncRepository.Update();

            return "test";
        }

        public string InsertDapperASync()
        {
            var test = dapperAsyncRepository.Insert();

            return "test";
        }

        public string DeleteDapperASync()
        {
            var test = dapperAsyncRepository.Delete();

            return "test";
        }

        // Procedure Dapper
        public string SelectDapperProcedure()
        {
            var test = dapperProcedureRepository.Select();

            return "test";
        }

        public string UpdateDapperProcedure()
        {
            var test = dapperProcedureRepository.Update();

            return "test";
        }

        public string InsertDapperProcedure()
        {
            var test = dapperProcedureRepository.Insert();

            return "test";
        }

        public string DeleteDapperProcedure()
        {
            var test = dapperProcedureRepository.Delete();

            return "test";
        }
    }
}
