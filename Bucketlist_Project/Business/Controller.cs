using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bucketlist_Project.Persistence;
using Bucketlist_Project.Business.Repositories;

namespace Bucketlist_Project.Business
{
    public class Controller
    {
        private Bucketlist_Project.Persistence.Controller _controller;


        //Constructor
        public Controller()
        {
            _controller = new Persistence.Controller();
            RepositoryPersoon.Personenlijst = _controller.GetPersoons();

            RepositoryUitdaging.Uitdaginglijst = _controller.GetUitdaging();
            RepositoryPersoonUitdaging.personenuitdaginglijst = _controller.GetPersoonUitdaging();
        }
        

        

        //Uitdaging
        public List<Uitdaging> GetUitdagings()
        {
            return RepositoryUitdaging.Uitdaginglijst;
        }

        public void AddUitdagingen(Uitdaging uit)
        {
            RepositoryUitdaging.addUitdagingToRP(uit);
        }

        //Persoon
        public List<Persoon> GetPersoons()
        {
            return RepositoryPersoon.Personenlijst;
        }
        public void addPersoon(Persoon per)
        {
            RepositoryPersoon.addPersoonToRP(per);
        }

        //PersoonUitdaging
        public List<PersoonUitdaging> GetPersoonUitdaging()
        {
            return RepositoryPersoonUitdaging.personenuitdaginglijst;
        }

        
    }
}
