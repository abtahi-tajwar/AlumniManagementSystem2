using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFinalProject_University_
{
    class AdminSession
    {
        public static int id = -1;
        public static string fname, lname, aid, email, password, picture, desc;
        public static void createSession()
        {
            DatabaseManager manager = new DatabaseManager();
            fname = manager.getAdmin("FirstName", id);
            lname = manager.getAdmin("LastName", id);
            aid = manager.getAdmin("AdminID", id);
            email = manager.getAdmin("Email", id);
            password = manager.getAdmin("Password", id);
            picture = manager.getAdmin("ProfilePicture", id);
            desc = manager.getAdmin("ProfileDescription", id);
        }
        public static void updateSession()
        {
            DatabaseManager manager = new DatabaseManager();
            fname = manager.getAdmin("FirstName", id);
            lname = manager.getAdmin("LastName", id);
            aid = manager.getAdmin("AdminID", id);
            email = manager.getAdmin("Email", id);
            password = manager.getAdmin("Password", id);
            picture = manager.getAdmin("ProfilePicture", id);
            desc = manager.getAdmin("ProfileDescription", id);
        }
        public static void resetSession()
        {
            id = -1;
        }
    }
}
