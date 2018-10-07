using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace YgoProPatcher
{
    class DataClass
    {
        private SQLiteConnection sqlite;
        public DataClass(string dbPath)
        {
            sqlite = new SQLiteConnection("Data Source=" + dbPath);
        }
        public DataTable SelectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            try
            {
                SQLiteCommand cmd;
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Can't open the DB: "+ex.ToString());
            }
            sqlite.Close();
            return dt;
        }

    }
   
}
