using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Account.Models
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAsync();
    }
}
