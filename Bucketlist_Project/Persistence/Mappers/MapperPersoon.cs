using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Bucketlist_Project.Business;

namespace Bucketlist_Project.Persistence.Mappers
{
    class MapperPersoon
    {
        private string _connectionstring;

        public MapperPersoon()
        {
            _connectionstring = "server=localhost;user id=root;database=bucketlistdb";

        }
        public MapperPersoon(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        

        public Persoon GetPersoonFromDB(string gebruikersnaam, string wachtwoord)
        {
            //Connectie met de databnk
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            //Het sql commando
            MySqlCommand cmd = new MySqlCommand("SELECT Gebruikersnaam, Wachtwoord FROM bucketistdb.tblpersoon having(Gebruikersnaam = @para1 and Wachtwoord = @para2");
            cmd.Parameters.AddWithValue("para2", wachtwoord);
            cmd.Parameters.AddWithValue("para1", gebruikersnaam);
            Persoon LoginPersoon = new Persoon(gebruikersnaam, wachtwoord);
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Persoon per = new Persoon(Convert.ToInt16(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString());
                return per;
            }
            conn.Close();
            

            conn.Close();
            return null;
        }
        public List<Persoon> GetPersoons()
        {
            //Connectie met de databnk
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            //Het sql commando
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM bucketistdb.tblpersoon");           
            List<Persoon> personenlijst = new List<Persoon>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Persoon per = new Persoon(Convert.ToInt16(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString());
            }
            conn.Close();
            return personenlijst;
        }

        public void addPersoonToDB(Persoon per)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd;
            //Het SQL-commando definiëren
            string opdracht = "INSERT INTO bucketlistdb.tblpersoon (NaamPersoon, Gebruikersnaam, Wachtwoord) VALUES (@para0, @para1, @para2)";

            cmd = new MySqlCommand(opdracht, conn);
            //voeg de waarden toe, je haalt ze uit het object per
            cmd.Parameters.AddWithValue("para0", per.Naampersoon);
            cmd.Parameters.AddWithValue("para1", per.Gebruikersnaam);
            cmd.Parameters.AddWithValue("para2", per.Wachtwoord);   
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
