using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PersonInfo.API.Entities
{
    public class Person
    {
        public int UUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public List<ContactInfo> ContactInfoList { get; set; }

        public Person()
        {
            ContactInfoList = new List<ContactInfo>();
        }
    }
}
