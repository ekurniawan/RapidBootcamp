using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBootcamp.ConsoleApp.Domain
{
    public class Student : Person
    {
        public string? Nim { get; set; }
        public double IPK { get; set; }

        public double GetIPK()
        {
            return IPK;
        }
    }
}
