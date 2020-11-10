using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Maintain.Repository
{
    public class Repos
    {
        private readonly IConfiguration config;
        private string dbserver;
        private string dbport;
        private string dbname;
        private string dbusr;
        private string dbpwd;
        private NpgsqlConnection conn;

        public Repos(IConfiguration configuration) {
            config = configuration;
            LoadConfig();
        }
        public void LoadConfig() {
            var mysettings = config.GetSection("ProdSettings");
            dbserver = mysettings.GetSection("DBServer").Value;
            dbport = mysettings.GetSection("DBPort").Value;
            dbname = mysettings.GetSection("DBName").Value;
            dbusr = mysettings.GetSection("DBUsr").Value;
            dbpwd = mysettings.GetSection("DBPwd").Value;
        }
        public void OpenConnection() {
            string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", dbserver, dbport, dbusr, dbpwd, dbname);
            conn = new NpgsqlConnection(connString);
            try {
                conn.Open();
                Debug.WriteLine("Connection opened!!");
            } catch (Exception e) {
                Debug.WriteLine("Exception encountered: connection may have failed");
                throw e;
            }
        }
        public void CloseConnection() {
            try {
                conn.Close();
                Debug.WriteLine("Connection closed!!");
            } catch (Exception e) {
                Debug.WriteLine("Connection failed to close!");
                throw e;
            }
        }

    }
}
