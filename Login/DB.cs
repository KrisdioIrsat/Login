using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

public class DB
{
    DataSet ds;

    public DB()
    {
        ds = new DataSet();
    }

    /// <summary>
    /// This Method Will Return only one column and one row
    /// </summary>
    /// <param name="Query"></param>
    /// <returns></returns>

    public string QueryScalar(string Query)
    {
        string str;
        MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        MySqlCommand mySqlCommand = new MySqlCommand(Query,mySqlConnection);
        mySqlConnection.Open();
        try
        {
            try
            {
                str = mySqlCommand.ExecuteScalar().ToString();
            }
            finally
            {
                mySqlCommand.Dispose();
                mySqlConnection.Close();
                mySqlConnection.Dispose();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return str;
    }
}