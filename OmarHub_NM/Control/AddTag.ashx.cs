using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.DAL.forAddTagTableAdapters;

namespace OmarHub_NM.Control
{
    /// <summary>
    /// AddTag 的摘要说明
    /// </summary>
    public class AddTag : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string name = Convert.ToString(context.Request["tag_name"]);
            int type = Convert.ToInt32(context.Request["tag_type"]);
            string result = " ";
            int check = Convert.ToInt32(new tag_nmTableAdapter().CheckRepeat(name));
            if (check == 0)
            {
                new tag_nmTableAdapter().InsertTag(name, type);
                result = "Add tag successfully!";
            }
            else
            {
                result = "A same tag already exists! Please enter again.";
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