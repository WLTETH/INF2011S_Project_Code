using INF2011S_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project.Hotel
{
    public class Clerk
    {
        private string id;
        private string name;
        private string phone;
        private string password;
        public Clerk(string ID) {
            this.id = ID;
        }

        public Clerk()
        {

        }

        public string GetID()
        {
            return this.id;
        }

        public void FillData(string clerkID, string clerkName, string clerkPhone, string clerkPass)
        {
            this.id = clerkID;
            this.name = clerkName;
            this.phone = clerkPhone;
            this.password = clerkPass;
        }

        public bool CheckPassword(string pass)
        {
            if (pass == this.password)
            {
                return true;
            }

            return false;
        }

        public static Clerk FindClerk(string clerkID)
        {
            HotelDB db = new HotelDB();

            for (int i = 0; i < db.ClerkList.Count; i++)
            {
                Clerk clerk = db.ClerkList[i];
                if (clerk.GetID() == clerkID)
                {
                    return clerk;
                }
            }

            return null;
        }

    }
}
