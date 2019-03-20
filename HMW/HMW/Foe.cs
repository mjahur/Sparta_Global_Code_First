using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace HMW
{
    public class Foe
    {
        public int foeID
        {
            get => default(int);
            set
            {
            }
        }

        public string foeName
        {
            get => default(string);
            set
            {
            }
        }

        public User user
        {
            get => default(User);
            set
            {
            }
        }
    }
}