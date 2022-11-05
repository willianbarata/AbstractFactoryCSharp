using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBFactory db = new OracleFactory();
            var con = db.createConnection();
            con.Open();
            var cmd = db.createCommand();
            cmd.Execute();
            Console.ReadLine();
        }
    }
}
