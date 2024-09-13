using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement130924
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int tVisitors = (int)Application["TotalVisitors"];           
            Label1.Text = tVisitors.ToString();


            int V = (int)Session["VisitorCount"];
            V++;
            Label2.Text = V.ToString();
            Session["VisitorCount"]=V;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //method1
            Response.Cookies["mycookie"].Value = "Welcome to GTH";
            //method2
            HttpCookie c1 = new HttpCookie("cooki123");
            c1.Value = "Warje, pune";
            c1.Expires= DateTime.Now.AddDays(1);
            Response.Cookies.Add(c1);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie c1 = Request.Cookies["mycookie"];
            if (c1!=null)
            {
                Label6.Text = c1.Value;
                Label6.Text += " " + c1.Expires;
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label7.Text = "";
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                Label7.Text += "<br/>" + Request.Cookies[i].Name;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //
            Response.Cookies["cooki123"].Expires = DateTime.Now.AddMilliseconds(-1);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                if (Request.Cookies[i].Name!= "ASP.NET_SessionId")
                {
                    string cookieName = Request.Cookies[i].Name;
                    Response.Cookies[cookieName].Expires = DateTime.Now.AddDays(-1);
                }
                
            }
        }
    }
}