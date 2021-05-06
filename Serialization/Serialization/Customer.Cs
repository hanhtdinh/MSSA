using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serialization
{
    [Serializable] //makes the class serializable, do not forget this keyword
    //automatically makes all the stuff in the class serializable too
    class Customer
    {
        public string Name { get; set; } //auto properties for customer class
        public int partySize { get; set; }
        public string seatLocation { get; set; }

        
    }
}
