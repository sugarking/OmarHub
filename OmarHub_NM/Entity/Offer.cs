using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.DAL.forActivityEditTableAdapters;

namespace OmarHub_NM.Entity
{
    class Offer
    {
        private string offer_title;
        private string offer_describe;
        private int offer_creater;
        private DateTime offer_create_date;
        private Boolean offer_published;

        public string Offer_title
        {
            get { return offer_title; }
            set { offer_title = value; }
        }

        public string Offer_describe
        {
            get { return offer_describe; }
            set { offer_describe = value; }
        }

        public int Offer_creater
        {
            get { return offer_creater; }
            set { offer_creater = value; }
        }

        public DateTime Offer_create_date
        {
            get { return offer_create_date; }
            set { offer_create_date = value; }
        }

        public Boolean Offer_published
        {
            get { return offer_published; }
            set { offer_published = value; }
        }
        public void add()
        {
            new activity_nmTableAdapter().CreateActivity(
                offer_title, 0, offer_describe, offer_creater, offer_create_date
               );
        }
    }
}