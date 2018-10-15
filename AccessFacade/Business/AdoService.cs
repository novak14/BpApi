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
            adoSyncRepository.Select();
            return "test";
        }

        public string UpdateAdoSync(string FirstName, int id)
        {
            adoSyncRepository.Update(FirstName, id);

            return "test";
        }

        public string InsertAdoSync(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            adoSyncRepository.Insert(FirstName, LastName, Address, FkOneToTestId);

            DateTime date = DateTime.Now;
            return "test";
        }

        public string DeleteAdoSync(int id)
        {
            adoSyncRepository.Delete(id);

            return "test";
        }

        // Asychronize Ado
        public string SelectAdoASync()
        {
            adoASyncRepository.Select();
            return "test";
        }

        public string UpdateAdoASync(string FirstName, int id)
        {
            adoASyncRepository.Update(FirstName, id);

            return "test";
        }

        public string InsertAdoASync(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            adoASyncRepository.Insert(FirstName, LastName, Address, FkOneToTestId);

            return "test";
        }

        public string DeleteAdoASync(int id)
        {
            adoASyncRepository.Delete(id);

            return "test";
        }

        // Procedure Ado
        public string SelectAdoProcedure()
        {
            adoProcedureRepository.Select();

            return "test";
        }

        public string UpdateAdoProcedure(string FirstName, int id)
        {
            adoProcedureRepository.Update(FirstName, id);

            return "test";
        }

        public string InsertAdoProcedure(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            adoProcedureRepository.Insert(FirstName, LastName, Address, FkOneToTestId);

            return "test";
        }

        public string DeleteAdoProcedure(int id)
        {
            adoProcedureRepository.Delete(id);

            return "test";
        }
    }
}
