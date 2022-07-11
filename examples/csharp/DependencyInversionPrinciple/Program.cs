/**
Here is an example of a PasswordReminder that connects to a MySQL database:
**/

// bad flow
Console.WriteLine("Bad Flow");

var conn = new  DIP.Bad.MySQLConnection();
var passReminder = new DIP.Bad.PasswordReminder(conn); 

Console.WriteLine(conn.Connect());


// good flow
Console.WriteLine("Good Flow");

var conn1 = new  DIP.Good.MySQLConnection();
var passReminder1 = new DIP.Good.PasswordReminder(conn1); 

Console.WriteLine(conn1.Connect());

var conn2 = new  DIP.Good.MSSQLConnection();
var passReminder2 = new DIP.Good.PasswordReminder(conn2); 

Console.WriteLine(conn2.Connect());
