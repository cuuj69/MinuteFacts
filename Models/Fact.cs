using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinuteFacts.Models
{
    public class Fact
    {
        public int Id { get; set; }

        public string FactQuestion { get; set; }

        public string FactAnswer { get; set; }

        public Fact()
        {

        }

    }
}
