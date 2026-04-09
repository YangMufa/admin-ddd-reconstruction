using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Mint.Infrastructure.Data;Configuration;
using Mint.Infrastructure.Data;Const;
using Mint.Infrastructure.Data;DbContext;
using Mint.Infrastructure.Data;DbSqlSugar;
using Mint.Infrastructure.Data;Enums;
using Mint.Infrastructure.Data;Extensions;

namespace Mint.Infrastructure.Data
{
    public partial class DBServerProvider: DbManger
    {
        private static Dictionary<string, string> ConnectionArray = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private static readonly string DefaultConnName = "defalut";

        static DBServerProvider()
        {
            SetConnection(DefaultConnName, AppSetting.DbConnectionString);
        }
        public static void SetConnection(string key, string val)
        {
            if (ConnectionArray.ContainsKey(key))
            {
                ConnectionArray[key] = val;
                return;
            }
            ConnectionArray.Add(key, val);
        }
        /// <summary>
        /// 设置默认数据库连接
        /// </summary>
        /// <param name="val"></param>
        public static void SetDefaultConnection(string val)
        {
            SetConnection(DefaultConnName, val); 
        }

        public static string GetConnectionString(string key)
        {
            key = key ?? DefaultConnName;
            if (ConnectionArray.ContainsKey(key))
            {
                return ConnectionArray[key];
            }
            return key;
        }
        /// <summary>
        /// 获取默认数据库连接
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return GetConnectionString(DefaultConnName);
        }
        public static VOLContext DbContext
        {
            get { return Utilities.HttpContext.Current.RequestServices.GetService(typeof(VOLContext)) as VOLContext; }
        }
    }
}
