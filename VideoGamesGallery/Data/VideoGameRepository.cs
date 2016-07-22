using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoGamesGallery.Models;

namespace VideoGamesGallery.Data
{
    public class VideoGameRepository
    {
        private static VideoGame[] _videoGames = new VideoGame[]
        {
            new VideoGame()
            {
                Id = 1,
                Title = "Kingdom Hearts",
                DescriptionHtml = "<p>Sora, Donal, and Goofy fight the darkness.</p>"
            },
            new VideoGame()
            {
                Id = 2,
                Title = "Kingdom Hearts II",
                DescriptionHtml = "<p>Sora, Donal, and Goofy fight the darkness, again.</p>"
            }
        };

        public VideoGame[] GetVideoGames()
        {
            return _videoGames;
        }

        public VideoGame GetVideoGame(int id)
        {
            VideoGame videoToReturn = null;
            foreach (var videoGame in _videoGames)
            {
                if(videoGame.Id == id)
                {
                    videoToReturn = videoGame;
                    break;
                }
            }
            return videoToReturn;
        }
    }
}