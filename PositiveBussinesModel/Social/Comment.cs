using System;
using PositiveBussinesModel.Members;
using System.Collections.Generic;

namespace PositiveBussinesModel.Social
{
    public class Comment
    {
        
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Comment> Replies { get; set; }
        public string CommentContent { get; set; }
        public Comment()
        {
            Replies = new List<Comment>();
        }
    }
}