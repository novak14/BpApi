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
            for (int i = 0; i < 1000; i++)
            {
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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            #region Sync
            string dapperSync = dapperService.UpdateDapperSync();
            string adoSync = adoService.UpdateAdoSync();
            string efCoreSync = eFCoreService.UpdateEFCoreSync();
            #endregion

            #region Asynchronous
            //string dapperASync = dapperService.UpdateDapperASync();
            //string adoAsync = adoService.UpdateAdoASync();
            //string efCoreAsync = eFCoreService.UpdateEFCoreASync();
            #endregion

            #region Procedures
            //string dapperProcedure = dapperService.UpdateDapperProcedure();
            //string adoProcedure = adoService.UpdateAdoProcedure();
            //string efCoreProcedure = eFCoreService.UpdateEFCoreProcedure();
            #endregion
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            #region Sync
            string dapperSync = dapperService.DeleteDapperSync();
            string adoSync = adoService.DeleteAdoSync();
            string efCoreSync = eFCoreService.DeleteEFCoreSync();
            #endregion

            #region Asynchronous
            string dapperASync = dapperService.DeleteDapperASync();
            string adoAsync = adoService.DeleteAdoASync();
            string efCoreAsync = eFCoreService.DeleteEFCoreASync();
            #endregion

            #region Procedures
            string dapperProcedure = dapperService.DeleteDapperProcedure();
            string adoProcedure = adoService.DeleteAdoProcedure();
            string efCoreProcedure = eFCoreService.DeleteEFCoreProcedure();
            #endregion
        }
    }
}
