using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Ticket
    {
        public  decimal Cost { get; protected set; }
        public enum Types { Cooper, Silver, Gold }

        private Types _type;
        public Ticket(decimal cost,Types type)
        {
            Cost = cost;
            _type = type;
        }

        //or internal classes
    }
}
