using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace project_programming_2
{
    public static class DataBaseHelper
    {
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\project_programming_2\project_programming_2\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
