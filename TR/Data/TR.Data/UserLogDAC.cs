//====================================================================================================
// Base code generated with Momentum: DAC Gen (Build 3.0.5701.25371)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by es.cheah at ENGSOON on 11/10/2016 14:12:51 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using TR.Entities;

namespace TR.Data
{
    /// <summary>
    /// UserLog data access component. Manages CRUD operations for the UserLog table.
    /// </summary>
    public partial class UserLogDAC : DataAccessComponent
    {
        /// <summary>
        /// Conditionally retrieves one or more rows from the UserLog table.
        /// </summary>
        /// <param name="tRequestID">A tRequestID value.</param>
        /// <returns>A collection of UserLog objects.</returns>		
        public List<UserLog> Select(string tRequestID)
        {
            const string SQL_STATEMENT =
                "SELECT [UserLogID], [TRequestID], [RequestStatus], [SubmitDate] " +
                "FROM dbo.UserLog " +
                "WHERE [TRequestID]=@TRequestID ";

            List<UserLog> result = new List<UserLog>();

            // Connect to database.
            var db = new SqlDatabase(base.ConnectionString);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@TRequestID", DbType.String, tRequestID);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new UserLog
                        UserLog userLog = new UserLog();

                        // Read values.
                        userLog.UserLogID = GetDataValue<string>(dr, "UserLogID");
                        userLog.TRequestID = GetDataValue<string>(dr, "TRequestID");
                        userLog.RequestStatus = GetDataValue<string>(dr, "RequestStatus");
                        userLog.SubmitDate = GetDataValue<DateTime>(dr, "SubmitDate");

                        // Add to List.
                        result.Add(userLog);
                    }
                }
            }

            return result;
        }
    }
}

