using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class TagViewModel
    {
        public string Id { set; get; }

        public string Name { set; get; }

        public string Type { set; get; }

        public virtual IEnumerable<PostTagViewModel> PostTag { set; get; }
    }
}