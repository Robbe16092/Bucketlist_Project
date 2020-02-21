using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Project.Business
{
    public class PersoonUitdaging
    {
        //velden
        private int _fkPersoon;
        private int _fkUitdaging;
        private bool _status;

        //eigenschappen
        public int fkPersoon
        {
            get { return _fkPersoon; }
        }

        public int fkUitdaging
        {
            get { return _fkUitdaging; }
        }

        public bool status
        {
            get { return _status; }
            set { _status = value; }
        }

        //Constructor
        public PersoonUitdaging(bool status)
        {
            status = _status;
        }
        public PersoonUitdaging(int fkPersoon, int fkUitdaging, bool status)
        {
            fkPersoon = _fkPersoon;
            fkUitdaging = _fkUitdaging;
            status = _status;
        }

     
    }
}
