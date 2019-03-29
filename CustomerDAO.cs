using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _270419
{
    class CustomerDAO : ICustomerDAO
    {
        public void AddCustomer(Customer c)
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = C:\\Users\\USER\\Desktop\\‏‏תיקיה חדשה\\sql\\290319\\db; Version=3;");

            List<Customer> customers = new List<Customer>();

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO Customer VALUES({c.Id},'{c.FisrtName}','{c.LastName}',{c.Age},'{c.AddressCity}','{c.AddressStreet}','{c.PhNumber}',)", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    

    public void DeletCustomer(int id)
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = C:\\Users\\USER\\Desktop\\‏‏תיקיה חדשה\\sql\\290319\\db; Version=3;");

            List<Customer> customers = new List<Customer>();

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM Customer", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public List<Customer> GetAllCustomers()
        {
            SQLiteConnection connection = new SQLiteConnection($"C:\\Users\\USER\\Desktop\\‏‏תיקיה חדשה\\sql\\290319\\db; Version=3;");

            List<Customer> customers = new List<Customer>();

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Customer", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            Id = (Int32)reader["ID"],
                            FisrtName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (Int32)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]

                          
                        };

                        customers.Add(c);       
                        
                    }
                    
                }
            }

            connection.Close();
            return customers;
        }

        public List<Customer> GetCustomerBetweenAges(int minAge, int maxAge)
        {
            SQLiteConnection connection = new SQLiteConnection($"C:\\Users\\USER\\Desktop\\‏‏תיקיה חדשה\\sql\\290319\\db; Version=3;");

            List<Customer> customers = new List<Customer>();

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Customer WHERE AGE > {minAge} AND AGE < {maxAge}", connection))
            {
      
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            Id = (Int32)reader["ID"],
                            FisrtName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (Int32)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]


                        };

                        customers.Add(c);
                        
                    }

                }
            }

            connection.Close();
            return customers;
            
        }

        public Customer GetCustomerById(int id)
        {
            SQLiteConnection connection = new SQLiteConnection($"C:\\Users\\USER\\Desktop\\‏‏תיקיה חדשה\\sql\\290319\\db; Version=3;");

            List<Customer> customers = new List<Customer>();

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Customer WHERE ID = {id}", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            Id = (Int32)reader["ID"],
                            FisrtName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (Int32)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]


                        };

                         customers.Add(c);
                       
                        
                    }
                    foreach(Customer c in customers)
                    {
                        Customer ca = c;
                    }
                }
            }

            connection.Close();
            return ca;

        }

        public Customer GetCustomerByPhoneNumber(string phone)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomerLivingInCity(string city)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpDateCustomer(int id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
