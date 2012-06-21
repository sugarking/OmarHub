using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OmarHub_NM.DAL.forAddTagTableAdapters;

namespace OmarHub_NM.Entity
{
    public enum TagType
    {
        field = 0,
        location = 1,
        target = 2,
        free = 3
    }
    public class TagInfo
    {
        public void add()
        {
            new tag_nmTableAdapter().InsertTag(tag_name, tag_type);
        }
        private int tag_id;
        private string tag_name;
        private int tag_type;

        public int Tag_id
        {
            get { return tag_id; }
            set { tag_id = value; }
        }

        public string Tag_name
        {
            get { return tag_name; }
            set { tag_name = value; }
        }

        public int Tag_type
        {
            get { return tag_type; }
            set { tag_type = value; }
        }
    }
}