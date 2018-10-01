using AccessFacade.Configuration;
using AccessFacade.Dal.Entities;
using AccessFacade.Dal.Repository.Abstraction;
using BpApi.Models;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class DapperSyncRepository : IDapperSyncRepository
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

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public string Insert()
        {
            throw new NotImplementedException();
        }

        public string InsertTest(DateTime date, string cas)
        {
            string sql = @"INSERT INTO CasoveTesty(Datum, JinyCas) VALUES(@dat, @time)";

            Stopwatch stopwatch = Stopwatch.StartNew();

            using (var connection = new SqlConnection(options.connectionString))
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
            //#region normalSelect
            //string sql = @"SELECT * FROM UserTest";

            //Stopwatch stopwatch = Stopwatch.StartNew();

            //using (var connection = new SqlConnection(options.connectionString))
            //{
            //    var tmp = connection.Query<UserTest>(sql);
            //}
            //stopwatch.Stop();
            //var testStopwatch = stopwatch.Elapsed.ToString();
            //#endregion

            #region oneToMany
            string sqlOneToMany = @"SELECT * FROM UserTest INNER JOIN OneToTest ON OneToTest.Id = UserTest.FkOneToTestId";


            using (var connection = new SqlConnection(options.connectionString))
            {
                var tmp = connection.Query<UserTest, OneToTest, UserTest>(sqlOneToMany, 
                    (userTest, oneToTest) =>
                    {
                        userTest.OneToTest = oneToTest;
                        return userTest;
                    }).ToList();
            }

            #endregion
            return "ahoj";
        }

        public string SelectTest()
        {
            string sql = @"SELECT * FROM UserDetails";

            Stopwatch stopwatch = Stopwatch.StartNew();

            using (var connection = new SqlConnection(options.connectionString))
            {
                var tmp = connection.Query<UserInformation>(sql);
                //dom = connection.Query<TestModel>(sql);
            }
            stopwatch.Stop();
            var testStopwatch = stopwatch.Elapsed.ToString();
            return testStopwatch;
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}
