using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BpApi.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace BpApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string sql = @"SELECT * FROM UserDetails";

            Stopwatch stopwatch = Stopwatch.StartNew();

            using (var connection = new SqlConnection("Data Source=blue.globenet.cz;Initial Catalog=d001420;Integrated Security=False;User ID=d001420a;Password=snbx8DkjUE;Connect Timeout=15;Encrypt=False;Packet Size=4096"))
            {
                var tmp = connection.Query<UserInformation>(sql);
                //dom = connection.Query<TestModel>(sql);
            }
            stopwatch.Stop();
            var testStopwatch = stopwatch.Elapsed.ToString();
            return new string[] { testStopwatch, "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
