using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Synechron.EventsPortal.Models
{
    public class User
    {

        public int UserId { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }


        public string UserRoleName { get; set; }

    }
}