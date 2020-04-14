using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ODP namespace
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AttendanceSystem
{
    

    class ODPLayer
    {
        private user unknown;
        string connectionString = "Data source=orcl;" +
                      "User Id=hr;" +
                     " Password=hr;";
        OracleConnection connection ;
       public ODPLayer()
        {
            connection = new OracleConnection(connectionString);
            connection.Open();
        }
        public void end() {
            connection.Dispose();
        }
        public Boolean login(string name,string password) {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "LOGIN";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("username",name);
            command.Parameters.Add("password",password);
            command.Parameters.Add("type",OracleDbType.Varchar2,ParameterDirection.Output);
            command.Parameters.Add("id",OracleDbType.Int32, ParameterDirection.Output);
            OracleDataReader odr = command.ExecuteReader();
            odr.Read();

            if (odr[0].Equals("faild"))
            {
                odr.Close();
                return false;
            }
            else
            {
                odr.Close();
                return true;
            }

        }
        public void Register(string name, string password,string email,int classNum)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "REGISTERP";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("name", name);
            command.Parameters.Add("password", password);
            command.Parameters.Add("email", email);
            command.Parameters.Add("classNumber", classNum);
            command.ExecuteNonQuery();
        }
        public user getUser() {
            return unknown;
        }
    }
}
