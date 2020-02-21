using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Project.Business.Repositories
{
    static class RepositoryPersoonUitdaging
    {
        private static List<PersoonUitdaging> _personenuitdaginglijst;

        public static List<PersoonUitdaging> personenuitdaginglijst
        {
            get { return _personenuitdaginglijst; }
            set { _personenuitdaginglijst = value; }
        }

       
    }
}
