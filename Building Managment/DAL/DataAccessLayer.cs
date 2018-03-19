using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Building_Managment.DAL
{
    class DataAccessLayer
    {
    public   SqlConnection sqlconnection;
    public static string Constr = string.Empty;

    string Servername = Properties.Settings.Default.ServerName;
    public string DataBase = Properties.Settings.Default.DataBase;
    string mode = Properties.Settings.Default.Mode;
    string id = Properties.Settings.Default.UserId;
    string pass = Properties.Settings.Default.Password;
        //This Constructor Inisialize the connection object
        public DataAccessLayer()
        {


            //sqlconnection = new SqlConnection("Data Source=Server;Initial Catalog=PropertyDB;Persist Security Info=True;User ID=Property;Password=0922792724");

            sqlconnection = new SqlConnection(@"Server=" + Servername + ";  Initial Catalog =" + DataBase + "; Integrated Security=false; User ID=" + id + " ; Password=" + pass + "");


            sqlconnection = new SqlConnection(Constr);
        }



        //Method to open the connection 
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                 sqlconnection.Open();
            }
        }

        //Method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Method To Read Data From Database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param  )
        {
            SqlCommand sqlcmd = new SqlCommand();
            //sqlcmd.Connection = sqlconnection = new SqlConnection("Data Source=sql5034.site4now.net;Initial Catalog=DB_A19A11_DonationDB;User ID=DB_A19A11_DonationDB_admin;Password=0922792724Don");
            sqlconnection.Open();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;

            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                    sqlconnection.Close();

                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
           
            da.Fill(dt);
            return dt;
        }

        //Method to Insert, Update, and Delete Data From Database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            //sqlcmd.Connection = sqlconnection = new SqlConnection("Data Source=sql5034.site4now.net;Initial Catalog=DB_A19A11_DonationDB;User ID=DB_A19A11_DonationDB_admin;Password=0922792724Don");
            sqlconnection.Open();
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
            sqlconnection.Close();

        }
    }

}
