using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.Entity;

namespace OmarHub_NM.Control
{
    /// <summary>
    /// fello_inform 的摘要说明
    /// </summary>
    public class fello_inform : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo user = new UserInfo();
            //createUser(user, context);
            user.update();
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private void createUser(UserInfo user, HttpContext context)
        {
            user.User_id = Convert.ToInt32(context.Request["user_id"]);
            user.User_first_name = context.Request["first_name"];
            user.User_last_name = context.Request["last_name"];
            user.User_password = context.Request["new_password"];
            user.User_gender = Convert.ToInt32(context.Request["gender"]);
            user.User_language = Convert.ToInt32(context.Request["language"]);
            user.User_mobile_number_country_code = context.Request["mobile_number_country_code"];
            user.User_mobile_number = context.Request["mobile_number"];
            user.User_street = context.Request["street"];
            user.User_city = context.Request["city"];
            user.User_state = context.Request["state"];
            user.User_country = context.Request["country"];
            user.User_postal_code = context.Request["postal_code"];
            user.User_organization_name = context.Request["organization_name"];
            user.User_organization_acronym = context.Request["organization_aconym"];
            user.User_role_in_organization = context.Request["role_in_organization"];
            user.User_date_organization_formed = Convert.ToDateTime(context.Request["date_organization_formed"]);
            user.User_organization_web_url = context.Request["organization_web_url"];
            user.User_number_of_employees = Convert.ToInt32(context.Request["number_of_employees"]);
            user.User_organization_type = Convert.ToInt32(context.Request["organization_type"]);
            user.User_organization_annual_budget = Convert.ToInt32(context.Request["organization_anuual_budget"]);
            user.User_organization_phone_number = context.Request["organization_phone_number"];
            user.User_organization_phone_number_country_code = context.Request["organization_phone_number_country_code"];
        }
    }
}