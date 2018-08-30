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

        // Synchronize EfCore
        public string SelectEFCoreSync()
        {
            var test = eFCoreSyncRepository.Select();
            return "test";
        }

        public string UpdateEFCoreSync()
        {
            var test = eFCoreSyncRepository.Update();

            return "test";
        }

        public string InsertEFCoreSync()
        {
            var test = eFCoreSyncRepository.Insert();

            DateTime date = DateTime.Now;
            return "test";
        }

        public string DeleteEFCoreSync()
        {
            var test = eFCoreSyncRepository.Delete();

            return "test";
        }

        // Asychronize EfCore
        public string SelectEFCoreASync()
        {
            var test = eFCoreASyncRepository.Select();
            return "test";
        }

        public string UpdateEFCoreASync()
        {
            var test = eFCoreASyncRepository.Update();

            return "test";
        }

        public string InsertEFCoreASync()
        {
            var test = eFCoreASyncRepository.Insert();

            return "test";
        }

        public string DeleteEFCoreASync()
        {
            var test = eFCoreASyncRepository.Delete();

            return "test";
        }

        // Procedure EfCore
        public string SelectEFCoreProcedure()
        {
            var test = eFCoreProcedureRepository.Select();

            return "test";
        }

        public string UpdateEFCoreProcedure()
        {
            var test = eFCoreProcedureRepository.Update();

            return "test";
        }

        public string InsertEFCoreProcedure()
        {
            var test = eFCoreProcedureRepository.Insert();

            return "test";
        }

        public string DeleteEFCoreProcedure()
        {
            var test = eFCoreProcedureRepository.Delete();

            return "test";
        }
    }
}
