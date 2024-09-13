using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace StateManagement130924
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["TotalVisitors"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["VisitorCount"] = 0;
            int tVisitors = (int)Application["TotalVisitors"];
            tVisitors++;
            Application["TotalVisitors"] = tVisitors;
           
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
            Session["VisitorCount"] = 0;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}