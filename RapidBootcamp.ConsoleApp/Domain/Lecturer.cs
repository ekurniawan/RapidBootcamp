using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBootcamp.ConsoleApp.Domain
{
    public class Lecturer : Person
    {
        public string? NIK { get; set; }
        public string? RoomNumber { get; set; }

        public override string GetFullName()
        {
            throw new NotImplementedException();
        }

        public override string GetInfo()
        {
            return $"Name: {FullName}, Address: {Address}, Phone: {PhoneNumber}, NIK: {NIK}, Room Number: {RoomNumber}";
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}

