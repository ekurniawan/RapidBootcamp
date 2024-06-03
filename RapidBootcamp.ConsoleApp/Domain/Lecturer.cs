using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBootcamp.ConsoleApp.Domain
{
    public class Lecturer
    {
        public Lecturer()
        {
            LecturerId = 1;
            LecturerName = "Budi";
            Address = "Jakarta";
        }

        public Lecturer(int lecturerId, string lecturerName, string address)
        {
            this.LecturerId = lecturerId;
            this.LecturerName = lecturerName;
            this.Address = address;
        }

        public int LecturerId { get; set; }
        public string LecturerName { get; set; }
        public string Address { get; set; }


    }
}

