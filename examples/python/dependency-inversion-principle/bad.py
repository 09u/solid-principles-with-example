class MySQLConnection:
    def connect(self):
        return 'Database connection'

class PasswordReminder:
    def __init__(self, dbConnection: MySQLConnection):
        self.dbConnection = dbConnection


'''
Here is an example of a PasswordReminder that connects to a MySQL database:

'''
conn = MySQLConnection()

passReminder = PasswordReminder(conn)

print(conn.connect())
