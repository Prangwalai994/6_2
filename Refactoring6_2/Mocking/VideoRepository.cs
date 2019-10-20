﻿using System;
using System.Collections.Generic;

namespace Refactoring6_2.Mocking
{
    public class VideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideos()
        {
            using (var context = new VideoContext())
            {
                var  videos =
                (from video in context.Videos
                 where !video.IsProcessed
                 select video).ToList();

                return videos;
            }
    }
}
