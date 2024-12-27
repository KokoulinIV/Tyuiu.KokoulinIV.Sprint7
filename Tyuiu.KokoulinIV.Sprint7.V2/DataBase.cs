using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Tyuiu.KokoulinIV.Sprint7.V2
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-QIH0BBU;Database=DESKTOP-QIH0BBU;User Id=wolf;Password=64Vasoho;Initial Catalog=test");
        //Data Source=DESKTOP-QIH0BBU;Initial Catalog=test;Integrated Security=True

        public void openConnectiion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnectiion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }


    }
}
