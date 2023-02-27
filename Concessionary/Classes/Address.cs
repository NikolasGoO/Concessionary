using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionary.Classes
{
    public class Address
    {
        public Address(Guid addressId, string street, string postalCode, string country, string city, string complement, string state, string neighborhood)
        {
            AddressId = addressId;
            Street = street;
            PostalCode = postalCode;
            Country = country;
            City = city;
            Complement = complement;
            State = state;
            Neighborhood = neighborhood;
        }

        public Guid AddressId { get; private set; }
        public string Street { get; private set; }  
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public string City { get; private set; }
        public string Complement { get; private set; }
        public string State { get ; private set; }
        public string Neighborhood { get; private set;}
    }
}
