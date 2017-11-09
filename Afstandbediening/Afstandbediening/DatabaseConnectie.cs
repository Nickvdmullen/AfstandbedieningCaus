using System;
using System.Collections.Generic;
using System.Text;

namespace Afstandbediening
{
    class DatabaseConnectie
    {
        String DatabaseLocatie;
        String DatabaseType;

        public DatabaseConnectie(String locatie,String type)
        {
            this.DatabaseLocatie = locatie;
            this.DatabaseType = type;
        }

        public Content zoekFilm(string querry)
        {
            return null;
        }
        public Content zoekSerie(string querry)
        {
            return null;
        }
        public Content zoekFavorieten(string querry)
        {
            return null;
        }
        public Content zoekRechten(string querry)
        {
            return null;
        }


    }
}
