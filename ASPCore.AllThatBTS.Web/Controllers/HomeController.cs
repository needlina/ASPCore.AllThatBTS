using ASPCore.AllThatBTS.Common;
using ASPCore.AllThatBTS.Enum;
using ASPCore.AllThatBTS.Model;
using ASPCore.AllThatBTS.Repository;
using ASPCore.AllThatBTS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ASPCore.AllThatBTS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository userRepository;
        private readonly MediaRepository mediaRepository;
        private readonly CodeRepository codeRepository;

        public HomeController()
        {
            userRepository = new UserRepository();
            mediaRepository = new MediaRepository();
            codeRepository = new CodeRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetMediaByType(string mediaType, int pageNo = 1, int pageSize = 15)
        {
            List<MediaModel> mediaModels = new List<MediaModel>();
            List<Media> mediaList = new List<Media>();
            mediaList = mediaRepository.SelectMediaByTypeWithPage(mediaType, pageNo, pageSize).Items;

            if (mediaList != null)
            {
                foreach (Media mediaEntity in mediaList)
                {
                    MediaModel media = new MediaModel()
                    {
                        mediaType = EnumHelper.GetDescription(typeof(MediaType), mediaEntity.mediaType),
                        subject = mediaEntity.subject,
                        linkUrl = mediaEntity.linkURL,
                        thumbnailUrl = mediaEntity.thumbnailUrl,
                        createdDate = mediaEntity.mediaCreateDatetime.ToString()
                    };

                    mediaModels.Add(media);
                }
            }

            return Json(mediaModels);
        }

        public JsonResult GetMediaBySearch(string mediaType, string searchString, int pageNo = 1, int pageSize = 15)
        {
            List<MediaModel> mediaModels = new List<MediaModel>();
            List<Media> mediaList = new List<Media>();

            mediaList = mediaRepository.SelectMediaBySearchWithPage(mediaType, searchString, pageNo, pageSize).Items;

            if (mediaList != null)
            {
                foreach (Media mediaEntity in mediaList)
                {
                    MediaModel media = new MediaModel()
                    {
                        mediaType = EnumHelper.GetDescription(typeof(MediaType), mediaEntity.mediaType),
                        subject = mediaEntity.subject,
                        linkUrl = mediaEntity.linkURL,
                        thumbnailUrl = mediaEntity.thumbnailUrl,
                        createdDate = mediaEntity.mediaCreateDatetime.ToString()
                    };

                    mediaModels.Add(media);
                }
            }

            return Json(mediaModels);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
