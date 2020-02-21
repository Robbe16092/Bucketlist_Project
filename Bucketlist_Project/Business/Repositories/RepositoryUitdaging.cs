using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Project.Business.Repositories
{
     static class RepositoryUitdaging
     {
        //Velden
        private static List<Uitdaging> _uitdaginglijst;
        //eigenschappen
        public static List<Uitdaging> Uitdaginglijst
        {
            get { return _uitdaginglijst; }
            set { _uitdaginglijst = value; }
        }
        //methoden
        public static void addUitdagingToRP(Uitdaging uit)
        {
            _uitdaginglijst.Add(uit);
        }

     }
}
