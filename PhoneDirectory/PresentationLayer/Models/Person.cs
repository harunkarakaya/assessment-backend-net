using System.Collections.Generic;
using System;

namespace PresentationLayer.Models
{
    public class Person
    {
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
