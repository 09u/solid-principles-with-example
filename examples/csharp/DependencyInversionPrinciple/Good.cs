using System;

namespace DIP.Good
{
    public interface IDBConnection
    {
        string Connect();
    }

    public class MySQLConnection: IDBConnection
    {
        private string _name;
        public MySQLConnection() { 
            this._name = "MySQL";
        }

        public string Connect()
        {
            return String.Format("{0} Database connection", this._name);
        }
    }

    public class MSSQLConnection: IDBConnection
    {
        private string _name;
        public MSSQLConnection() {
            this._name = "MSSQL";
         }

        public string Connect()
        {
            return String.Format("{0} Database connection", this._name);
        }
    }


    public class PasswordReminder
    {
        private IDBConnection _connection;
        public PasswordReminder(IDBConnection dbConnection)
        {
            this._connection = dbConnection;
        }
    }
}
