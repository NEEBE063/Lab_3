using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bicycle
    {
        public string Model;
        public string Frame;
        public int Broadcast;
        public string Fork;
        public string Handlebars;
        public bool Ring;
        public bool Has3Wheels;

        public int Cost()
        {
            return Broadcast * 1 / 2 * 100;
        }

        public int Value
        {
            get { return Cost(); }
            set { }
        }
    }
}
