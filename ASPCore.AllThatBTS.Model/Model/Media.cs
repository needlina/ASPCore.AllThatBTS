using ASPCore.AllThatBTS.Enum;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASPCore.AllThatBTS.Model
{
    [TableName("TB_MEDIA")]
    public class Media
    {
        [Column("SEQ")]
        public string seq { get; set; }
        [Column("SUBJECT")]
        public string subject { get; set; }
        [Column("MEDIA_TYPE")]
        public string mediaType { get; set; }
        [Column("LINK_URL")]
        public string linkURL { get; set; }
        [Column("THUMBNAIL_URL")]
        public string thumbnailUrl { get; set; }
        [Column("MEDIA_CREATE_DT")]
        public DateTime mediaCreateDatetime { get; set; }
        [Column("RECOMMEND_CNT")]
        public string recommendCount { get; set; }
        [Column("VIEW_CNT")]
        public string viewCount { get; set; }
        [Column("CREATE_USER")]
        public string CreateUser { get; set; }
        [Column("CREATE_DT")]
        public DateTime CreateDatetime { get; set; }
        [Column("UPDATE_USER")]
        public string UpdateUser { get; set; }
        [Column("UPDATE_DT")]
        public DateTime UpdateDatetime { get; set; }
    }
}
