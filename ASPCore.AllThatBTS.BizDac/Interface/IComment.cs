using ASPCore.AllThatBTS.Model;
using System.Collections.Generic;

namespace ASPCore.AllThatBTS.Repository
{
    interface IComment
    {
        List<Comment> SelectAllComments(string boardSeq);
        Comment SelectCommentBySeq(string seq);
        void InsertComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(string seq);
    }
}
