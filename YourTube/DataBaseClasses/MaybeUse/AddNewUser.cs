using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourTube.DataBaseClasses
{
    public class AddNewUser
    {
       // SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
        public void addNewUser(string username, string password, string apiKey)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO User (Username, Password, ApiKey) VALUES('"+username+"' ,'"+password+"' ,'"+apiKey+"'); ";
            sqlite_cmd.ExecuteNonQuery(); 
        }
    }
}
