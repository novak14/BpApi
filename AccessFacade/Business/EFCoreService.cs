using AccessFacade.Dal.Entities;
using AccessFacade.Dal.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Business
{
    public class EFCoreService
    {
        private readonly IEFCoreSyncRepository eFCoreSyncRepository;
        private readonly IEFCoreASyncRepository eFCoreASyncRepository;
        private readonly IEFCoreProcedureRepository eFCoreProcedureRepository;

        public EFCoreService(
            IEFCoreSyncRepository eFCoreSyncRepository,
            IEFCoreASyncRepository eFCoreASyncRepository,
            IEFCoreProcedureRepository eFCoreProcedureRepository)
        {
            this.eFCoreSyncRepository = eFCoreSyncRepository;
            this.eFCoreASyncRepository = eFCoreASyncRepository;
            this.eFCoreProcedureRepository = eFCoreProcedureRepository;
        }

        #region sync
        // Synchronize EfCore
        public string SelectEFCoreSync()
        {
            eFCoreSyncRepository.Select();
            return "test";
        }

        public string UpdateEFCoreSync()
        {
            eFCoreSyncRepository.Update();

            return "test";
        }

        public string InsertEFCoreSync(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            UserTestInsert userTestInsert = new UserTestInsert(FirstName, LastName, Address, FkOneToTestId);
            eFCoreSyncRepository.Insert(userTestInsert);

            return "test";
        }

        public string DeleteEFCoreSync()
        {
            eFCoreSyncRepository.Delete();

            return "test";
        }
        #endregion

        #region async
        // Asychronize EfCore
        public string SelectEFCoreASync()
        {
            eFCoreASyncRepository.Select();
            return "test";
        }

        public string UpdateEFCoreASync()
        {
            eFCoreASyncRepository.Update();

            return "test";
        }

        public string InsertEFCoreASync(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            eFCoreASyncRepository.Insert(FirstName, LastName, Address, FkOneToTestId);

            return "test";
        }

        public string DeleteEFCoreASync()
        {
            eFCoreASyncRepository.Delete();

            return "test";
        }
        #endregion

        #region procedure
        // Procedure EfCore
        public string SelectEFCoreProcedure()
        {
            eFCoreProcedureRepository.Select();

            return "test";
        }

        public string UpdateEFCoreProcedure()
        {
            eFCoreProcedureRepository.Update();

            return "test";
        }

        public string InsertEFCoreProcedure(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            eFCoreProcedureRepository.Insert(FirstName, LastName, Address, FkOneToTestId);

            return "test";
        }

        public string DeleteEFCoreProcedure()
        {
            eFCoreProcedureRepository.Delete();

            return "test";
        }
        #endregion
    }
}
