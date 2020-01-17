using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class GameDate
    {
        public static DateTime Date { get; set; }

        public static string SelectedUser { get; set; }


        public static void SetUserName(string name)
        {
            SelectedUser = name;
        }

        public static string GetUser()
        {
            string n = SelectedUser;
            return n;
        }


        public static void setDate(DateTime date)
        {
            Date = date;

        }



        public static DateTime GetDate()
        {
            DateTime gamedate = Date;

            return gamedate;
        }

    }
}
