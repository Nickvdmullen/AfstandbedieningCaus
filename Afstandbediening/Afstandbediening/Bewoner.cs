using System;
using System.Collections.Generic;
using System.Text;

namespace Afstandbediening
{
    class Bewoner : User
    {
        public Bewoner (String username,String password) : base(username,password,"beperkt")
        {
            
        }

    }
}
