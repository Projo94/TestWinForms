using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForms.Helper
{
    internal static class SqlDataReaderExtensions
    {

        internal static string GetStringNullable(
          this NpgsqlDataReader dr,
          string colName)
        {
            return dr[colName] == DBNull.Value ? null : dr[colName].ToString();
        }


        internal static bool GetBoolNullable(
        this NpgsqlDataReader dr,
        string colName)
        {
            //return dr[colName] == DBNull.Value ? null : Convert.ToBoolean(dr[colName]);
            return Convert.ToBoolean(dr[colName]);


        }
    }
}
