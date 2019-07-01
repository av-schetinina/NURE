using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace TimeToDoIt // сюда имя проекта которое указывали при создании (посмотреть можно в самой начальной форме в таком же месте)
{
    public class ClassDataBase
    {

        #region ExecuteNonQuery
        public int ExecuteNonQuery(ref ClassSetupProgram setupProgram, string sSql)
        {
            int n = 0;
            try
            {
                using (OracleConnection con = new OracleConnection(setupProgram.connectionToDBString))
                {
                    con.Open();

                    using (OracleCommand oracleCommand = con.CreateCommand())
                    {
                        oracleCommand.CommandText = sSql;
                        n = oracleCommand.ExecuteNonQuery();
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                n = 0;
            }
            return n;
        }
        #endregion

        #region Execute

        protected T GetObject<T>(params object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }

        public void Execute<T>(ref ClassSetupProgram setupProgram, string sSql, ref List<T> listResult)
        {
            string result = "";
            try
            {
                string databaseName = setupProgram.connectionToDBString;
                OracleConnection con = new OracleConnection(setupProgram.connectionToDBString);
                con.Open();

                OracleCommand command = new OracleCommand();
                command.Connection = con;
                command.CommandText = sSql;
                command.CommandType = CommandType.Text;
                OracleDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        result = "";
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            result += Convert.ToString(dataReader.GetValue(i)) + "!";
                        }
                        if (result.Count() > 2) result = result.Remove(result.Count() - 1);
                        if (result != "") listResult.Add(GetObject<T>(result));
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
              
            }
        }
        #endregion

    }
}
