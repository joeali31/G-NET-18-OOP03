using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Class
{
    internal class Cinema
    {
        public string _CinemaName { get; set; }
        private Projector _projector;
        private Ticket[] _tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index < _tickets.Length)
                {
                    return _tickets[index];
                }
                return null;
            }

            set
            {
                if (index >= 0 && index < _tickets.Length)
                {
                    _tickets[index] = value;
                }
            }
        }

        public Cinema(string CinemaName)
        {
            _CinemaName = CinemaName;
            _projector = new Projector();
        }

        public void OpenCinema()
        {
            Console.WriteLine($"Cinema {_CinemaName} is now OPEN.");
            _projector.Start();
        }

        public void CloseCinema()
        {
            _projector.Stop();
            Console.WriteLine($"Cinema {_CinemaName} is now CLOSED.");
        }

        public void AddTicket(Ticket ticket)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = ticket;
                    return;
                }
            }

            Console.WriteLine("Cinema is full, cannot add more tickets.");
        }
    }
}
