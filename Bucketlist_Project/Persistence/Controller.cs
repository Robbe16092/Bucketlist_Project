using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bucketlist_Project.Business;
using Bucketlist_Project.Persistence.Mappers;

namespace Bucketlist_Project.Persistence
{
    public class Controller
    {
        private string _connectionstring;
        public Controller()
        {
            _connectionstring = "server=localhost;user id=root;database=bucketlistdb";
        }
        public Controller(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        //Uitdaging
        public void AddUitdaging(Uitdaging uit)
        {
            MapperUitdaging mapper = new MapperUitdaging(_connectionstring);
            mapper.addUitdagingtoDB(uit);
        }
        public List<Uitdaging> GetUitdaging()
        {
            MapperUitdaging mapper = new MapperUitdaging(_connectionstring);
            return mapper.getUitdagingenFromdb();
        }

        //Personen
        
        public void GetPersoon(string gebruikersnaam, string wachtwoord)
        {
            MapperPersoon mapper = new MapperPersoon(_connectionstring);
            mapper.GetPersoonFromDB(gebruikersnaam, wachtwoord);
        }
        public List<Persoon> GetPersoons()
        {
            MapperPersoon mapper = new MapperPersoon(_connectionstring);
            return mapper.GetPersoons();
        }
        public void addpersoon(Persoon per)
        {
            MapperPersoon mapper = new MapperPersoon(_connectionstring);
            mapper.addPersoonToDB(per);
        }

        //Persoonuitdaging
        public List<PersoonUitdaging> GetPersoonUitdaging()
        {
            MapperPersoonUitdaging mapper = new MapperPersoonUitdaging(_connectionstring);
            return mapper.getUitdagingFromPersoon();
        }
    }
}
