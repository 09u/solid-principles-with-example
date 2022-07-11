using System;

namespace DIP.Bad
{
    public class MySQLConnection
    {
        public MySQLConnection() { }

        public string Connect()
        {
            return "Database connection";
        }
    }

    public class PasswordReminder
    {
        private MySQLConnection _connection;
        public PasswordReminder(MySQLConnection dbConnection)
        {
            this._connection = dbConnection;
        }
    }
}
