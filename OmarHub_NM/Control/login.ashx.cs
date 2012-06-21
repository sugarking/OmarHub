using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.DAL.forUserEditTableAdapters;

namespace OmarHub_NM.Control
{
    /// <summary>
    /// login 的摘要说明
    /// </summary>
    public class login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string email = context.Request["email"];
            string password = context.Request["password"];
            int pass = Convert.ToInt32(new user_nmTableAdapter().PassLoginCheck(email, password));
            int result = 0;
            if (pass == 0)
            {
                result = -1;
            }
            else
            {
                result = Convert.ToInt32(new user_nmTableAdapter().GetDataOfLogin(email, password).Single().user_id);
            }

            context.Response.Write(result);
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