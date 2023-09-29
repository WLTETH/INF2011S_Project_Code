using INF2011S_Project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project.Hotel
{
    public class Booking
    {
        private string id;
        private string duration;
        private string hotelName;
        private string roomNum;
        public Booking(string ID)
        {
            this.id = ID;
        }

        public Booking()
        {

        }

        public string GetID()
        {
            return this.id;
        }

        public string GetDuration()
        {
            return this.duration;
        }

        public void FillData(string bookingID, string hotel_Name, string stayDuration, string room_Num)
        {
            this.id = bookingID;
            this.duration = stayDuration;
            this.hotelName = hotel_Name;
            this.roomNum = room_Num;
        }

        public static Booking FindBooking(string bookingID)
        {
            HotelDB db = new HotelDB();

            for (int i = 0; i < db.BookingList.Count; i++)
            {
                Booking booking = db.BookingList[i];
                if (booking.GetID() == bookingID)
                {
                    return booking;
                }
            }

            return null;
        }

        public static Collection<Booking> GetAllBookings()
        {
            HotelDB db = new HotelDB();

            return db.BookingList;
        }

        public static Collection<string> GetAllBookingsByID()
        {
            HotelDB db = new HotelDB();
            Collection<string> bookingIDs = new Collection<string>();

            for (int i = 0; i < db.CustomerList.Count; i++)
            {
                Booking booking = db.BookingList[i];
                bookingIDs.Add(booking.GetID());
            }

            return bookingIDs;
        }

        public bool CreateBooking(int duration, string hotelID, int roomNumber, int customerID, DateTime checkIn)
        {
            try
            {
                HotelDB db = new HotelDB();

                // Create a new booking record in the database
                string insertSQL = $"INSERT INTO Booking (DurationOfStay, HotelID, RoomNumber, CustomerID, CheckInDate) VALUES ('{duration}', '{hotelID}', '{roomNumber}', '{customerID}', '{checkIn}')";
                db.UpdateDataSource(insertSQL, "Hotel");

                MessageBox.Show(insertSQL);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating booking");
                return false;
            }
        }


    }
}
