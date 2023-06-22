using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC_Assignment12.Exercise1
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetUnprocessedVideo();
    }
    public class VideoRepositoty : IVideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideo()
        {
            using(var context = new VideoContext())
            {
                var videos = (from video in context.Videos where !video.IsProcesses select video).ToList();
                return videos;
            }
        }

    }
}

