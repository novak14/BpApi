﻿using AccessFacade.Configuration;
using AccessFacade.Dal.Entities;
using AccessFacade.Dal.Repository.Abstraction;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AccessFacade.Dal.Repository.Implementation
{
    public class AdoSyncRepository : IAdoSyncRepository
    {
        public readonly AccessFacadeOptions options;

        public AdoSyncRepository(IOptions<AccessFacadeOptions> options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            this.options = options.Value;
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert(string FirstName, string LastName, string Address, int FkOneToTestId)
        {
            string query = @"INSERT INTO UserTestInsert(FirstName, LastName, Address, FkOneToTestId) VALUES(@FirstName, @LastName, @Address, @FkOneToTestId)";
            using (SqlConnection connection = new SqlConnection(options.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = LastName;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = Address;
                    command.Parameters.Add("@FkOneToTestId", SqlDbType.Int).Value = FkOneToTestId;

                    connection.Open();
                    var affRows = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex));
                }
            }
        }

        public void Select()
        {
            #region normalSelect
            string query = "SELECT * FROM UserTest";
            List<UserTest> userTests = new List<UserTest>();

            using (SqlConnection connection = new SqlConnection(options.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UserTest userTest = new UserTest();

                        userTest.Id = (int)reader["Id"];
                        userTest.FirstName = reader["FirstName"] as string;
                        userTest.LastName = reader["LastName"] as string;
                        userTest.Address = reader["Address"] as string;
                        userTest.FkOneToTestId = (int)reader["FkOneToTestId"];

                        userTests.Add(userTest);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            #endregion
            #region oneToMany
            //string queryOneToMany = "SELECT * FROM UserTest INNER JOIN OneToTest ON OneToTest.Id = UserTest.FkOneToTestId";

            //List<UserTest> userTests = new List<UserTest>();

            //using (SqlConnection connection = new SqlConnection(options.connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryOneToMany, connection);
            //    try
            //    {
            //        connection.Open();
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            UserTest userTest = new UserTest();

            //            userTest.Id = (int)reader["Id"];
            //            userTest.FirstName = reader["FirstName"] as string;
            //            userTest.LastName = reader["LastName"] as string;
            //            userTest.Address = reader["Address"] as string;
            //            userTest.FkOneToTestId = (int)reader["FkOneToTestId"];

            //            userTest.OneToTest = new OneToTest();
            //            userTest.OneToTest.Id = userTest.FkOneToTestId;
            //            userTest.OneToTest.Name = reader["Name"] as string;
            //            userTest.OneToTest.Age = (int)reader["Age"];
            //            userTests.Add(userTest);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception(ex.ToString());
            //    }
            //}
            #endregion
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
