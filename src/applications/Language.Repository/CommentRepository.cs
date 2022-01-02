using Accessors;
using Language.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Repository
{
    public class CommentRepository : FileAccessor<Comment>, ICommentRepository
    {
        public readonly static string FILE_NAME = "comment";
        public CommentRepository(IFileHelper fileHelper) : base(fileHelper) { }
    }
}
