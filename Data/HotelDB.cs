using INF2011S_Project.Hotel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project.Data
{
    public class HotelDB:DB
    {
        private string tableClerk = "Clerk";
        private string sqlClerk = "SELECT * FROM Clerk";

        private string tableBooking = "Booking";
        private string sqlBooking = "SELECT * FROM Booking";

        private string tableCustomer = "Customer";
        private string sqlCustomer = "SELECT * FROM Customer";

        private string tableHotel = "Hotel";
        private string sqlHotel = "SELECT * FROM Hotel";

        private Collection<Clerk> clerks;
        private Collection<Customer> customers;
        private Collection<Booking> bookings;
        private Collection<HotelBrand> hotels;

        public Collection<Clerk> ClerkList
        {
            get
            {
                return clerks;
            }
        }

        public Collection<Booking> BookingList
        {
            get
            {
                return bookings;
            }
        }

        public Collection<Customer> CustomerList
        {
            get
            {
                return customers;
            }
        }

        public Collection<HotelBrand> HotelList
        {
            get
            {
                return hotels;
            }
        }

        public HotelDB() : base()
        {
            clerks = new Collection<Clerk>();
            customers = new Collection<Customer>();
            bookings = new Collection<Booking>();
            hotels = new Collection<HotelBrand>();

            FillDataSet(sqlClerk, tableClerk);
            FillCollection(tableClerk);

            FillDataSet(sqlBooking, tableBooking);
            FillCollection(tableBooking);

            FillDataSet(sqlCustomer, tableCustomer);
            FillCollection(tableCustomer);

            FillDataSet(sqlHotel, tableHotel);
            FillCollection(tableHotel);
        }

        public void FillCollection(string table)
        {
            Clerk clerk;
            Booking booking;
            Customer customer;
            HotelBrand hotel;

            string clerkID;
            string name;
            string phone;
            string pass;

            string bookID;
            string duration;
            string bookingHotelID;
            string roomNum;

            string custID;
            string custName;
            string custPhone;
            string care;

            string hotelID;
            string hotelBrandName;
            
            DataRow row = null;

            foreach (DataRow row_loopVariable in dsMain.Tables[table].Rows)
            {
                row = row_loopVariable;

                switch (table)
                {
                    case "Clerk":
                        clerk = new Clerk();

                        clerkID = Convert.ToString(row["UserID"]).TrimEnd();
                        name = Convert.ToString(row["Name"]).TrimEnd();
                        phone = Convert.ToString(row["Phone"]).TrimEnd();
                        pass = Convert.ToString(row["Password"]).TrimEnd();

                        clerk.FillData(clerkID, name, phone, pass);
                        clerks.Add(clerk);

                        break;
                    case "Booking":
                        booking = new Booking();

                        bookID = Convert.ToString(row["BookingID"]).TrimEnd();
                        duration = Convert.ToString(row["DurationOfStay"]).TrimEnd();
                        bookingHotelID = Convert.ToString(row["HotelID"]).TrimEnd();
                        roomNum = Convert.ToString(row["RoomNumber"]).TrimEnd();

                        booking.FillData(bookID, bookingHotelID, duration, roomNum);
                        bookings.Add(booking);

                        break;
                    case "Customer":
                        customer = new Customer();

                        custID = Convert.ToString(row["CustomerID"]).TrimEnd();
                        custName = Convert.ToString(row["Name"]).TrimEnd();
                        custPhone = Convert.ToString(row["Phone"]).TrimEnd();
                        care = Convert.ToString(row["NeedsCare"]).TrimEnd();

                        customer.FillData(custID, custName, custPhone, care);
                        customers.Add(customer);

                        break;
                    case "Hotel":
                        hotel = new HotelBrand();

                        hotelID = Convert.ToString(row["HotelID"]).TrimEnd();
                        hotelBrandName = Convert.ToString(row["HotelName"]).TrimEnd();

                        hotel.FillData(hotelID, hotelBrandName);
                        hotels.Add(hotel);

                        break;
                }

            }
        }
    }
}
