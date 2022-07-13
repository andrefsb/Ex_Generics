using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    internal class Terms
    {
        public string Term { get; set; }
        public string Description { get; set; }

        public Terms(string term, string description)
        {
            Term = term;
            Description = description;
        }
    }
}
