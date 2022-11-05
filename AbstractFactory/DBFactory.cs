using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class DBFactory
    {
        public abstract DBConnection createConnection();
        public abstract DBCommand createCommand();
    }
}
