using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Dijital_Revir
{
    class SqlOps
    {
        public static SqlParameter SqlExecute(string SQLText, string parameterName, SqlConnection sqlConnection)
        {
            if (sqlConnection == null)
                sqlConnection = GetSqlConnection();

            sqlConnection.Open();

            SqlCommand command = new SqlCommand(SQLText, sqlConnection);

            command.CommandTimeout = 60;

            SqlParameter OutParam1 = new SqlParameter("@" + parameterName, SqlDbType.Variant)
            {
                Direction = ParameterDirection.Output
            };

            command.Parameters.Add(OutParam1);

            command.ExecuteNonQuery();

            sqlConnection.Close();

            return OutParam1;
        }

        public static DataTable CreateDataTableBySqlQuery(string sqlText)
        {
            SqlConnection connection = GetSqlConnection();

            SqlCommand cmd = new SqlCommand(sqlText, connection);

            SqlDataAdapter da = new SqlDataAdapter
            {
                SelectCommand = cmd
            };

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable GetDataUsingStoredProcedure(string storedProcedureName, string parameterName, string parameterValue)
        {
            DataTable dt;

            SqlConnection connection = GetSqlConnection();

            SqlDataReader rd;


            SqlCommand cmd = new SqlCommand(storedProcedureName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            /*
            SqlCommand cmd = new SqlCommand(storedProcedureName, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            */


            cmd.Parameters.Add(parameterName, SqlDbType.VarChar).Value = parameterValue;
            connection.Open();
            rd = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            connection.Close();

            return dt;
        }

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = @"Server=.; Database=DijtitalRevir; Trusted_Connection=Yes;";

            return sqlConnection;
        }
        public static int GetDataGridViewRowIndex(DataGridView dgv, string keyColumnName)

        {
            int currentRowIndex = -1;
            if (dgv.SelectedRows.Count >= 1)
            {
                if (dgv.SelectedRows[0] != null)
                {
                    if (dgv.SelectedRows[0].Cells[keyColumnName].Value.ToString() != "")
                    {
                        currentRowIndex = dgv.SelectedRows[0].Index;
                    }
                }
            }
            else
            {
                if (dgv.SelectedCells.Count > 0)
                {
                    if (dgv.SelectedCells[0].Value != null)
                    {
                        if ((dgv.SelectedCells[0].Value.ToString() != ""))
                            currentRowIndex = dgv.SelectedCells[0].RowIndex;
                    }
                }
            }
            return currentRowIndex;
        }
        public static String SqlDateInsert(DateTime Date, String Time)
        {
            String S;
            S = Date.ToString("yyyy.MM.dd") + " " + Time;

            /*
            String sqlText = "Declare @A Varchar(10) = Convert(Varchar,'"+Date.ToString()+"', 102) " +
                "Declare @B Varchar(5) = '" + Time + "'" +
                "Declare @C Varchar(20) = @A + ' ' + @B " +
                "Set @XYZ = Convert(DateTime, @C)";

            String a = SqlExecute(sqlText, "XYZ", GetSqlConnection()).Value.ToString();
            return a;
            */

            return S;
        }

        public static void SqlDatagridUpdate(String sqlText, DataGridView dgv)
        {
            DataTable dt;

            dt = SqlOps.CreateDataTableBySqlQuery(sqlText);
            dgv.DataSource = dt;
        }
    
        public static void SetParam(String sqlText, SqlParameter prm)
        {
            SqlCommand cmd = new SqlCommand(sqlText, SqlOps.GetSqlConnection());
            cmd.Connection.Open();

            cmd.Parameters.Add(prm);
            cmd.ExecuteReader();

            cmd.Connection.Close();
        }
    }
}
