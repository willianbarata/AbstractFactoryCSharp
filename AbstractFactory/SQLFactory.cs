using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SQLFactory : DBFactory
    {
        //Fábrica Concreta (Concret Factory)
        public override DBCommand createCommand()
        {
            return new SQLCommand();
        }

        public override DBConnection createConnection()
        {
            return new SQLConnection();
        }

        
    }
}
