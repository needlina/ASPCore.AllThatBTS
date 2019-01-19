using ASPCore.AllThatBTS.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.AllThatBTS.Web.Models
{
    public class MediaModel
    {
        public string subject { get; set; }
        public string mediaType { get; set; }
        public string linkUrl { get; set; }
        public string thumbnailUrl { get; set; }
        public string createdDate { get; set; }
    }
}
