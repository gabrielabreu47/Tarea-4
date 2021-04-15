using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class UserRepository
    {
        public string User { get; set; }
        public List<User> User_List {get; set;} = new List<User>();
        public static UserRepository Instancia { get; } = new UserRepository();

        private UserRepository()
        {

        }
    }
}
