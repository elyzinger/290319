using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _270419
{
    class Customer
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string PhNumber { get; set; }

        public override string ToString()
        {
            return $"Customer: {Id} {FisrtName} {LastName}{Age}{AddressCity}{AddressStreet}{PhNumber}";
        }
    }
}
