﻿using System;

namespace CloudFox.Presentation
{
    [Serializable()]
    public class BookmarkItem
    {
        public enum ItemTypes: int
        {
            Directory,
            Bookmark
        }

        public BookmarkItem() {}

        public string Name { get; set; }

        public string Id { get; set; }

        public string Location { get; set; }

        public string Path { get; set; }

        public string Tag { get; set; }

        public virtual ItemTypes ItemType { get; set; }
    }
}
