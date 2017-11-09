using System;
using System.Collections.Generic;
using System.Text;

namespace Afstandbediening
{
    class Content
    {
        int id;
        int volgendeAflevering;
        String titel;
        String beschrijving;
        String restrictieNiveau;

        public Content(int id, int volgende,string titel,string beschrijving,string restrictie)
        {
            this.id = id;
            this.volgendeAflevering = volgende;
            this.titel = titel;
            this.beschrijving = beschrijving;
            this.restrictieNiveau = restrictie;
        }
        

    }
}
