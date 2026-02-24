using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Class
{
    internal class Ticket
    {
        private static int _counter = 0;
        public string? _movieName { get; set; }
        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public int TicketId { get; }

        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            _movieName = movieName;
            Price = price;
            TicketId = _counter++;
        }

        public static int GetTotalTickets()
        {
            return _counter;
        }

        public override string ToString()
        {
            return $"MovieName: {_movieName} | Price: {Price} | TicketId: {TicketId}";
        }
    }
}
