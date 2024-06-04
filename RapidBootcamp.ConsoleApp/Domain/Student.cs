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
        public Student()
        {

        }

        public Student(string fullname, string address, string phonenumber, string nim, double ipk)
            : base(fullname, address, phonenumber)
        {
            this.Nim = nim;
            this.IPK = ipk;
        }

        public string? Nim { get; set; }
        public double IPK { get; set; }

        public double GetIPK()
        {
            return IPK;
        }

        public override string GetInfo()
        {
            return $"Name: {FullName}, Address: {Address}, Phone: {PhoneNumber}, Nim: {Nim}, IPK: {IPK}";
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override string GetFullName()
        {
            throw new NotImplementedException();
        }
    }
}
