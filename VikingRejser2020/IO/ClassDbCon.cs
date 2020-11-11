using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IO
{
    /// <summary>
    /// This class handles communication with the database.
    /// It contains an overloaded constructor which recieves a string with the connectionString
    /// The default constructor creates a connection to a predefined database.
    /// </summary>
    public class ClassDbCon
    {
        /// <summary>
        /// These fields holds values and instances of datatypes which are used in all of classDBCon
        /// </summary>
        private string connectionString;
        protected SqlConnection con;
        private SqlCommand command;

        /// <summary>
        /// Default constructor 
        /// </summary>
        public ClassDbCon()
        {
            connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=FamilyDB;Trusted_Connection=True;";
            con = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Overloaded constructor which enables the creation of a connection to given database
        /// The parameter it recieves contains a string with complete connectionString.
        /// </summary>
        /// <param name="inConnectionString">string</param>
        public ClassDbCon(string inConnectionString)
        {
            connectionString = inConnectionString;
            con = new SqlConnection(connectionString);
        }

        /// <summary>
        /// This method enables the creation of a connection to given database
        /// The parameter it recieves contains a string with complete connectionString.
        /// </summary>
        /// <param name="inConnectionString"></param>
        protected void SetCon(string inConnectionString)
        {
            connectionString = inConnectionString;
            con = new SqlConnection(connectionString);
        }

        /// <summary>
        /// This method opens the connection to the database.
        /// It checks if all condtions are met to open a connection before it opens.
        /// If the conditions are not met it will try to handle the most common errors and missing elements 
        /// </summary>
        protected void OPenDB()
        {
            try
            {
                if (this.con != null && con.State == ConnectionState.Closed) // Checks if the instance con is initialized and that there are isn't already any open connections
                {
                    con.Open(); // OPens the connection to DB
                }
                else  // If the conditions are not met
                {
                    if (con.State == ConnectionState.Open) // Check if erros are caused by an open connection 
                    {
                        //If true - Close the connection and open a new one by calling its own metjod(OpenDB)(Recursive call)
                        CloseDB();
                        OPenDB();
                    }
                    else // If the error is not because of an open connection, it must be because of a missing initialization og con
                    {
                        con = new SqlConnection(connectionString); // Initialize con with 
                        OPenDB(); // Recursive call to open connection
                    }
                }
            }
            catch (SqlException sqlEX) // Handles any exceptions which might arise during communication the the database 
            {

                throw sqlEX;
            }
        }

        /// <summary>
        /// This method closes the connection to DB
        /// </summary>
        protected void CloseDB()
        {
            try
            {
                con.Close(); // Closes the connection
            }
            catch (SqlException sqlEX) // Handles any exceptions which might arise during communication the the database 
            {
                {

                    throw sqlEX;
                }
            }
        }

        /// <summary>
        /// THis method handles actions in the database which do not require a result as return
        /// The method will return a int value which implies if the action was succesful or not
        /// Returns: -1 the action has not been made.
        /// Returns: a number between 0 to N, indicates that the action has been completed succesfully and how many datasets where effected.
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        protected int ExecuteNonQuery(string sqlQuery)
        {
            int res = 0;
            command = new SqlCommand(sqlQuery, con); // Initialize an instance of SqlCommand with the parametres string query and SqlConnection con

            try
            {
                OPenDB(); //Opens the connection to DB
                res = command.ExecuteNonQuery(); // We call the database and the given query is executed 
            }
            catch (SqlException sqlEX) // Handles any exceptions which might arise during communication the the database 
            {
                throw sqlEX;
            }
            finally // Finally secures that no matter what the code in finally is executed.
            {
                CloseDB(); // closes any db connections 
            }

            return res;
        }

        /// <summary>
        /// This method handles request to the database which shall be returned as a dataset.
        /// The resultset which is recieved from the db is converted to collection of the type DataTable 
        /// </summary>
        /// <param name="sqlQuery">string</param>
        /// <returns>DataTable</returns>
        protected DataTable DbReturnDataTable(string sqlQuery)
        {
            DataTable dtRes = new DataTable();

            try
            {
                OPenDB();

                using (command = new SqlCommand(sqlQuery, con)) // New instance of SqlCommand with the parametres string query and SqlConnection con
                {
                    using (var adapter = new SqlDataAdapter(command)) // Here we call the database by making a new instance of SqlDataAdapter. The result is transfered to an abstract datatype var.
                    {
                        adapter.Fill(dtRes); // We transfer data from the abstract datatype to the DataTable that the method ís set to return
                    }
                }
            }
            catch (SqlException sqlEX) // Handles any exceptions which might arise during communication the the database 
            {

                throw sqlEX;
            }
            finally // Finally secures that no matter what the code in finally is executed.
            {
                CloseDB();
            }

            return dtRes;
        }
        /// <summary>
        /// This method handles request to the database which shall be returned as a string
        /// Fx we know the zipcode and only want the cityname, this can be returned as a string and not as an entire dataset
        /// </summary>
        /// <param name="sqlQuery">string</param>
        /// <returns>DataTable</returns>
        protected string DBReturnString(string strSql)
        {
            string res = "";

            try
            {
                OPenDB();
                using (SqlCommand cmd = new SqlCommand(strSql, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        res = reader.GetString(0);

                    }

                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                CloseDB();
            }

            return res;
        }

        protected DataTable MakeCallToStoredProcedure(SqlCommand inCommand)
        {
            DataTable dtRes = new DataTable();

            try
            {
                OPenDB();

                using (var adapter = new SqlDataAdapter(inCommand)) // Here we call the database by making a new instance of SqlDataAdapter. The result is transfered to an abstract datatype var.
                {
                    adapter.Fill(dtRes); // We transfer data from the abstract datatype to the DataTable that the method ís set to return
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                CloseDB();
            }

            return dtRes;
        }
    }
}
