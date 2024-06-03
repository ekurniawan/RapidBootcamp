using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBootcamp.ConsoleApp.Domain
{
    public class Student
    {
        //konstruktor
        public Student()
        {
            Nim = "1010101010";
            Name = "Agus Kurniawan";
            Address = "Jakarta";
        }

        public Student(string nim, string name)
        {
            this.Nim = nim;
            this.Name = name;
        }

        public Student(string nim, string name, string address)
        {
            this.Nim = nim;
            this.Name = name;
            this.Address = address;
        }

        private string nim = string.Empty;

        //object property
        public string Nim
        {
            get { return nim; }
            set
            {
                if (value.Length != 10)
                {
                    throw new Exception("NIM harus 10 karakter");
                }
                nim = value;
            }
        }

        /*public void setNim(string nim)
        {
            if (nim.Length != 10)
            {
                throw new Exception("NIM harus 10 karakter");
            }
            this.nim = nim;
        }

        public string getNim()
        {
            return nim;
        }*/

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address { get; set; } = string.Empty;


        /*public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }*/
    }
}
