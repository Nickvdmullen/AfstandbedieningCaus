using System;
using System.Collections.Generic;
using System.Text;

namespace Afstandbediening
{
    class User
    {
        String username;
        String password;
        String rechten;
        
        public User(String username,String password,String rechten)
        {
            this.username = username;
            this.password = password;
            this.rechten = rechten;
        }

        public Content zoek(String querry,User persoon)
        {
            return null;
        }
    }
}
