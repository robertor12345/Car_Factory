using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Client
    {

        public static void Main(string args)
        {
            Human roberto = new Human();

            roberto.WakeUpHuman();
        }
    }
}
