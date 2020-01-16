using System.Collections.Generic;
using System.Linq;

namespace User_Class_Implementation
{
    public class User
    {
        private static readonly IList<string> _userNames = new List<string>();

        public void Add(string userName) => _userNames.Add(userName);

        public int GetUsersCount() => _userNames.Count();
    }
}
