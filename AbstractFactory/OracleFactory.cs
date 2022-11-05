using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class OracleFactory : DBFactory
    {
        //Fábrica Concreta (Concret Factory)
        public override DBCommand createCommand()
        {
            return new OracleCommand();
        }

        public override DBConnection createConnection()
        {
            return new OracleConnection();
        }


    }
}
