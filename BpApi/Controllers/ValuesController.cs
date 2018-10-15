using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AccessFacade.Business;
using BpApi.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using RandomNameGeneratorLibrary;

namespace BpApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly AccessFacadeService accessFacadeService;
        private readonly DapperService dapperService;
        private readonly AdoService adoService;
        private readonly EFCoreService eFCoreService;


        public ValuesController(
            AccessFacadeService accessFacadeService, 
            DapperService dapperService,
            AdoService adoService,
            EFCoreService eFCoreService)
        {
            this.accessFacadeService = accessFacadeService;
            this.dapperService = dapperService;
            this.adoService = adoService;
            this.eFCoreService = eFCoreService;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            #region Sync
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i <= 2000; i++)
            {
                Random random = new Random();
                var test = accessFacadeService.InsertDapperSync(random.GenerateRandomFirstName(), i);

                //string adoSync = adoService.SelectAdoSync();
                //string dapperSync = dapperService.SelectDapperSync();
                //string efCoreSync = eFCoreService.SelectEFCoreSync();
            }
            stopwatch.Stop();
            //string adoSync = adoService.SelectAdoSync();
            //string efCoreSync = eFCoreService.SelectEFCoreSync();
            #endregion

            #region Asynchronous
            //string dapperASync = dapperService.SelectDapperASync();
            //string adoAsync = adoService.SelectAdoASync();
            //string efCoreAsync = eFCoreService.SelectEFCoreASync();
            #endregion

            #region Procedures
            //string dapperProcedure = dapperService.SelectDapperProcedure();
            //string adoProcedure = adoService.SelectAdoProcedure();
            //string efCoreProcedure = eFCoreService.SelectEFCoreProcedure();
            #endregion

            //string time = accessFacadeService.SelectDapperSync();
            //Put(1, time);
            return stopwatch.Elapsed.ToString();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return dapperService.SelectDapperSync();
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            ModelUserTest modelUser = new ModelUserTest();
            for (int i = 0; i < 1000; i++)
            {
                ModelUserTest modelUserTest = new ModelUserTest();
                modelUser.userTestCollection.collections.Add(modelUserTest);
            }
            #region Sync

            //foreach (var item in modelUser.userTestCollection.collections)
            //{
            //    //string dapperSync = dapperService.InsertDapperSync(item.FirstName, item.LastName,item.Address,item.FkOneToTestId);
            //    //string adoSync = adoService.InsertAdoSync(item.FirstName, item.LastName, item.Address, item.FkOneToTestId);
            //    //string efCoreSync = eFCoreService.InsertEFCoreSync(item.FirstName, item.LastName, item.Address, item.FkOneToTestId);
            //}
            #endregion

            #region Asynchronous
            //string dapperASync = dapperService.InsertDapperASync();
            //string adoAsync = adoService.InsertAdoASync();
            //string efCoreAsync = eFCoreService.InsertEFCoreASync();
            #endregion

            #region Procedures
            foreach (var item in modelUser.userTestCollection.collections)
            {
                //string dapperProcedure = dapperService.InsertDapperProcedure(item.FirstName, item.LastName, item.Address, item.FkOneToTestId);
                //string adoProcedure = adoService.InsertAdoProcedure(item.FirstName, item.LastName, item.Address, item.FkOneToTestId);
                //string efCoreProcedure = eFCoreService.InsertEFCoreProcedure(item.FirstName, item.LastName, item.Address, item.FkOneToTestId);
            }
            #endregion
        }

        // PUT api/values/5
        [HttpPut()]
        public void Put()
        {
            Random random = new Random();
            #region Sync

            for (int i = 0; i < 1000; i ++)
            {
                var firstName = random.GenerateRandomFirstName();
                //string dapperSync = dapperService.UpdateDapperSync(firstName, id);
                //string adoSync = adoService.UpdateAdoSync(firstName, id);
                //string efCoreSync = eFCoreService.UpdateEFCoreSync(firstName, i);
            }
            #endregion


            #region Asynchronous
            //string dapperASync = dapperService.UpdateDapperASync();
            //string adoAsync = adoService.UpdateAdoASync();
            //string efCoreAsync = eFCoreService.UpdateEFCoreASync();
            #endregion

            #region Procedures
            for (int i = 0; i < 1000; i++)
            {
                var firstName = random.GenerateRandomFirstName();
                //string dapperProcedure = dapperService.UpdateDapperProcedure(firstName, i);
                //string adoProcedure = adoService.UpdateAdoProcedure(firstName, i);
                //string efCoreProcedure = eFCoreService.UpdateEFCoreProcedure(firstName, i);
            }
            #endregion
        }

        // DELETE api/values/5
        [HttpDelete()]
        public void Delete()
        {
            Random random = new Random();

            #region Sync
            for (int i = 1; i <= 2000; i ++)
            {
                //string dapperSync = dapperService.DeleteDapperSync(i);
                //string adoSync = adoService.DeleteAdoSync(i);
                //string efCoreSync = eFCoreService.DeleteEFCoreSync(i);
            }
            #endregion

            #region Asynchronous
            //string dapperASync = dapperService.DeleteDapperASync();
            //string adoAsync = adoService.DeleteAdoASync();
            //string efCoreAsync = eFCoreService.DeleteEFCoreASync();
            #endregion

            #region Procedures
            for (int i = 1; i <= 2000; i ++)
            {
                //string dapperProcedure = dapperService.DeleteDapperProcedure(i);
                //string adoProcedure = adoService.DeleteAdoProcedure(i);
                //string efCoreProcedure = eFCoreService.DeleteEFCoreProcedure(i);
            }
            #endregion
        }
    }
}
