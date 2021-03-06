using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExAvocateprog15
{
    public class Applicant
    {
        public string username { get; private set; }
        public string password { get; private set; }
        public string firstname { get; private set; }
        public string lastname { get; private set; }

        public Applicant(string username, string password, string firstname, string lastname)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname ;
        }



            

    }
}