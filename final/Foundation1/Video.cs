using System;
using System.Collections.Generic;

namespace AbstractionWithYouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _length; // in seconds
        private List<Comment> _comments;

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public string DisplayInfo()
        {
            string info = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments ({GetCommentCount()}):\n";
            foreach (var comment in _comments)
            {
                info += $"- {comment.Display()}\n";
            }
            return info;
        }
    }
}