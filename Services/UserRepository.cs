using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolidTest.Data;
using SolidTest.Models;
using SolidTest.Services;
namespace SolidTest.Services
{
    // Implementacion de la interfaz
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext context){
            _context = context;
        }
        public void add(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.users.ToList();
        }

        public User GetById(int id)
        {
            return _context.users.Find(id);
        }

        public void remove(int id)
        {
            var user = _context.users.Find(id);
            _context.users.Remove(user);
            _context.SaveChanges();
        }

        public void update(User user)
        {
            _context.users.Update(user);
            _context.SaveChanges();
        }
    }
}