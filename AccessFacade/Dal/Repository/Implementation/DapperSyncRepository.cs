using AccessFacade.Configuration;
using AccessFacade.Dal.Repository.Abstraction;
using BpApi.Models;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class DapperSyncRepository : BusinessObject, IDapperSyncRepository
    {
        public readonly AccessFacadeOptions options;

        public DapperSyncRepository(IOptions<AccessFacadeOptions> options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            this.options = options.Value;
        }

        public string InsertTest(DateTime date, string cas)
        {
            string sql = @"INSERT INTO CasoveTesty(Datum, JinyCas) VALUES(@dat, @time)";

            Stopwatch stopwatch = Stopwatch.StartNew();

            using (var connection = new SqlConnection("Data Source=blue.globenet.cz;Initial Catalog=d001420;Integrated Security=False;User ID=d001420a;Password=snbx8DkjUE;Connect Timeout=15;Encrypt=False;Packet Size=4096"))
            {
                var tmp = connection.Execute(sql, new { dat = date, time = cas });
                if (tmp > 0)
                {
                    int a = 3;
                }

                //dom = connection.Query<TestModel>(sql);
            }
            stopwatch.Stop();
            var testStopwatch = stopwatch.Elapsed.ToString();
            return testStopwatch;
        }

        public string Select()
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
            return testStopwatch;
        }

        public string SelectTest()
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
            return testStopwatch;
        }
    }
}
