﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class applicationglobal : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["totusers"] = 0;
            Application["activeusers"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["totusers"] = Convert.ToInt32(Application["totusers"])+1;
            Application["activeusers"] = Convert.ToInt32(Application["activeusers"]) + 1;

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["activeusers"] = Convert.ToInt32(Application["activeusers"]) - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {
              
        }
    }
}