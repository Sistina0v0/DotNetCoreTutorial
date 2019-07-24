using System.Linq;
using Tutorial.Portal.DbContext;

namespace Tutorial.Portal.Service
{
    public class LoginService : ILoginService
    {
        private DataContext _context;
        public LoginService(DataContext context)
        {
            _context = context;
        }
        public bool Login(string userName, string pwd)
        {
            if (_context.User.FirstOrDefault(u => u.UserName == userName && u.Pwd == pwd) != null)
            {
                return true;
            }
            return false;
        }
    }
}