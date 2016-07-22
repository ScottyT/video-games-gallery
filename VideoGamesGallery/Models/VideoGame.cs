using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGamesGallery.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string DescriptionHtml { get; set; }
        public string Title { get; set; }
    }
}