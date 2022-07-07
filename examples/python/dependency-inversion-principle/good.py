import abc

class DBConnectionInterface(metaclass=abc.ABCMeta):
    def connect(self)->str:
        raise NotImplementedError

class MySQLConnection(DBConnectionInterface):
    def connect(self):
        # handle the database connection
        return 'MySQL Database connection'

class MSSQLConnection(DBConnectionInterface):
    def connect(self):
        # handle the database connection
        return 'MSSQL Database connection'

class PasswordReminder:
    def __init__(self, dbConnection: DBConnectionInterface):
        self.dbConnection = dbConnection


'''
Here is an example of a PasswordReminder that connects to a MySQL database:

'''
conn = MySQLConnection()
myPassReminder = PasswordReminder(conn)
print(conn.connect())


conn2 = MSSQLConnection()
msPassReminder = PasswordReminder(conn2)
print(conn2.connect())