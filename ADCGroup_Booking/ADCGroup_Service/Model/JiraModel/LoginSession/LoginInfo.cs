﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCGroup_Service.Model.JiraModel.LoginSession
{
    public class LoginInfo
    {
        public int failedLoginCount { get; set; }
        public int loginCount { get; set; }
        public DateTime lastFailedLoginTime { get; set; }
        public DateTime previousLoginTime { get; set; }
    }
}
