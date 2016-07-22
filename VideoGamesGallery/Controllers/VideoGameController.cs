using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoGamesGallery.Models;
using VideoGamesGallery.Data;

namespace VideoGamesGallery.Controllers
{
    public class VideoGameController : Controller
    {
        private VideoGameRepository _videoGameRepository = null;

        public VideoGameController()
        {
            _videoGameRepository = new VideoGameRepository();
        }

        public ActionResult Index()
        {
            var videoGames = _videoGameRepository.GetVideoGames();
            return View(videoGames);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}