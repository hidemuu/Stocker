using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Models
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> Gets();
    }
}
