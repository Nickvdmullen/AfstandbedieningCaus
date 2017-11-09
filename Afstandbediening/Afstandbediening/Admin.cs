using System;
using System.Collections.Generic;
using System.Text;

namespace Afstandbediening
{
    class Admin : User
    {

        public Admin(String username, String password) : base(username, password,"volledig")
        {
        }

        public void pasRestrictiesAan(User user,String restrictie)
        {

        }
        public void ToonRestrictiesUser(User user)
        {

        }
    }
}
