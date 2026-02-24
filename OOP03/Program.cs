using OOP03.Class;
using System.Net.Sockets;

namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // a => Composition
            // b => Association
            // c => Inheritance
            // d => Aggregation
            // e => Dependency
            #endregion


            #region Question02
            /* A
             * Can a child class in a different assembly access it? Yes, if it inherits from the parent class.
             * Can it be accessed through an object instance from outside? no
             * Are accessible only inside the class and its subclasses
             * Not accessible through an object reference from outside
             */

            /* B
             * private protected — Accessible in the containing class OR derived classes in the same assembly only
             * protected internal — Accessible anywhere in the same assembly (like internal) OR in derived classes in other assemblies (like protected)
             */

            /* C
             * What does sealed do? Prevents inheritance
             */

            /* D
             *  Can you create an object from a sealed class using new? Why or why not? Yes, you can.
             * sealed only prevents inheritance
             * It does not prevent instantiation
             */
            #endregion

            #region Part 02 : Practical (Extending the Movie Ticket Booking System)
            //Cinema cinema = new Cinema("Galaxy Cinema");
            //Console.WriteLine();

            //cinema.OpenCinema();

            //Ticket t1 = new StandardTicket("A1", "inception", 300);
            //Ticket t2 = new VIPTicket(true, "dark", 200);
            //Ticket t3 = new IMAXTicket(true, "it", 150);

            //Console.WriteLine();
            //Console.WriteLine(t1);
            //Console.WriteLine();
            //Console.WriteLine(t2);
            //Console.WriteLine();
            //Console.WriteLine(t3);

            //cinema.AddTicket(t1);
            //cinema.AddTicket(t2);
            //cinema.AddTicket(t3);

            //cinema.CloseCinema();
            #endregion
        }
    }
}
