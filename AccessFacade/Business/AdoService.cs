using AccessFacade.Dal.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Business
{
    public class AdoService
    {
        private readonly IAdoSyncRepository adoSyncRepository;
        private readonly IAdoASyncRepository adoASyncRepository;
        private readonly IAdoProcedureRepository adoProcedureRepository;

        public AdoService(
            IAdoSyncRepository adoSyncRepository,
            IAdoASyncRepository adoASyncRepository,
            IAdoProcedureRepository adoProcedureRepository)
        {
            this.adoSyncRepository = adoSyncRepository;
            this.adoASyncRepository = adoASyncRepository;
            this.adoProcedureRepository = adoProcedureRepository;
        }

        // Synchronize Ado
        public string SelectAdoSync()
        {
            var test = adoSyncRepository.Select();
            return "test";
        }

        public string UpdateAdoSync()
        {
            var test = adoSyncRepository.Update();

            return "test";
        }

        public string InsertAdoSync()
        {
            var test = adoSyncRepository.Insert();

            DateTime date = DateTime.Now;
            return "test";
        }

        public string DeleteAdoSync()
        {
            var test = adoSyncRepository.Delete();

            return "test";
        }

        // Asychronize Ado
        public string SelectAdoASync()
        {
            var test = adoASyncRepository.Select();
            return "test";
        }

        public string UpdateAdoASync()
        {
            var test = adoASyncRepository.Update();

            return "test";
        }

        public string InsertAdoASync()
        {
            var test = adoASyncRepository.Insert();

            return "test";
        }

        public string DeleteAdoASync()
        {
            var test = adoASyncRepository.Delete();

            return "test";
        }

        // Procedure Ado
        public string SelectAdoProcedure()
        {
            var test = adoProcedureRepository.Select();

            return "test";
        }

        public string UpdateAdoProcedure()
        {
            var test = adoProcedureRepository.Update();

            return "test";
        }

        public string InsertAdoProcedure()
        {
            var test = adoProcedureRepository.Insert();

            return "test";
        }

        public string DeleteAdoProcedure()
        {
            var test = adoProcedureRepository.Delete();

            return "test";
        }
    }
}
