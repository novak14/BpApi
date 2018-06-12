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

namespace BpApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly AccessFacadeService accessFacadeService;
        private readonly DapperService dapperService;


        public ValuesController(AccessFacadeService accessFacadeService, DapperService dapperService)
        {
            this.accessFacadeService = accessFacadeService;
            this.dapperService = dapperService;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return accessFacadeService.SelectDapperSync() + dapperService.SelectTest();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return accessFacadeService.SelectTest();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
