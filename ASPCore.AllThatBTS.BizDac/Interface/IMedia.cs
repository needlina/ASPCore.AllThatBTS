using ASPCore.AllThatBTS.Enum;
using ASPCore.AllThatBTS.Model;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.Repository
{
    interface IMedia
    {
        List<Media> SelectMediaByType(string mediaType, int pageNo = 1, int pageSize = 15);
        List<Media> SelectMediaBySearch(string mediaType, string searchString, int pageNo = 1, int pageSize = 15);
    }
}
