using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.Entity;

namespace OmarHub_NM.Control
{
    /// <summary>
    /// create_offer 的摘要说明
    /// </summary>
    public class create_offer : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            Offer offer = new Offer();
            createOffer(offer, context);
            offer.add();
            context.Response.Write("offer create success");

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private void createOffer(Offer offer, HttpContext context)
        {
            offer.Offer_title = context.Request["offer_title"];
            offer.Offer_describe = context.Request["offer_describe"];
            offer.Offer_creater = Convert.ToInt32(context.Request["offer_creater"]);
            offer.Offer_create_date = DateTime.Now;
            //if (context.Request["offer_published"] == "true")
            //    offer.Offer_published = true;
            //else 
            //    offer.Offer_published = false;
        }

    }
}