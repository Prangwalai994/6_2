namespace Refactoring6_2.Mocking
{
    public interface IVideoRepository
    {
        System.Collections.Generic.IEnumerable<Video> GetUnprocessedVideos();
    }
}