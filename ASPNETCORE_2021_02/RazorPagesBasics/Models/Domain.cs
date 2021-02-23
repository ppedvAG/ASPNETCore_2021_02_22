using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesBasics.Models
{

    public interface IMyCar
    {
        string Brand { get; set; }
        string Modell { get; set; }

        DateTime ConstructionAt { get; set; }

    }

    public class MyCar : IMyCar
    {
        public string Brand { get; set; }
        public string Modell { get; set; }

        public DateTime ConstructionAt { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Address Address { get; set; }
        public Company Company { get; set; }
    }
    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }
    }
    public class Company
    {
        public string Name { get; set; }
        public string Catchphrase { get; set; }
        public string Bs { get; set; }
    }
    public class Geo
    {
        public float Lat { get; set; }
        public float Lng { get; set; }
    }
}
