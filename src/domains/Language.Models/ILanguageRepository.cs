using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Models
{
    public interface ILanguageRepository
    {
        ICommentRepository Comments { get; }
    }
}
