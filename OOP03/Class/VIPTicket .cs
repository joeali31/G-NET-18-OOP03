using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Class
{
    internal class VIPTicket : Ticket
    {
        public bool _LoungeAccess { get; set; }

        public VIPTicket(bool LoungeAccess, string movieName, decimal price) : base(movieName, price + 50)
        {
            _LoungeAccess = LoungeAccess;
        }

        public override string ToString()
        {
            return $"{_LoungeAccess} | {_movieName} | {Price} | {PriceAfterTax} | {TicketId}";
        }
    }
}
