using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionary.Classes
{
    public class Client
    {
        public Client(Guid id, string name, string phoneNumber, string cPF, string addressId)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            CPF = cPF;
            AddressId = addressId;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CPF { get; private set; }
        public string AddressId { get; private set; }

    }
}
