using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.Entity;
using OmarHub_NM.DAL.forUerAddTableAdapters;
 
namespace OmarHub_NM.Control
{
    /// <summary>
    /// Addinformation 的摘要说明
    /// </summary>
    public class Addinformation : IHttpHandler
    {
       public  string first;
        public string last;
        public string email;
       public string roles;
        public string str;
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            first = context.Request["txtFirstName"];
             last = context.Request["txtLastName"];
            email = context.Request["txtEmail"];
             roles = context.Request["Roles"];
             UserType role;
             if ("Admin".Equals(roles))
                 role = UserType.Admin;
             else
                 role = UserType.OmarFellow;
             //str = first + "\n" + last + "\n" + email + "\n" + roles;
             if (Judgeemail(email) < 1 )
             //&& !string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(last) && !string.IsNullOrEmpty(roles)
                 new user_nmTableAdapter().InsertUser(first, last, (int)role, email);   
            context.Response.Write("success");

        }
        public int Judgeemail(string st)
        {

            return (int)new user_nmTableAdapter().Useremail(st);
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}