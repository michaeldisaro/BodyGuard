﻿using System.Collections.Generic;
using Michaelsoft.BodyGuard.Common.Interfaces;
using Michaelsoft.BodyGuard.Common.Models;

namespace Michaelsoft.BodyGuard.Client.Models.Lists
{
    public class UserList
    {

        public string SuccessUrl { get; set; }

        public string FailureUrl { get; set; }

        public List<User> UsersData { get; set; }

        public string SubmitLabel { get; set; } // usefull for inline update
    }
}