using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Project.Business.Repositories
{
    static class RepositoryPersoon
    {
        private static List<Persoon> _personenlijst;

        public static List<Persoon> Personenlijst
        {
            get { return _personenlijst; }
            set { _personenlijst = value; }
        }

        //methoden
        public static void addPersoonToRP(Persoon per)
        {
            _personenlijst.Add(per);
        }
        
    }
}
