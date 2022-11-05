using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class OracleConnection : DBConnection
    {
        //Produto Abstrato (Abstract Product)
        public override void Open()
        {
            Console.WriteLine("Método Open de OracleConnection foi chamado");
        }
    }
}