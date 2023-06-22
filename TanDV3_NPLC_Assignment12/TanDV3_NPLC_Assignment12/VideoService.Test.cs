using Moq;
using NPLC_Assignment12.Exercise1;

namespace TanDV3_NPLC_Assignment12
{
    public class Tests
    {
        private VideoService _videoService;
        private Mock<IVideoRepository> _videoRepository;
        [SetUp]
        public void Setup()
        {
            _videoRepository= new Mock<IVideoRepository>();
            _videoService = new VideoService(_videoRepository.Object);
        }

        [Test]
        public void GetUnprocessedVideoAsCsv_AllVideosAreProcessed_ReturnAnEmptyString()
        {
            _videoRepository.Setup(x => x.GetUnprocessedVideo()).Returns(new List<Video>());
            var result = _videoService.GetUnprocessedVideoAsCsv();
            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void GetUnprocessedVideoAsCsv_AFewUnprocessedVideos_ReturnAStringWithIdOfUnprocessedVideos()
        {
            Assert.Pass();
        }
    }
}