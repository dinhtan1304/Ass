using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC_Assignment12.Exercise1
{
    public class VideoService
    {
        private IVideoRepository _videoRepository;

        public VideoService(IVideoRepository videoRepository = null)
        {
            _videoRepository = videoRepository ?? new VideoRepositoty();
        }
        public string GetUnprocessedVideoAsCsv()
        {
            var videoIds = new List<int>();
            var videos = _videoRepository.GetUnprocessedVideo();

            foreach (var v in videos)
            {
                videoIds.Add(v.Id);
            }

            return String.Join(",", videoIds);
        }
    }
}

