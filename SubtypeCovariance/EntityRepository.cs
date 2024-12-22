using System;
using System.Collections.Generic;
using System.Linq;

namespace SubtypeCovariance
{
    public class EntityRepository : IEntityRepository<User>
    {
        private readonly List<User> _users = new List<User>();

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Remove(Guid id)
        {
            var user = _users.FirstOrDefault(u => u.ID == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public User GetById(Guid id)
        {
            return _users.FirstOrDefault(u => u.ID == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
