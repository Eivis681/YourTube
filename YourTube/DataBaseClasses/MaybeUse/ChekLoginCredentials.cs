using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourTube.DataClass;

namespace YourTube.DataBaseClasses
{
    public class ChekLoginCredentials
    {
        public int checkUserCredentials(string username, string password)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select Username, Password, ApiKey from User where Username ='"+username+"'";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreader=null;
            string myreaderr=null;
            string myreaderrr = null;
            while (sqlite_datareader.Read())
            {
                myreader = sqlite_datareader.GetString(0);
                myreaderr = sqlite_datareader.GetString(1);
                myreaderrr = sqlite_datareader.GetString(2);
            }
            if (myreader == username)
            {
                if (myreaderr == password)
                {
                    sqlite_conn.Close();
                    UserGetSet.input();
                    UserGetSet.username = myreader;
                    UserGetSet.password = myreaderr;
                    UserGetSet.apiKey = myreaderrr;
                    return 1;
                }
            }
            else
            {
                sqlite_conn.Close();
                return 0;
            }
            sqlite_conn.Close();
            return 6969;
            
        }
    }
}
