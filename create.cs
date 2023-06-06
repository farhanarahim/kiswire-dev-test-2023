namespace Namespace {
    
    using mysql.connector;
    
    public static class Module {
        
        public static object mydb = mysql.connector.connect(host: "localhost", database: "oms_kiswire", user: "root", password: "Your_pass");
        
        public static object cs = mydb.cursor();
        
        public static object statement = "INSERT INTO tblorders( Item, Customer,Price, Date)\
VALUES('Book','Farhana', 33,'060623')";
        
        static Module() {
            cs.execute(statement);
            mydb.commit();
        }
    }
}