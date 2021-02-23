using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Models
{
    public class Person // Enitity -> wird Richtung DB gespeichert
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
