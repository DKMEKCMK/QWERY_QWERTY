using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    public class DB
    {
        public static string Users_ID = "null", Password = "null", App_Name = "Администратор";
        public static string ConnectionStrig = "Data Source=LAPTOP-2P7IG7OI\\MYSERVERNAME;Initial Catalog=Hotel_Complex;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(ConnectionStrig);

        private SqlCommand command = new SqlCommand();
        public DataTable resultTable = new DataTable();
        public SqlDependency dependency = new SqlDependency();
        public enum act { select, manipulation };
        public void sqlExecute(string quety, act act)
        {
            command.Connection = connection;
            command.CommandText = quety;
            command.Notification = null;
            switch (act)
            {
                case act.select:
                    dependency.AddCommandDependency(command);
                    SqlDependency.Start(connection.ConnectionString);
                    connection.Open();
                    resultTable.Load(command.ExecuteReader());
                    connection.Close();
                    break;
                case act.manipulation:
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    break;
            }
        }
    }
}
