using System;
using System.Collections.Generic;
using System.Text;
using ASPCore.AllThatBTS.Model;

namespace ASPCore.AllThatBTS.Repository.Repository
{
    public class CommentRepository : IComment
    {
        public void DeleteComment(string seq)
        {
            throw new NotImplementedException();
        }

        public void InsertComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> SelectAllComments(string boardSeq)
        {
            throw new NotImplementedException();
        }

        public Comment SelectCommentBySeq(string seq)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
