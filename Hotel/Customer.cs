using INF2011S_Project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project.Hotel
{
    public class Customer
    {
        private string id;
        private string custName;
        private string phone;
        private string care;
        public Customer(string ID)
        {
            this.id = ID;
        }

        public Customer()
        {

        }

        public string GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.custName;
        }

        public string GetPhone()
        {
            return this.phone;
        }

        public string GetCare()
        {
            return this.care;
        }

        public void FillData(string custID, string customerName, string phoneNumber, string needsCare)
        {
            this.id = custID;
            this.custName = customerName;
            this.phone = phoneNumber;
            this.care = needsCare;
        }

        public static Customer FindCustomer(string custID)
        {
            HotelDB db = new HotelDB();

            for (int i = 0; i < db.CustomerList.Count; i++)
            {
                Customer customer = db.CustomerList[i];
                if (customer.GetID() == custID)
                {
                    return customer;
                }
            }

            return null;
        }

        public static Collection<Customer> GetAllCustomers()
        {
            HotelDB db = new HotelDB();

            return db.CustomerList;
        }

        public static Collection<string> GetAllCustomersByID()
        {
            HotelDB db = new HotelDB();
            Collection<string> custIDs = new Collection<string>();

            for (int i = 0; i < db.CustomerList.Count; i++)
            {
                Customer customer = db.CustomerList[i];
                custIDs.Add(customer.GetID());
            }

            return custIDs;
        }
    }
}
