using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Class
{
    internal class IMAXTicket : Ticket
    {
        public bool _Is3D { get; set; }

        public IMAXTicket(bool Is3D, string movieName, decimal price) : base(movieName, Is3D ? price + 30 : price)
        {
            _Is3D = Is3D;
        }
        public override string ToString()
        {
            return $"{_Is3D} | {_movieName} | {Price} | {PriceAfterTax} | {TicketId}";
        }
    }
}
