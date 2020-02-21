using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bucketlist_Project.Business;
using MySql.Data.MySqlClient;

namespace Bucketlist_Project.Persistence.Mappers
{
    class MapperPersoonUitdaging
    {
        private string _connectionstring;

        public MapperPersoonUitdaging()
        {
            _connectionstring = "server=localhost;user id=root;database=bucketlistdb";

        }
        public MapperPersoonUitdaging(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public List<PersoonUitdaging> getUitdagingFromPersoon()
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionstring);

            //Het SQL-commando definiëren
            string opdracht = "SELECT * FROM bucketlistdb.tbluitdaging";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            List<PersoonUitdaging> persoonuitdaginglijst = new List<PersoonUitdaging>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                PersoonUitdaging persuit = new PersoonUitdaging(
                Convert.ToInt16(dataReader[0]),
                Convert.ToInt16(dataReader[1]),                
                Convert.ToBoolean(dataReader[2])
                );
                persoonuitdaginglijst.Add(persuit);
            }
            conn.Close();
            return persoonuitdaginglijst;
        }
    }
}
