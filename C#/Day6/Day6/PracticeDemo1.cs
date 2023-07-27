using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class PracticeDemo1
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket(900);
            ticket.ShowInfo();
        }
    }
}
