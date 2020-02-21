using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Bucketlist_Project.Business;

namespace Bucketlist_Project.Persistence.Mappers
{
    class MapperUitdaging
    {
        private string _connectionstring;

        public MapperUitdaging()
        {
            _connectionstring = "server=localhost;user id=root;database=bucketlistdb";

        }
        public MapperUitdaging(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        
        //Alle uitdagingen opvragen
        public List<Uitdaging> getUitdagingenFromdb()
        {
            
            //De connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionstring);

            //Het sql commando definieren
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM bucketlistdb.tbluitdaging");

            List<Uitdaging> uitdaginglijst = new List<Uitdaging>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Uitdaging uit = new Uitdaging(Convert.ToInt16(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString());
                uitdaginglijst.Add(uit);
            }
            conn.Close();
            return uitdaginglijst;

        }
        public void addUitdagingtoDB(Uitdaging uit)
        {
            //De connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionstring);

            //Het sql commando definieren
            string opdracht = "INSERT INTO bucketlistdb.tbluitdaging (IDuitdaging, Beschrijving, NaamUitdaging) VALUES(@iduit, @besch, @nmuit)";

            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            cmd.Parameters.AddWithValue("iduit", uit.iduitdaging);
            cmd.Parameters.AddWithValue("besch", uit.Omschrijving);
            cmd.Parameters.AddWithValue("nmuit", uit.NaamUitdaging);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
