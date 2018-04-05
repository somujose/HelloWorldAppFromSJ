
using System;
using System.Data.SqlClient;

namespace HelloWorldModel.Model
{
    public sealed class WebAPIApplication : ApplicationBase
    {

        private readonly string _connectionString;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationDecription"></param>
        internal WebAPIApplication(string applicationDecription) : base(applicationDecription)
        {
            // reteriving connection string from Resource file...
            // Storing it in web config/App config is an alternative way.
            _connectionString = Properties.Resources.connectionString;
        }

        //Web Api override this method to save information to database
        // just structure code not implemented
        public override void SaveInformation(string message)
        {
            // As connection string value is not valid, for a safer side catching the exception, if occurs
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    //Implement Saving hello world message to sql server  database 
                }
            }
            catch (Exception)
            {
            }
           
        }
    }
}
