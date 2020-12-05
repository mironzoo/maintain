using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
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
        private SqlConnection conn;

        public Repos(IConfiguration configuration) {
            config = configuration;
            LoadConfig();
        }
        public SqlConnection getConn() { return conn; }
        public void LoadConfig() {
            var mysettings = config.GetSection("ProdSettings");
            dbserver = mysettings.GetSection("DBServer").Value;
            dbport = mysettings.GetSection("DBPort").Value;
            dbname = mysettings.GetSection("DBName").Value;
            dbusr = mysettings.GetSection("DBUsr").Value;
            dbpwd = mysettings.GetSection("DBPwd").Value;
        }
        public bool OpenConnection() {
            Debug.WriteLine(dbserver + "====================== DB SERVER");
            string connString = String.Format("Server=tcp:{0},{1};Persist Security Info=False;User ID={2};Password={3};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Initial Catalog={4};", dbserver, dbport, dbusr, dbpwd, dbname);
            conn = new SqlConnection(connString);
            int retries = 0;
            while (retries++ < 3) {
                try {
                    conn.Open();
                    Debug.WriteLine("Connection opened!!");
                    return true;
                } catch (Exception e) {
                    Debug.WriteLine("Exception encountered: connection may have failed!");
                    throw e;
                }
            }
            return false;
        }
        public bool CloseConnection() {
            try {
                conn.Close();
                Debug.WriteLine("Connection closed!!");
                return true;
            } catch (Exception e) {
                Debug.WriteLine("Connection failed to close!");
                throw e;
            }
        }

    }
}
