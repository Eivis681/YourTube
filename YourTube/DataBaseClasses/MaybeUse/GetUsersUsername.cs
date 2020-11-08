using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourTube.DataBaseClasses
{
    public class GetUsersUsername
    {
        public List<string> getUserUsername()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select Username from User";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<string> usernames = new List<string>();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                usernames.Add(myreader);
            }
            sqlite_conn.Close();
            return usernames;
        }
    }
}
