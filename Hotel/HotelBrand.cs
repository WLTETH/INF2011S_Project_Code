using INF2011S_Project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project.Hotel
{
    public class HotelBrand
    {
        private string id;
        private string hotelName;
        public HotelBrand(string ID)
        {
            this.id = ID;
        }

        public HotelBrand()
        {

        }

        public string GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.hotelName;
        }

        public void FillData(string hotelID, string name)
        {
            this.id = hotelID;
            this.hotelName = name;
        }

        public static HotelBrand FindHotel(string hotelID)
        {
            HotelDB db = new HotelDB();

            for (int i = 0; i < db.HotelList.Count; i++)
            {
                HotelBrand hotel = db.HotelList[i];
                if (hotel.GetID() == hotelID)
                {
                    return hotel;
                }
            }

            return null;
        }

        public static Collection<HotelBrand> GetAllHotels()
        {
            HotelDB db = new HotelDB();

            return db.HotelList;
        }

        public static Collection<string> GetAllHotelsByName()
        {
            HotelDB db = new HotelDB();
            Collection<string> hotelNames = new Collection<string>();

            for (int i = 0; i < db.HotelList.Count; i++)
            {
                HotelBrand hotel = db.HotelList[i];
                hotelNames.Add(hotel.GetName());
            }

            return hotelNames;
        }
    }
}
