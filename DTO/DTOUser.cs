using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.DTO
{
    public  sealed class DTOUser
    {
        public string User;
        public string pass;
        public int phone;
        public string email;
        public int lever;
        

        public string USER
        {
            get { return User; };
            set { User = value; }
        }
        public string PASS
        {
            get { return pass; }
            set { pass = value; }
        }

        public int PHONE
        {
            get { return phone; }  
            set { phone = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }

        }
        public int LEVER
        {
            get { return lever; }
            set { lever = value; }

        }
        public DTOUser() ;




    }




}
