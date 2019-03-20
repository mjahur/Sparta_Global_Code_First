using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace HMW
{
    public class Friends
    {
        public int friendID
        {
            get => default(int);
            set
            {
            }
        }

        public string friendName
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