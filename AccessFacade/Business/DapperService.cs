using AccessFacade.Dal.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Business
{
    public class DapperService
    {
        private IDapperSyncRepository dapperSync;
        private IDapperAsyncRepository dapperAsyncRepository;
        private IDapperProceudureRepository dapperProcedureRepository;
        

        public DapperService(
            IDapperSyncRepository dapperSync, 
            IDapperAsyncRepository dapperAsyncRepository,
            IDapperProceudureRepository dapperProcedureRepository)
        {
            this.dapperSync = dapperSync;
            this.dapperAsyncRepository = dapperAsyncRepository;
            this.dapperProcedureRepository = dapperProcedureRepository;
        }

        #region sync
        // Synchronize Dapper
        public string SelectDapperSync()
        {
            dapperSync.Select();
            return "test";
        }

        public string UpdateDapperSync(string FirstName, int id)
        {
            dapperSync.Update(FirstName, id);

            return "test";
        }

        public string InsertDapperSync(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            dapperSync.Insert(FirstName, LastName, Address, FkOneToTestId);

            return "test";
        }

        public string DeleteDapperSync()
        {
            dapperSync.Delete();

            return "test";
        }
        #endregion

        #region async
        // Asychronize Dapper
        public string SelectDapperASync()
        {
            dapperAsyncRepository.Select();
            return "test";
        }

        public string UpdateDapperASync(string FirstName, int id)
        {
            dapperAsyncRepository.Update(FirstName, id);

            return "test";
        }

        public string InsertDapperASync(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            dapperAsyncRepository.Insert(FirstName, LastName, Address, FkOneToTestId);

            return "test";
        }

        public string DeleteDapperASync()
        {
            dapperAsyncRepository.Delete();

            return "test";
        }
        #endregion

        #region procedure
        // Procedure Dapper
        public string SelectDapperProcedure()
        {
            dapperProcedureRepository.Select();

            return "test";
        }

        public string UpdateDapperProcedure(string FirstName, int id)
        {
            dapperProcedureRepository.Update(FirstName, id);

            return "test";
        }

        public string InsertDapperProcedure(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            dapperProcedureRepository.Insert(FirstName, LastName, Address, FkOneToTestId);

            return "test";
        }

        public string DeleteDapperProcedure()
        {
            dapperProcedureRepository.Delete();

            return "test";
        }
        #endregion
    }
}
