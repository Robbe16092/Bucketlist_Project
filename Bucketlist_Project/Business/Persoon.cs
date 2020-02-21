using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Project.Business
{
    public class Persoon
    {
        //Velden
        private int _idpersoon;
        private string _naampersoon;
        private string _gebruikersnaam;
        private string _wachtwoord;

        //eigenschappen
        public int IDpersoon
        {
            get { return _idpersoon; }
        }

        public string Naampersoon
        {
            get { return _naampersoon; }
            set { _naampersoon = value; }
        }
        public string Gebruikersnaam
        {
            get { return _gebruikersnaam; }
            set { _gebruikersnaam = value; }
        }

        public string Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }
        //Constructor
        public Persoon(int id, string naam, string gebruikersnaam, string wachtwoord)
        {
            _idpersoon = id;
            _naampersoon = naam;
            _gebruikersnaam = gebruikersnaam;
            _wachtwoord = wachtwoord;
        }

        public Persoon( string naam, string gebruikersnaam, string wachtwoord)
        {
           
            _naampersoon = naam;
            _gebruikersnaam = gebruikersnaam;
            _wachtwoord = wachtwoord;
        }
        public Persoon(string gebruikersnaam, string wachtwoord)
        {
            _gebruikersnaam = gebruikersnaam;
            _wachtwoord = wachtwoord;
        }

        //Methode
        public override string ToString()
        {
            return "Welkom " + _naampersoon;
        }

    }
}
