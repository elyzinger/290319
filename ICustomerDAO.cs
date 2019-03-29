using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _270419
{
    interface ICustomerDAO
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer c);
        void UpDateCustomer(int id, Customer c);
        void DeletCustomer(int id);
        List<Customer> GetCustomerLivingInCity(string city);
        List<Customer> GetCustomerBetweenAges(int minAge, int maxAge);
        Customer GetCustomerByPhoneNumber(string phone);
        void RemoveAllCustomers();
    }
}
