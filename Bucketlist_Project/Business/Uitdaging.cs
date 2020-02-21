using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Project.Business
{
    public class Uitdaging
    {
        //Velden
        private int _idUitdaging;
        private string _omschrijving;
        private string _naamUitdaging;

        //Eigenschappen
        public int iduitdaging
        {
            get { return _idUitdaging; }            
        }

        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public string NaamUitdaging
        {
            get { return _naamUitdaging; }
            set { _naamUitdaging = value; }
        }

        //Constructor
        public Uitdaging(string omschrijving, string naamuitdaging)
        {
            omschrijving = _omschrijving;
            naamuitdaging = _naamUitdaging;
        }

        public Uitdaging(int iduitdaging, string omschrijving, string naamuitdaging)
        {
            iduitdaging = _idUitdaging;
            omschrijving = _omschrijving;
            naamuitdaging = _naamUitdaging;
        }
        //Methode
        public override string ToString()
        {
            return "De uitdaging is " + _naamUitdaging + ". De omschrijving is " + _omschrijving;
        }
        
    }
}
