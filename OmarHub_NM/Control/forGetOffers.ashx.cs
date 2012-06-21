using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.DAL.forGetOffersTableAdapters;
using System.Collections;
using System.Web.Script.Serialization;

namespace OmarHub_NM.Control
{
    /// <summary>
    /// forGetOffers 的摘要说明
    /// </summary>
    public class forGetOffers : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            ArrayList offerarr = new ArrayList();
            var items = new OfferInfoTableAdapter().GetAllOffers();
            foreach (var item in items)
            {
                OfferInfo offer = new OfferInfo();
                offer.title = item.title;
                offer.describe = item.describe;
                offer.creator_firstname = item.user_first_name;
                offer.creator_lastname = item.user_last_name;
                offer.create_date = item.create_date;
                offerarr.Add(offer);
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string json = jss.Serialize(offerarr);
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

    public class OfferInfo
    {
        public string title;
        public string describe;
        public string creator_firstname;
        public string creator_lastname;
        public DateTime create_date;
    }
}